/*
	Innocent Niyibizi
	9-8-15
	Have user input transactions and display them
*/

#include <iostream>
#include <string>
#include <ctime>
#include <iomanip>
using namespace std;
void displayMenu();

struct TM{
  int tm_sec;   // seconds of minutes from 0 to 61
  int tm_min;   // minutes of hour from 0 to 59
  int tm_hour;  // hours of day from 0 to 24
  int tm_mday;  // day of month from 1 to 31
  int tm_mon;   // month of year from 0 to 11
  int tm_year;  // year since 1900
  int tm_wday;  // days since sunday
  int tm_yday;  // days since January 1st
  int tm_isdst; // hours of daylight savings time
};

struct BANK{
	std::string number;
	float bal;
	char type;
	float amnt;
};

int main(){
	time_t now = time(0);
	char* dt = ctime(&now);
	BANK bank[50];
	int j = 0;
	//Loop to set value of all balances in structure to 0
	for(int j= 0; j<=50; j++){
		bank[j].bal=0;
	}
	//cout << "The local date and time is: " << dt << endl;
	do{
		cout<<"Please enter your account number, 15 characters in length: ";
		cin>>bank[0].number;
	}while(bank[0].number.length() < 15 || bank[0].number.length() > 15);

	cout<<"Please enter your first amount: ";
	cin>>bank[0].amnt;
	bank[0].type='D';
	bank[0].bal += bank[0].amnt;

	//Loop to ask user for deposits and withdrawals up to 50 times
	for(int i=1; i<=50; i++){
		
		displayMenu();
		cout<<"Please enter your next transaction type: ";
		cin>>bank[i].type;
		bank[i].type= toupper(bank[i].type);
		//Validating type input
		while(bank[i].type != 'D' && bank[i].type != 'W' && bank[i].type != 'Q'){
			cout<<"Error please enter a valid transaction type: ";
			cin>>bank[i].type;
			bank[i].type= toupper(bank[i].type);
		}
		//Breaking loop when Q is entered 
		if(bank[i].type=='Q'){
			break;
		}

		//Switch to add or subtract from balance based on input
		switch(bank[i].type){
			case 'D':
				cout<<"Please enter the amount of money you will be depositiing: ";
				cin>>bank[i].amnt;
				while(bank[i].amnt <= 0){
					cout<<"Invalid input, please enter a correct amount: ";
					cin>>bank[i].amnt;
				}
				bank[i].bal = bank[i-1].bal+bank[i].amnt;
				break;
			case 'W':
				cout<<"Please enter the amount of money you will be Withdrawing: ";
				cin>>bank[i].amnt;
				while(bank[i].amnt <= 0){
					cout<<"Invalid input, please enter a correct amount: ";
					cin>>bank[i].amnt;
				}
				bank[i].bal = bank[i-1].bal-bank[i].amnt;
				break;
		}
		j=i;
	}
	
	//Dsiplaying the account number and date
	cout<<endl<<bank[0].number<<endl<<"Date & time: "<< dt <<endl<<endl;
	cout<<"D"<<setw(20)<<"W"<<setw(20)<<" Amount"<<setw(25)<<" Balance"<<endl;
	//Loop to check array for deposits and withdrawls and place the X accordingly 
	for(int i = 0; i<=j; i++){
		char place = ' ';
		char place1 = ' ';
		if(bank[i].type=='D'){
			place = 'X';
		}
		else{
			place1 = 'X';
		}
		cout<<place<<setw(20)<<place1<<setw(20)<<fixed<<setprecision(2)<<bank[i].amnt<<setw(25)<<fixed<<setprecision(2)<<bank[i].bal<<endl;
	}
	cout<<endl;
	system("pause");
	return 0;
}

//Function to display menu
void displayMenu(){
	cout<<endl<<"*************************************"<<endl;
	cout<<"* D - Deposit                       *"<<endl;
	cout<<"* W - Withdrawal                    *"<<endl;
	cout<<"* Q - Complete transaction period   *"<<endl;
	cout<<"*************************************"<<endl<<endl;
}