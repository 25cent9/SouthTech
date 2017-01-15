/*
	Innocent Niyibizi
	9/16/15
	Print user name
*/

#include <string>
#include <iostream>

using namespace std;

int main(){
	string name = " ";
	cout<<"Please enter your name: \n";
	getline(cin, name);
	cout<<"Your name is "<<name<<" \n";
	system("pause");
	return 0;
}