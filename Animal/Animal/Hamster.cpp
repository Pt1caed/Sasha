#include "Hamster.h"

Hamster::Hamster() : Animal("N/A", 0, 0), speed(0)
{
}

Hamster::Hamster(string name, int age, double kg, double speed) : Animal(name, age, kg), speed(speed)
{}
void Hamster::Sound()
{
	cout << "Fr-fr" << endl;
}
void Hamster::Show()
{
	Animal::Show();
	cout << "speed: " << speed << endl;
}
void Hamster::Type()
{
	cout << "Hamster." << endl;
}