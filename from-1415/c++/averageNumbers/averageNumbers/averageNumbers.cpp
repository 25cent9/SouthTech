/*
	Programmer: Innocent Niyibizi
	Date: 4-7-2015
	Purpose: FInd avaerage of 5 numbers entered using only 2 varables
*/

#include <iostream>
using namespace std;
int main(){
	//Declaring variables
	int x = 0;
	double avg = 0;

	//Getting input
	cout<<"Please enter the first number"<<endl;
	cin>>x;
	avg+=x;	//Adding the value of x to the current of value of average

	for(int i=0; i<=3; i++){	//For loop asking for next numbers
		cout<<"Please enter the next number: "<<endl;
		cin>>x;
		avg+=x;
	}
	avg=avg/5;	//Dividing the value of average by 5
	cout<<"The average of the five numbers you entered is: "<<avg<<endl;	//Displaying the average
	system("pause");

}