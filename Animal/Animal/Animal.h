#pragma once
#include <iostream>
#include <string>
using namespace std;
class Animal
{
protected:
	string name;
	int age;
	double kg;
public:
	Animal();
	Animal(string name, int age, double kg);
	Animal& operator=(const Animal& other);
	virtual void Sound() = 0;
	virtual void Show()
	{
		std::cout << "name: " << name << endl;
		std::cout << "age: " << age << endl;
		std::cout << "kg: " << kg << endl;
	}
	virtual void Type() = 0;

};

