/*
	Programmer: Innocent Niyibizi
	Date: 4-20-15
	Purpose: Practice loops
*/
#include <iostream>
using namespace std;
int main(){

	int userInput=0;
	int x = 0;
	cout<<"For loop"<<endl;
	cout<<"Please enter the number of times you want the loop to execute: ";
	cin>>userInput;
	for(int x=0; x<=userInput; x++){
		cout<<x<<endl;
	}
	//Pretest loop
	int y = 0;
	cout<<"PreTest Loop"<<endl;
	while(y<=userInput){
		cout<<y<<endl;
		y++;
	}
	//Posttest loop 
	int z =0;
	cout<<"PostTest Loop"<<endl;
	do{
		cout<<z<<endl;
		z++;
	}
	while(z <= userInput);
	system("pause");
	return 0;
}