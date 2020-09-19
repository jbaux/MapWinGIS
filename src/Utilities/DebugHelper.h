#pragma once

namespace Debug
{
	void CPL_STDCALL CustomCPLErrorHandler(CPLErr error, int errorCode, const char* message);
	void Init();
	bool IsDebugMode();
	void WriteWithThreadId(CString msg, DebugTarget target = DebugAny);
	void WriteWithTime(CString msg, DebugTarget target = DebugAny);
	void WriteLine(_In_z_ _Printf_format_string_ const char* const format, ...);
	void WriteError(_In_z_ _Printf_format_string_ const char* const format, ...);
	CString Format(_In_z_ _Printf_format_string_ const char* const format, ...);
	bool LogTiles();
}

