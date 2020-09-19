// UndoList.h : Declaration of the CUndoList
#pragma once
#include "TableRow.h"

#if defined(_WIN32_WCE) && !defined(_CE_DCOM) && !defined(_CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA)
#error "Single-threaded COM objects are not properly supported on Windows CE platform, such as the Windows Mobile platforms that do not include full DCOM support. Define _CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA to force ATL to support creating single-thread COM object's and allow use of it's single-threaded COM object implementations. The threading model in your rgs file was set to 'Free' as that is the only threading model supported in non DCOM Windows CE platforms."
#endif

using namespace ATL;

// CUndoList
class ATL_NO_VTABLE CUndoList :
	public CComObjectRootEx<CComObjectThreadModel>,
	public CComCoClass<CUndoList, &CLSID_UndoList>,
	public IDispatchImpl<IUndoList, &IID_IUndoList, &LIBID_MapWinGIS, /*wMajor =*/ VERSION_MAJOR, /*wMinor =*/ VERSION_MINOR>
{
public:
	CUndoList()
	{
		_pUnkMarshaler = NULL;
		_mapCallback = NULL;
		_key = SysAllocString(L"");
		_lastErrorCode = tkNO_ERROR;
		_position = -1;
		_batchId = EMPTY_BATCH_ID;
		_shortcutKey = usCtrlZ;
		_dtor = false;
	}
	~CUndoList()
	{
		SysFreeString(_key);
		_dtor = true;
		Clear();
	}

	DECLARE_REGISTRY_RESOURCEID(IDR_UNDOLIST)

	BEGIN_COM_MAP(CUndoList)
		COM_INTERFACE_ENTRY(IUndoList)
		COM_INTERFACE_ENTRY(IDispatch)
		COM_INTERFACE_ENTRY_AGGREGATE(IID_IMarshal, _pUnkMarshaler.p)
	END_COM_MAP()

	DECLARE_PROTECT_FINAL_CONSTRUCT()
	DECLARE_GET_CONTROLLING_UNKNOWN()

	HRESULT FinalConstruct()
	{
		return CoCreateFreeThreadedMarshaler(GetControllingUnknown(), &_pUnkMarshaler.p);
		return S_OK;
	}

	void FinalRelease()
	{
		_pUnkMarshaler.Release();
	}

	CComPtr<IUnknown> _pUnkMarshaler;
	
public:
	STDMETHOD(Undo)(VARIANT_BOOL zoomToShape, VARIANT_BOOL* retVal);
	STDMETHOD(Redo)(VARIANT_BOOL zoomToShape, VARIANT_BOOL* retVal);
	STDMETHOD(get_UndoCount)(LONG* pVal);
	STDMETHOD(get_RedoCount)(LONG* pVal);
	STDMETHOD(get_TotalLength)(LONG* pVal);
	STDMETHOD(BeginBatch)(VARIANT_BOOL* retVal);
	STDMETHOD(EndBatch)(LONG* retVal);
	STDMETHOD(Add)( /* [in] */ tkUndoOperation operationType, /* [in] */ LONG LayerHandle,  /* [in] */ LONG ShapeIndex, /* [retval][out] */ VARIANT_BOOL *retVal);
	STDMETHOD(get_ErrorMsg)(/*[in]*/ long ErrorCode, /*[out, retval]*/ BSTR *pVal);
	STDMETHOD(get_LastErrorCode)(/*[out, retval]*/ long *pVal);
	STDMETHOD(get_Key)(/*[out, retval]*/ BSTR *pVal);
	STDMETHOD(put_Key)(/*[in]*/ BSTR newVal);
	STDMETHOD(Clear)();
	STDMETHOD(GetLastId)(LONG* retVal);
	STDMETHOD(get_ShortcutKey)(tkUndoShortcut* pVal);
	STDMETHOD(put_ShortcutKey)(tkUndoShortcut newVal);
	STDMETHOD(ClearForLayer)(LONG LayerHandle);

private:
	struct UndoListItem
	{
		const int BatchId; // globally unique across all lists but same within batch
		long ShapeIndex;
		const long LayerHandle;
		tkUndoOperation Operation;
		IShape* Shape = nullptr;
		TableRow* Row = nullptr;
		int StyleCategory = -1;
		bool WithinBatch = false;
		vector<int>* ShapeIndices = nullptr;
		Point2D ProjOffset;
		double RotationAngle = 0.0;

		UndoListItem(int id, long layerHandle, long shapeIndex, tkUndoOperation operation)
			: BatchId(id)
			, ShapeIndex(shapeIndex)
			, LayerHandle(layerHandle)
			, Operation(operation)
		{}

		UndoListItem(int id, long layerHandle, vector<int>* shapeIndices, tkUndoOperation operation)
			: BatchId(id)
			, ShapeIndex(-1)
			, LayerHandle(layerHandle)
			, Operation(operation)
			, ShapeIndices(shapeIndices)
		{}

		void SetShape(IShape* newShape)
		{
			if (Shape == newShape)
				CallbackHelper::AssertionFailed("Same shape reference in Undo list.");
			if (Shape) {
				Shape->Release();
				Shape = NULL;
			}
			Shape = newShape;
		}

		void SetRow(TableRow* newRow)
		{
			if (Row) {
				delete Row;
				Row = NULL;
			}
			Row = newRow;
		}

		~UndoListItem() {
			if (Shape) 
				Shape->Release();
			if (Row) delete Row;
			if (ShapeIndices) delete ShapeIndices;
		}
	};

private:
	static int g_UniqueId;
	static const int EMPTY_BATCH_ID;

private:
	long _lastErrorCode;
	BSTR _key;
	vector<UndoListItem*> _list;
	IMapViewCallback* _mapCallback;
	int _batchId;
	int _position;
	tkUndoShortcut _shortcutKey;
	bool _dtor;

private:
	bool UndoSingleItem(UndoListItem* item);
	bool CopyShapeState(long layerHandle, long shapeIndex, bool copyAttributes, UndoListItem* item);
	void TrimList();
	void ErrorMessage(long ErrorCode);
	bool CheckState();
	int NextId() { return ++g_UniqueId;	}
	bool CheckShapeIndex(long layerHandle, LONG shapeIndex);
	IShapefile* GetShapefile(long layerHandle);
	void ZoomToShape(VARIANT_BOOL zoomToShape, int itemIndex);
	IShape* GetCurrentState(long layerHandle, long shapeIndex);
	bool ShapeInEditor(long layerHandle, long shapeIndex);
	void FireUndoListChanged();
	long FindPosition(int postion);
	bool WithinBatch(int position);
	bool AddGroupOperation(tkUndoOperation operation, int layerHandle, vector<int>* indices, double xProjOrigin, double yProjOrigin, double angleDegrees);

public:
	void SetMapCallback(IMapViewCallback* callback){ _mapCallback = callback; }
	bool DiscardOne();
	bool AddMoveOperation(int layerHandle, vector<int>* indices, double xProjOffset, double yProjOffset);
	bool AddRotateOperation(int layerHandle, vector<int>* indices, double xProjOrigin, double yProjOrigin, double angleDegrees);
	
};
OBJECT_ENTRY_AUTO(__uuidof(UndoList), CUndoList)
