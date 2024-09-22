#pragma once
#include "Animal.h"
class Hamster : public Animal
{
protected:
	double speed;
public:
	Hamster();
	Hamster(string name, int age, double kg, double speed);
	void Sound();
	void Show();
	void Type();
};

