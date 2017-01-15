/*
	Programmer: Innocent Niyibizi
	Date: 4-21-15
	Purpose: To calculate the price of a user's concert ticket based on their location
*/
#include <iostream>
using namespace std;
int main(){
	int x = 0;
	char input = ' ';
	cout<<"Please enter your seat location. 'B' for box, 'P' for pavilion, and 'L' for lawn: ";
	cin>>input;
	input = tolower(input);
	if(input!='p' && input!='b' && input!='l'){
		while(x==0){
			cout<<"Invalid location. Please enter a new seat location. 'B' for box, 'P' for pavilion, and 'L' for lawn: ";
			cin>>input;
			input = tolower(input);
			if(input=='p'||input=='b'||input=='l'){
				x=1;
			}
		}
	}
	switch(input){
		case 'p':
			cout<<"Your concert ticket will be $30"<<endl;
			break;
		case 'b':
			cout<<"Your concert ticket will be $75"<<endl;
			break;
		case 'l':
			cout<<"Your concert ticket will be $21"<<endl;
			break;
	
	}
	system("pause");
	return 0;
}