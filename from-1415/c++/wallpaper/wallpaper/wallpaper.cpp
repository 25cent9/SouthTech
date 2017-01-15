/*
	Programmer: Innocent Niyibizi
	Date: 4-8-2015
	Purpose: Calculate the amount of wallpaper needed for one room
*/

#include <iostream>
using namespace std;
int main(){
	//Declaring variables
	double width = 0;
	double height = 0;
	double length = 0;
	double sqFeetPerRoll = 0;
	double perimeter = 0;
	double result = 0;

	//Gathering input
	cout<<"Please enter the width of the room :";
	cin>>width;
	cout<<"Please enter the length of the room :";
	cin>>length;
	cout<<"Please enter the height of the room :";
	cin>>height;
	cout<<"Please enter the number of square feet a single roll will cover :";
	cin>>sqFeetPerRoll;

	//Finding perimeter and area
	perimeter = 2*width+2*length;
	perimeter = perimeter*height;
	result = perimeter/sqFeetPerRoll;

	cout.precision(2);
	cout<<result<<" rolls are needed to wallpaper "<<perimeter<<" square feet."<<endl;
	system("pause");

}