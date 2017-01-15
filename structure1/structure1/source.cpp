/*
	Innocent Niyibizi
	9-4-15
	Practice structures 
*/

#include <string>
#include <iostream>
#include <string>
using namespace std;

struct DATE{
	int month;
	int day;
	int year;
};

int main(){
	string month =" ";
	int error = 0;
	DATE date;
	DATE dates[20];
	cout<<"Please enter the month: ";
	do{
		cin>>date.month;
		if(date.month<1 || date.month >12){
			cout<<"Error, please enter a new month: ";
			error = 1;
		}
		else{
			error = 0;
		}
	}while(error == 1);
	cout<<endl<<"Please enter the day: ";
	do{	//Do while loop to determine whether or not 
		cin>>date.day;
		if(date.day<1 || date.day >31){
			cout<<"Error, please enter a new day: ";
			error = 1;
		}
		else{
			error = 0;
		}
	}while(error == 1);
	cout<<endl<<"Please enter the year: ";
	cin>>date.year;
	switch(date.month){	//Switch statement to determine which month was entered
		case 1:
			month = "January";
			break;
		case 2:
			month = "February";
			break;
		case 3:
			month = "March";
			break;
		case 4:
			month = "April";
			break;
		case 5:
			month = "May";
			break;
		case 6:
			month = "June";
			break;
		case 7:
			month = "July";
			break;
		case 8:
			month = "August";
			break;
		case 9:
			month = "September";
			break;
		case 10:
			month = "October";
			break;
		case 11:
			month = "November";
			break;
		case 12:
			month = "December";
			break;
	}
	cout<<"You entered "<<month<<", "<<date.day<<" "<<date.year<<endl;

	cout<<"Please enter more dates."<<endl;
	for(int i=0; i<=20; i++){
		cout<<"Please enter a month: ";
		do{
			cin>>dates[i].month;
			if(dates[i].month==-1){
				break;
			}
			if(dates[i].month<1 || dates[i].month >12){
				cout<<endl<<"Error, please enter a new month: ";
				error = 1;
			}
			else{
				error = 0;
			}
		}while(error == 1);
		if(dates[i].month==-1){
			break;
		}
		cout<<endl<<"Please enter a day: ";
		do{
			cin>>dates[i].day;
			if(dates[i].day<1 || dates[i].day >31){
				cout<<endl<<"Error, please enter a new day: ";
				error = 1;
			}
			else{
				error = 0;
			}
		}while(error == 1);
		cout<<"Please enter a year: ";
		cin>>dates[i].year;
	}
	system("pause");
	return 0;
}