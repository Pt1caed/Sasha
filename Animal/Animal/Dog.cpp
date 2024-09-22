#include "Dog.h"

Dog::Dog() : Animal("N/A", 0, 0), bite_force(0)
{
}

Dog::Dog(string name, int age, double kg, double bite_force) : Animal(name, age, kg), bite_force(bite_force)
{
}


void Dog::Sound()
{
	cout << "Woof!" << endl;
}
void Dog::Show()
{
	Animal::Show();
	cout << "bite force: " << bite_force << endl;
}
void Dog::Type()
{
	cout << "Dog." << endl;
}