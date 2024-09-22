#pragma once
#include "Animal.h"
class Dog : public Animal
{
protected:
	double bite_force;
public:
	Dog();
	Dog(string name, int age, double kg, double bite_force);
	void Sound();
	void Show();
	void Type();
};

