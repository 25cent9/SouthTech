/*
	Programmer: Innocent Niyibizi
	Date: 4-8-15
	Purpose: To calculate the bill of customer based on typed envelopes and typed pages
*/

#include <iostream>
using namespace std;

int main(){
	//Declaring variables
	double typedEnvelopeCharge = 0;
	double typedPageCharge = 0;
	double typedEnvelope = 0;
	double typedPage = 0;
	double totalAmnt = 0;
	//Gathering input

	cout<<"Please enter the amount of typed envelopes : ";
	cin>>typedEnvelope;
	cout<<"What is the charge per typed envelopes in dollar ammount? : $";
	cin>>typedEnvelopeCharge;
	cout<<"Please enter the amount of typed pages : ";
	cin>>typedPage;
	cout<<"What is the charge per typed pages in dollar ammount? : $";
	cin>>typedPageCharge;

	//Loops to calculate total amount due
	for(int i=0; i!=typedEnvelope; i++){
		totalAmnt+=typedEnvelopeCharge;
	}
	for(int i=0; i!=typedPage; i++){
		totalAmnt+=typedPageCharge;
	}
	
	//Displaying the total amount 
	cout<<"The total amount due is $"<<totalAmnt<<endl;
	system("pause");

}