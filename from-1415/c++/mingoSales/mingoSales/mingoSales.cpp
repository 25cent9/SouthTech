/*
	Programmer: Innocent Niyibizi
	Date: 4-7-2015
	Purpose: Display commision of two sales from two states
*/

#include <iostream>
using namespace std;
int main(){
	//Declaring variables
	double sale1 = 0;
	double sale2 = 0;
	double commisionAmnt = 0;
	double commision = 0;

	//Gathering inputs
	cout<<"Please enter the sales amount from the first state in dollar amount: $";
	cin>>sale1;
	sale1=sale1/100;
	cout<<"Please enter the sales amount from the second state in dollar amount: $";
	cin>>sale2;
	sale2=sale2/100;
	cout<<"Please enter the commision amount in whole number: ";
	cin>>commisionAmnt;

	commisionAmnt=commisionAmnt/100;
	commision = (sale1+sale2)*commisionAmnt;	//Finding commision from combined
	cout<<"The commision will be: $"<<commision*100<<endl;

	system("pause");

}