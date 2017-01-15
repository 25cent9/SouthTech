/*
	Programmer: Innocent Niyibizi
	Date: 4-30-15
	Purpose: To create address labels for uses
*/

#include <string>
#include <iostream>

using namespace std;

int main(){
	int num1 = 0;
	int num2 = 0;
	do{
		cout<<"How many labels would you like?(Between 1-5): ";
		cin>>num1;
	}while(num1<1 || num1>5);
	string line = "";
	for(int i = 0; i<num1; i++){
		
		do{
			cout<<"How many lines would you like for this label? (Between 1-4): ";
			cin>>num2;
		}while(num2<1 || num2>4);

		for(int i1 = 0; i1<num2; i1++){
			cin.ignore();
			cout<<"Line "<<i1<<" :";
			getline(cin,line,'\n');
			
		}
		cout<<"*********************************************"<<endl;
		
	}
	system("pause");
	return 0;
}