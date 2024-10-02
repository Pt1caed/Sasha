#pragma once
#include <iostream>
#include <string>
using namespace std;

#include "IOutput.h"
#include "IMath.h"
#include "ISort.h"

class Array : public IOutput, public IMath, public ISort
{
protected:
	int size;
	int* array;
public:
	Array(int size);
	~Array();
	Array(Array& obj);
	void EditIndexMassive(int index, int mean);
	void Clear();
	int& operator[](int index);

	void Show();
	void Show(string info);


	int Max();
	int Min();

	float Avg();
	bool Search();


	void SortAsc();
	void SortDesk();
	void SortByParam(bool sorter);
};

