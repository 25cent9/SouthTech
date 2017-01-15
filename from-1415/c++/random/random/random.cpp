/*
	Programmer: Innocent Niyibizi
	Date: 4-30-15
	Purpose: Demostrate random number generator
*/

#include <iostream>
#include <time.h>
#include <string>
using namespace std;

int main(){
	/*
	srand(time(NULL));	//This is to seed your random function

	int rndNbr = 0;
	int guess = 0;
	rndNbr = rand() % 10+1;	//Generate random number between 1 and 10
	do{
		cout<<"What is your guess? : ";
		cin>>guess;
		if(rndNbr < guess){
			cout<<"Ooooo that's too high buddy"<<endl;
		}
		else if(rndNbr > guess){
			cout<<"That's too low of a guess buddy"<<endl;
		}
	
	}while(rndNbr != guess);
	*/
	//getline and ignore
	string name = "";
	int age = 0;
	int income = 0;
	cout<<"What is your age?: ";
	cin>>age;
	cout<<"Your age is "<<age<<endl;

	cin.ignore();
	cout<<"What is your name? : ";
	//cin>>name;
	getline(cin,name,'\n');
	cout<<name<<endl;

	cout<<"What is your yearly income?: ";
	cin>>income;
	system("pause");
	return 0;
}