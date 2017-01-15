#include <iostream>

using namespace std;

#ifndef RECTANGLE_H
#define RECTANGLE_H

class RECTANGLE{
public: 

	RECTANGLE();


	RECTANGLE(double, double);

	~RECTANGLE();

	double getHeight() const;
	double getLength() const;

	double calcArea();
	double clacPerm();

private:

	double newHeight;
	double newLength;
};







#endif