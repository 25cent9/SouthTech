#include <iostream>
#include "iso.h"

using namespace std;

int main(){

	int base, height, equalSide;

	cout<<"Please type in a base length: ";
	cin>>base;
	cout<<"Please type in the height: ";
	cin>>height;
	cout<<"Please type in the side that is equal: ";
	cin>>equalSide;
	
	Iso myTriangle(base, equalSide, height);
	cout<<endl;
	myTriangle.perimInfo();
	system("pause");
	return 0;
}