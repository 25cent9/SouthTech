/*
	Programmer: Innocent Niyibizi
	Date: 4-7-15
	Purpose: To calculate the tip from a user's bill
*/

#include <iostream>

using namespace std;
int main(){
	//Declaring variables
	double bill = 0;
	double tip = 0;
	double final = 0;

	cout<<"Please enter your bill amount in dollars: "<<endl;
	cin>>bill;
	cout<<"Please enter your tip amount: "<<endl;
	cin>>tip;
	tip=tip/100;	//Converting tip amount entered into a decimal
	final = bill+(bill*tip);	//Calculating the final price
	cout<<"Your final bill is: $"<<final<<endl;
	system("pause");
}