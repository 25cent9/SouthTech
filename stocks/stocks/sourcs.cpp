/*
	Innocent Niyibizi
	9/25/15
	Create program to collect stock information and put them into a dynamic array
*/
#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int main(){
	string **arr;
	int rows = 0;
	string symbol = " ";
	string amt = " ";
	cout<<"How many stocks will you be inputing: ";
	cin>>rows;
	arr = new string*[rows];
	//Loop to ask for stock symbol and amount
	for(int i = 0; i<rows; i++){
		arr [i] = new string [2];
		bool error = false;
		cout << "Please enter your stock symbol: ";
		cin >> symbol;
		arr[i][0] = symbol;
		cout << "Please enter your amnount: ";
		cin >> amt;
		arr[i][1] = amt; 
	}

	cout<<endl<<"Stock Symbol \t Stock Amount"<<endl;
	for(int i = 0; i<rows; i++){
		for(int j  = 0; j<2; j++){
			cout<<arr[i][j];
			cout<<"\t\t ";
		}
		cout<<endl;
	}
	cout<<endl;
	system("pause");
	return 0;
}
