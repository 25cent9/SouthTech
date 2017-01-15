/*
	Programmer: Innocent Niyibizi
	Date: 4-20-15
	Purpose: Practice functions

*/

#include <iostream>
using namespace std;
//Prototypes
void prntDollar(int);
int main(){
	int nbr = 0; 
	cout<<"Please enter the number of dollar signs you want to see: ";
	cin>>nbr;
	prntDollar(nbr);	//This is a call statement to a function

	system("pause");
	return 0;
}
void prntDollar(int a){
	for(int x=0; x<a; x++){
		cout<<"$";
	}
	cout<<endl;
}
