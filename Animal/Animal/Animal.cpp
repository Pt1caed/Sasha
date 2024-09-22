#include "Animal.h"


Animal::Animal() : name("N/A"), age(0), kg(0.0) {}
Animal::Animal(string name, int age, double kg) : name(name), age(age), kg(kg) {}

Animal& Animal::operator=(const Animal& other)
{
	if (this == &other)
	{
		return *this;
	}
	this->name = other.name;
	this->age = other.age;
	this->kg = other.kg;
	return *this;
}