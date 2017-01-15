/*
	Innoceny Niyibzi
	9/29/15
	Find and explain examples of substring and string find
*/

#include <iostream>
#include <string>

using namespace std;

int main(){
	string hello;
	string sub = " ";
	int pos = 0;
	hello = "Hello World";
	
	sub = hello.substr(0, 5);	//Finds characters from the 0 to 5 positions and sets sub equal to that
	cout<<hello<<endl<<sub<<endl;
	pos = hello.find("World");	//Find the starting position of world and set pos equal to that
	cout<<pos<<endl;	//Starting position of the world "World"
	cout<<hello.length()<<endl;
	cout<<hello.size()<<endl;
	system("pause");
	

	return 0;
}