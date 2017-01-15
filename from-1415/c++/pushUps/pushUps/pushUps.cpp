/*
	Innocent Niyibizi
	5-8-15
	Push up program
*/

#include <iostream>
#include <ctype.h>
using namespace std;

void main(){
	int points = 0;
	int itteration = 0;
	int output = 0;
	cout<<"Please enter the amount of points: ";
	cin>>points;
	while(points%7 != 0){
		cout<<"Please enter a valid number that is divisible by 7: "<<endl;
		cin>>points;
	}

	itteration = points/7;
	for(int x=0; x<=itteration; x++){
		output+=(7*x);
	}
	cout<<output<<endl;
	system("pause");
}