//	Header ==> Function Declaration
#include <iostream>
#include <string>

using namespace std;

#ifndef BMI_H
#define BMI_H

class BMI{

public:
	//Default Constructor
	BMI();

	//Overload constructor
	BMI(string, int, double);


	//Destructor
	~BMI();

	//Acceessor functions
	string getName() const;
		//Returns name
	int getHeight()const;
		//Returns height
	double getWeight()const;
		//Returns weight

	//Mutator Functions
	void setName(string);
		//setName - sets name
		//@param - name
	void setHeight(int);
		//setHeight - sets height
		//@param int - height 
	void setWeight(double);
		//setweight - sets weight
		//@param double - sets weight

	double calcBMI();
		//calcBMI - calculates BMI 
		//@param - returns double
private: 
	//Member variables
	string newName;
	int newHeight;
	double newWeight;
	
};
#endif