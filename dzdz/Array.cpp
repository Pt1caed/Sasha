#include "Array.h"


Array::Array(int size)
{
	if (size <= 0)
	{
		this->size = 1;
	}
	else
	{
		this->size = size;
	}
	array = new int[this->size];
}
Array::~Array()
{
	delete[] array;
}
Array::Array(Array& obj)
{
	delete[] array;
	this->size = obj.size;

	array = new int[size];

	for (size_t i = 0; i < size; i++)
	{
		array[i] = obj.array[i];
	}
}
void Array::EditIndexMassive(int index, int mean)
{
	array[index] = mean;
}
void Array::Clear()
{
	for (size_t i = 0; i < size; i++)
	{
		array[i] = '\0';
	}
}
int& Array::operator[](int index)
{
	return array[index];
}



void Array::Show()
{
	for (size_t i = 0; i < size; i++)
	{
		cout << array[i] << "  ";
	}
	cout << endl;
}

void Array::Show(string info)
{
	Show();
	cout << "Info: " << info << endl;
}



int Array::Max()
{
	int max = array[0];
	if (size == 1)
	{
		return max;
	}
	for (size_t i = 1; i < size; i++)
	{
		if (array[i] >= max)
		{
			max = array[i];
		}
	}
	return max;
}

int Array::Min()
{
	int min = array[0];
	if (size == 1)
	{
		return min;
	};
	for (size_t i = 1; i < size; i++)
	{
		if (array[i] >= min)
		{
			min = array[i];
		}
	}
	return min;
}


float Array::Avg()
{
	float summa = 0;

	for (size_t i = 0; i < size; i++)
	{
		summa += array[i];
	}
	return summa / size;
}


bool Array::Search()
{
	int num;

	cin >> num;

	for (size_t i = 0; i < size; i++)
	{
		if (array[i] == num)
		{
			return true;
		}
	}
	return false;
}


void Array::SortAsc()
{
	for (size_t k = 0; k < size; k++)
	{
		for (size_t i = 0; i < size - k - 1; i++)  
		{
			if (array[i] > array[i + 1]) 
			{
				swap(array[i], array[i + 1]);  
			}
		}
	}
}
void Array::SortDesk()
{
	for (size_t k = 0; k < size; k++)
	{
		for (size_t i = 0; i < size - k - 1; i++)  
		{
			if (array[i] < array[i + 1]) 
			{
				swap(array[i], array[i + 1]); 
			}
		}
	}
}
void Array::SortByParam(bool sorter)
{
	if (sorter)
	{
		SortAsc();
	}
	else
	{
		SortDesk();
	}
}