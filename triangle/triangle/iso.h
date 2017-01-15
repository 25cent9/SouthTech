#ifndef ISO_H
#define ISO_H

#include <iostream>
#include "triangle.h"
using namespace std;

class Iso : public Triangle{

public:
	Iso();

	Iso(int, int, int);

	~Iso();
	
	int getBase() const;

	int getSideOne() const;

	void setBase(int);

	void setSideOne(int);

	int getSideOne(int )const;

	int getPerim() const;

	void perimInfo() const;

private:
	int base;
	int sideOne;

};


#endif