/*
	Innocent Niyibizi
	8-28-15
	Connect 4
*/
#include<iostream>
#include<string>
#include<vector>
#include<algorithm>
using namespace std;

int main(){
	
	
	int values[6] = {1,2,3,4,5,6};
	int spaces[7][6] = {};
	char input;
	int error = 0;
	do{
		cout<<"Please enter the position in which you would like to place your peice (1-6): ";
		cin>>input;
		if(isalpha(input)){
			error=1;
		}
		else{
			error = 0;
		}
	}while(error!=0);

	system("pause");
	return 0;

	
}

