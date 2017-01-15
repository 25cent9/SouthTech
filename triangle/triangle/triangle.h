
#ifndef TRIANGLE_H
#define TRIANGLE_H
using namespace std;
class Triangle{

public:

	Triangle();
	Triangle(int);

	int getHeight() const;
	void setHeight(int);
	~Triangle();
	double getArea(int) const;


private:
	int newHeight;

	/*
protected: //Means that it is public to classes that inhereit this class
	int height;

	*/
};



#endif