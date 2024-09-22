#include "Parrot.h"
#include "Dog.h"
#include "Cat.h"
#include "Hamster.h";
#include "Animal.h"

int main()
{
	int size = 5;
	Animal** massive = new Animal*[size];

	Cat cat("Meowmeow", 10, 20, 35);
	Dog dog("Houm", 5, 30, 100);
	Hamster hamster("Goga", 2, 100, 25);
	Parrot parrot("Fifa", 1, 200, 50);


	massive[0] = &cat;
	massive[1] = &dog;
	massive[2] = &hamster;
	massive[3] = &parrot;

	for (size_t i = 0; i < size; i++)
	{
		massive[i]->Show();
		cout << endl;
	}
}