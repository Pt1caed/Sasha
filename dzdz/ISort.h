#pragma once
class ISort
{
public:
	virtual void SortAsc() = 0;
	virtual void SortDesk() = 0;
	virtual void SortByParam(bool sorter) = 0;
};

