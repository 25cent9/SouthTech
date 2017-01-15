/*
	Programmer: Innocent Niyibizi
	Date: 4-27-15
	Purpose: Get and display age
*/

#include <iostream>

using namespace std;

void getAge(int &);	//Pass by reference
void displayAge(int);	//Pass by value
int main(){
	int age = 0;
	
	getAge(age);	//Formal argument

	displayAge(age);

	system("pause");
	return 0;
}
//getAge - gets the age of the user
void getAge(int &inYears){
	cout<<"How old are you?: ";
	cin>>inYears;

}

//Displays the age used as input
void displayAge(int years){
	cout<<"You are "<<years<<" years old."<<endl;
}