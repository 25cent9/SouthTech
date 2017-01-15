/*
	Programmer: Innocent Niyibizi
	Date: 4-8-15
	Purpose: Convert inches to centimenters and vice versa, 

*/

#include <iostream>


using namespace std;
int main(){
	//Declaring variables
	char input;
	double amount = 0;
	double result = 0;

	//Getting first input
	cout<<"Please enter 'g' to convert from gallons to liters, or 'i' to convert from inches to centimeters : ";
	cin>>input;
	//Checking to see if input is equal to I
	if(input == 'i' || input == 'I'){
		cout<<"Please enter the amount of inch(es) that you wish to convert : ";
		cin>>amount;
		result=amount*2.54;
		cout<<amount<<" inch(es) is equal to "<<result<<" centimeter(s)"<<endl;
	}
	//Checking to see if input is equal to G
	else if(input == 'g' || input == 'G'){
		cout<<"Please enter the amount of gallons that you wish to convert : ";
		cin>>amount;
		result=amount*3.78541;
		cout<<amount<<" gallons is equal to "<<result<<" liter(s)"<<endl;
	}
	system("pause");
}