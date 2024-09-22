#include "Parrot.h"

Parrot::Parrot() : Animal("N/A", 0, 0), height_fly(0)
{
}
Parrot::Parrot(string name, int age, double kg, double height_fly) : Animal(name, age, kg), height_fly(height_fly)
{
}
void Parrot::Sound()
{
	cout << "P-prrivet!" << endl;
}
void Parrot::Show()
{
	Animal::Show();
	cout << "height fly: " << height_fly << endl;
}
void Parrot::Type()
{
	cout << "Parrot." << endl;
}