#pragma once

class ReferenceCounter
{
	static const int INTERFACES_COUNT = 100;
	int referenceCounts[INTERFACES_COUNT] = {0};
	int totalCounts[INTERFACES_COUNT] = {0};
public:
	ReferenceCounter(void)  {}
	~ReferenceCounter(void) {}
	void AddRef(tkInterface type)
	{
		int* refCount = &referenceCounts[(int)type];
		(*refCount)++;
		int* totalCount = &totalCounts[(int)type];
		(*totalCount)++;
	}
	void Release(tkInterface type)
	{
		int* val = &referenceCounts[(int)type];
		(*val)--;
	}
	void WriteReport(bool unreleasedOnly);
	CString GetReport(bool unreleasedOnly);
};
