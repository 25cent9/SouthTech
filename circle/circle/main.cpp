/*
	Innocent Niyibizi
	10/20/15
	Calculate area of a circle
*/

#include <iostream>
#include <string>
#include "circ.h"

int main(){
	double radi = 0;
	string colour = " ";
	char choice = ' ';
	cout<<"Please enter your radius: ";
	cin>>radi;
	cout<<"Would you like to enter a color [Y/N]: ";
	cin>>choice;
	choice=toupper(choice);
	while(choice!='Y' && choice!='N'){
		cout<<"Please enter a valid response: ";
		cin>>choice;
		choice=toupper(choice);
	}
	if(choice=='Y'){
		cout<<"Please enter your color: ";
		cin>>colour;
		Circ circl_0(radi, colour);
		cout<<"Radius: "<<circl_0.getRadi()<<endl;
		cout<<"Color: "<<circl_0.getColor()<<endl;
		cout<<"Area: "<<circl_0.calcArea()<<endl;
	}
	else{
		Circ circl_0(radi);
		cout<<"Radius: "<<circl_0.getRadi()<<endl;
		cout<<"Color: "<<circl_0.getColor()<<endl;
		cout<<"Area: "<<circl_0.calcArea()<<endl;
	}
	system("pause");
	return 0;
}
