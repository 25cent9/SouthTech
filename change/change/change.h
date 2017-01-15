#include <iostream>

using namespace std;

#ifndef CHANGE_H
#define CHANGE_H

class change{

public:
	change();
		//Default constructor

	change(double);
		//Overloaded constructor 

	int clacQuaters();
		//Function to calculate the amount of quaters
	int calcDollars();
		//Calculating the amount of dollar bills
	int calcDimes();
		//Calculating the amount of Dimes
	int calcPennies();
		//Calculatinf the amount of Pennies
	int calcNick();
		//Calculating the amount of Nickels

	int getDollar() const;
		//Return value of dollars
	int getQuaters() const;
		//Return value of quaters
	int getDime() const;
		//Return value of dimes
	int getPennies() const;
		//Return value of pennies
	int getNick() const;
		//Return values of nickles
	
	~change();

private:
	int dollars;
	double changeAmt;
	int quaters;
	int dimes;
	int nick;
	int pennies;
};

#endif