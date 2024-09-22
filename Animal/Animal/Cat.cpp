#include "Cat.h"


Cat::Cat() : Animal("N/A", 0, 0), height_jump(0)
{}

Cat::Cat(string name, int age, double kg, double height_jump) : Animal(name, age, kg), height_jump(height_jump)
{}

void Cat::Sound()
{
	cout << "meow~" << endl;
}
void Cat::Show()
{
	Animal::Show();
	cout << "heigh jump: " << height_jump << endl;
}
void Cat::Type()
{
	cout << "Cat." << endl;
}
