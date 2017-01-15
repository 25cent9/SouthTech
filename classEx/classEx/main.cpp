/*
	Innocent Niyibizi
	10/19/15
	Practice classes
*/
#include <iostream>
#include <string>

#include "BMI.h"

using namespace std;

int main(){

	string name;
	int height;
	double weight;
	cout<<"Enter your  name: ";
	cin>>name;
	cout<<"Enter your height (in inches): ";
	cin>>height;
	cout<<"Enter your weight (in pounds):";
	cin>>weight;

	BMI Students_0(name, height, weight);
	cout<<endl<<"Name: "<<Students_0.getName()<<endl;
	cout<<"Height: "<<Students_0.getHeight()<<endl;
	cout<<"Weight: "<<Students_0.getWeight()<<endl;
	cout<<"BMI: "<<Students_0.calcBMI()<<endl<<endl;

	cout<<"Enter your  name: ";
	cin>>name;
	cout<<"Enter your height (in inches): ";
	cin>>height;
	cout<<"Enter your weight (in pounds):";
	cin>>weight;

	BMI Students_1;
	Students_1.setName(name);
	Students_1.setHeight(height);
	Students_1.setWeight(weight);

	cout<<endl<<"Name: "<<Students_1.getName()<<endl;
	cout<<"Height: "<<Students_1.getHeight()<<endl;
	cout<<"Weight: "<<Students_1.getWeight()<<endl;

	cout<<"BMI: "<<Students_1.calcBMI()<<endl;
	system("pause");
	return 0;
}
