#include <vector>
#include <iostream>
#include <string>
#include <vector>
using namespace std;

// 1

void SummaNums()
{
	vector<int> a = { 54, 23 };
	vector<int>::iterator ptr;
	int summa = 0;
	for (ptr = a.begin(); ptr != a.end(); ptr++)
	{
		int num = *ptr;
		int num1;
		for (size_t i = 0; num != 0; i++)
		{

			num1 = num % 10;
			summa += num1;
			num /= 10;
		}
	}
	cout << summa << endl;
}

// 2

void MeanPositiveNums()
{
	vector<int> vector1 = { 22, 11, -23, -100, 53 };
	vector<int>::iterator ptr;
	int count = 0;
	int summa = 0;
	for (ptr = vector1.begin(); ptr != vector1.end(); ptr++)
	{
		int num = *ptr;
		if (num >= 0)
		{
			summa += num;
			count++;
		}
	}
	int mean = summa / count;
	cout << "arithmetic mean: " << mean << endl;
}

// 3

void MaxNegative()
{
	vector<int> vector2 = { -11, -2, 1, -100, -300 };
	vector<int>::iterator ptr;
	int index = -1;
	int max_negative = vector2[0];
	for (ptr = vector2.begin(); ptr != vector2.end(); ptr++)
	{
		if (*ptr < max_negative && *ptr < 0)
		{
			max_negative = *ptr;
			index = distance(vector2.begin(), ptr);
		}
	}
	cout << "num: " << max_negative << endl;
	cout << "index: " << index << endl;
}

// 4

void NumBig()
{
	vector<int> vector2 = { -11, -2, 1, -100, -300, -11 };
	vector<int>::iterator ptr;
	vector<int>::iterator ptr1;
	int count = 0;
	int count_max = 0;
	int often_num = 0;
	int index;
	for (ptr = vector2.begin(); ptr != vector2.end(); ptr++)
	{
		count = 0;
		often_num = *ptr;
		index = distance(vector2.begin(), ptr);
		for (ptr1 = vector2.begin(); ptr1 != vector2.end(); ptr1++)
		{
			if (*ptr == *ptr1)
			{
				count++;
			}
		}
		if (*ptr != vector2[0] && count_max < count)
		{
			count_max = count;
			often_num = *ptr;
			index = distance(vector2.begin(), ptr);
		}
		else
		{
			count_max = count;
			often_num = *ptr;
			index = distance(vector2.begin(), ptr);
		}
	}
	cout << "num: " << often_num << endl;
	cout << "count: " << count_max << endl;
	cout << "index: " << index << endl;
}

// 5

bool isDivide(vector<int> massive, int num)
{
	vector<int>::iterator ptr;
	int count = 0;
	for (ptr = massive.begin(); ptr != massive.end(); ptr++)
	{
		if(*ptr % 3 == 0)
		{
			count++;
		}
	}
	if (count == 0)
	{
		return false;
	}
	else
	{
		return true;
	}
}

void NotPaired()
{
	vector<int> vector3 = { 11, 3, 13};
	int max = INT_MIN;
	int index = -1;
	bool isMax = false;
	if (!isDivide(vector3, 3))
	{
		cout << "Elements in massive aren't divides on 3" << endl;
		return;
	}
	
	for (size_t i = 1; i < vector3.size(); i+=2)
	{
		if (vector3[i] % 3 == 0)
		{
			if (!isMax)
			{
				max = vector3[i];
				isMax = true;
				index = i;
			}
			else if (vector3[i] > max)
			{
				max = vector3[i];
				index = i;
			}
		}
	}
	if (isMax)
	{
		cout << "max: " << max << endl;
		cout << "index: " << index << endl;
	}
	else
	{
		cout << "Elements in massive aren't divides on 3" << endl;
	}


}

// 6

void PairedElem()
{

	vector<int> vector4 = { 11, 3, 13, 2, 15, 3, 19 };
	
	for (int value : vector4)
	{
		cout << value << "  ";
	}
	cout << endl;
	int max = vector4[0];
	int min = vector4[1];
	int index_min = 1;
	int index_max = 0;

	for (size_t i = 0; i < vector4.size(); i++)
	{
		if(i % 2 != 0)
		{
			if (min > vector4[i])
			{
				min = vector4[i];
				index_min = i;
			}
		}
		if (i % 2 == 0)
		{
			if (max < vector4[i])
			{
				max = vector4[i];
				index_max = i;
			}
		}
	}
	if (min == max)
	{
		fill(vector4.begin(), vector4.end(), 0);
	}
	else
	{
		swap(vector4[index_min], vector4[index_max]);
	}

	for (int value : vector4)
	{
		cout << value << "  ";
	}
	cout << endl;
}

// 7

void SpecialElement(vector<int>& vector1, vector<int>& vector2, vector<int>& vector3)
{
	bool isError = false;
	for (size_t i = 0; i < vector1.size(); i++)
	{
		isError = false;
		for (size_t j = 0; j < vector2.size(); j++)
		{
			if (vector1[i] == vector2[j])
			{
				isError = true;
				break;
			}
		}
		if (!isError)
		{
			vector3.push_back(vector1[i]);
		}
	}
}

void FindCommonElements(const vector<int>& vector1, const vector<int>& vector2, vector<int>& vectorCommon)
{

	for (size_t i = 0; i < vector1.size(); i++)
	{
		for (size_t j = 0; j < vector2.size(); j++)
		{
			if (vector2[j] == vector1[i])
			{
				vectorCommon.push_back(vector2[j]);
				break;
			}
		}
	}
}

void Massives()
{
	vector<int> vector1 = { 1, 2, 3 };
	vector<int> vector2 = { 3, 4, 5 };
	vector<int> vector3;


	SpecialElement(vector1, vector2, vector3);
	SpecialElement(vector2, vector1, vector3);
	FindCommonElements(vector1, vector2, vector3);
	for (int i : vector3)
	{
		cout << i << " ";
	}
	cout << endl;
}

int main()
{
	//SummaNums(); // 1
	//MeanPositiveNums(); // 2
	//MaxNegative(); // 3
	////NumBig(); // 4
	//NotPaired(); // 5
	//PairedElem(); // 6
	Massives(); // 7


}
