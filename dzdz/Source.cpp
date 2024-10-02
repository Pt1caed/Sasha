#include "Array.h"
int main()
{
	Array array(5);
	array.EditIndexMassive(0, -1);
	array.EditIndexMassive(1, 0);
	array.EditIndexMassive(2, 1);
	array.EditIndexMassive(3, 2);
	array.EditIndexMassive(4, 3);

	array.Show("Hello");
	array.SortByParam(0);
	array.Show();
	cout << array.Avg() << endl;
}