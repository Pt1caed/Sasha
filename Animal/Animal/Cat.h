#pragma once
#include "Animal.h"
class Cat : public Animal
{
protected:
	double height_jump;
public:
	Cat();
	Cat(string name, int age, double kg, double height_jump);
	void Sound();
	void Show();
	void Type();
};

