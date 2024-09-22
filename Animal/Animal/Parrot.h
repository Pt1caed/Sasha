#pragma once
#include "Animal.h"
class Parrot : public Animal
{
protected:
	double height_fly;
public:
	Parrot();
	Parrot(string name, int age, double kg, double bite_force);
	void Sound();
	void Show();
	void Type();
};

