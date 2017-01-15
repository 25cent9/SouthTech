/*
	Programmer: Innocent Niyibizi
	Date: 4-21-15
*/
#include <iostream>
using namespace std;
void displayMenu(){
	cout<<"***************"<<endl<<endl;
	cout<<"Menu"<<endl<<endl;
	cout<<"***************"<<endl;
	cout<<"1: Add"<<endl;
	cout<<"2: Subtract"<<endl;
	cout<<"3: Multiply"<<endl;
	cout<<"4: Divide"<<endl;
	cout<<"5: Modulous"<<endl;
}
int add(int n1,int n2){
	return n1+n2;
}
int sub(int n1,int n2){
	return n1-n2;
}
int mult(int n1,int n2){
	return n1*n2;
}
double divd(int n1,int n2){
	return n1/n2;
}
double mod(int n1,int n2){
	return n1%n2;
}
int main(){
	
	double num1 =0;
	double num2 =0;
	double x =0;
	char yayOrNay = ' ';
	do{
		displayMenu();
		int menuChoice = 0;
		cin>>menuChoice;
	
		switch(menuChoice){
			case 1:
				cout<<"Please input the first number: ";
				cin>>num1;
				cout<<"Please input the second number: ";
				cin>>num2;
				x=add(num1, num2);
				cout<<"The answer is "<<x<<endl;
				cout<<"Would you like to do another problem? (y or n) :";
				cin>>yayOrNay;
				yayOrNay=tolower(yayOrNay);
				break;
			case 2:
				cout<<"Please input the first number: ";
				cin>>num1;
				cout<<"Please input the second number: ";
				cin>>num2;
				x=sub(num1, num2);
				cout<<"The answer is "<<x<<endl;
				cout<<"Would you like to do another problem? (y or n) :";
				cin>>yayOrNay;
				yayOrNay=tolower(yayOrNay);
				break;
			case 3:
				cout<<"Please input the first number: ";
				cin>>num1;
				cout<<"Please input the second number: ";
				cin>>num2;
				x=mult(num1, num2);
				cout<<"The answer is "<<x<<endl;
				cout<<"Would you like to do another problem? (y or n) :";
				cin>>yayOrNay;
				yayOrNay=tolower(yayOrNay);
				break;
			case 4:
				cout<<"Please input the first number: ";
				cin>>num1;
				cout<<"Please input the second number: ";
				cin>>num2;
				x=divd(num1, num2);
				cout<<"The answer is "<<x<<endl;
				cout<<"Would you like to do another problem? (y or n) :";
				cin>>yayOrNay;
				yayOrNay=tolower(yayOrNay);
				break;
			case 5:
				cout<<"Please input the first number: ";
				cin>>num1;
				cout<<"Please input the second number: ";
				cin>>num2;
				x=mod(num1, num2);
				cout<<"The answer is "<<x<<endl;
				cout<<"Would you like to do another problem? (y or n) :";
				cin>>yayOrNay;
				yayOrNay=tolower(yayOrNay);
				break;
		}
	}
	while(yayOrNay == 'y');
	system("pause");
	return 0;
}