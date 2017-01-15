/*
	Programmer: Innocent Niyibizi
	Date: 4-6-2015
	Purpose: Add, Subtract, Divide, Multiply 2 numbers
*/
//iostream is a library we need for cin, cout, and endl
#include <iostream>
//Everything in the standard library lives inside a special container named "std"
//"using namespace std; is called a directive which tells the compiler that we want everything in the std namespcae"
using namespace std;
using std::cout;
using std::cin;
using std::endl;

int x = 360;

int main(){
	//Declaration section
	int num1 = 0;
	int num2 = 0;
	
	//Input section
	cout<<"Enter yout first number to be used "<<endl;
	cin>>num1;
	cout<<"Enter yout second number to be used "<<endl;
	cin>>num2;

	//Output section
	cout<<"Addition: "<<num1+num2<<endl;
	cout<<"subtraction: "<<num1-num2<<endl;
	cout<<"multiplication: "<<num1*num2<<endl;
	cout<<"Division: "<<num1/num2<<endl;

	system("pause");

}