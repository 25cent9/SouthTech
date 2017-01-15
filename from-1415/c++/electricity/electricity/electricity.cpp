/*
	Programmer: Innocent Niyibizi
	Date: 4-27-15
	Purpose: To calculate the amount of electricity used and the amount billed for used electricity
*/

#include <iostream>
#include <iomanip>

using namespace std;
void getInput(double &, double &);
double calcBill(double, double, double); 
void displayBill(double);

int main(){
	double beginAmt = 0.0;
	double endAmt = 0.0;
	double tot = 0.0;
	double const RATE = 0.11;

	getInput(beginAmt, endAmt);
	tot=calcBill(beginAmt, endAmt, RATE);
	displayBill(tot);

	system("pause");
	return 0;
}

void getInput(double &start, double &end){
	cout<<"What is the starting amount? : ";
	cin>>start;
	cout<<"What is the ending amount? : ";
	cin>>end;
}

double calcBill(double start, double end, double rate){
	return (end-start)*rate;
}

void displayBill(double amt){
	cout<<"Your total is $"<<amt<<endl;
}