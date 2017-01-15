/*
	Innocent Niyibizi
	10/19/15
	Create program to calculate area and perimeter of rectangle using classes
*/
#include <iostream>

#include "RECTANGLE.h"

using namespace std;

int main(){

	double height;
	double length;
	cout<<"Enter the height: ";
	cin>>height;
	cout<<"Enter the length: ";
	cin>>length;

	RECTANGLE rec_0(height, length);
	cout<<endl<<"Height: "<<rec_0.getHeight()<<endl;
	cout<<"Length: "<<rec_0.getLength()<<endl;

	cout<<endl<<"The rectangle has an area of "<<rec_0.calcArea()<<endl;
	cout<<"The rectangle has perimemeter of "<<rec_0.clacPerm()<<endl;

	system("pause");
	return 0;
}
