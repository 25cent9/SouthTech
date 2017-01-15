#include <iostream>
#include <string>
using namespace std;

#ifndef CIRC_H
#define CIRC_H

class Circ{
public:

	Circ();


	Circ(double, string);
	Circ(double);
	

	double getRadi()const;
	string getColor()const;
	double calcArea();
	~Circ();


private:
	double newRadius;
	string newColor;

};

#endif