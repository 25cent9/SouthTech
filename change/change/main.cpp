/*
	Innocent Niyibizi
	10/20/15
	Create program to output change 
*/

#include <iostream>
#include "change.h"

using namespace std;
void print(const change);
int main(){

	double amt = 0.0;
	double pay = 0.0;
	cout<<"How much was your meal?: ";
	cin>>amt;
	cout<<"What are you paying?: ";
	cin>>pay;
	change change_0(pay-amt);	//Creating new object called change_0 and setting the change to the value of pay-amt
	print(change_0);	//Calling function to print values
	system("pause");
	return 0;
}
void print(change trans){ //Funtion to print out the values of each coin
	cout<<endl<<"**************************"<<endl;
	cout<<"*\tYour Change:\t *"<<endl<<"*\t\t\t *"<<endl;
	if(trans.calcDollars()>0){
		cout<<"*\tDollars: "<<trans.getDollar()<<"\t *"<<endl;
	}
	if(trans.clacQuaters()>0){
		cout<<"*\tQuaters: "<<trans.getQuaters()<<"\t *"<<endl;
	}
	if(trans.calcDimes()>0){
		cout<<"*\tDimes: "<<trans.getDime()<<"\t *"<<endl;
	}
	if(trans.calcNick()>0){
		cout<<"*\tNickles: "<<trans.getNick()<<"\t *"<<endl;
	}
	if(trans.calcPennies()>0){
		cout<<"*\tPennies: "<<trans.getPennies()<<"\t *"<<endl;
	}
	cout<<"**************************"<<endl;
}