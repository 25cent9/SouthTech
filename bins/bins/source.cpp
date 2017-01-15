/*
Innocent Niyibizi
9/11/15
Create a program to simulate inventory bins in a warehouse
*/

#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

//Creating structure named BINS 
struct BINS{
	string descrip;
	int num;
};
int main(){
	
	BINS bins[10];
	bins[0].descrip = "Valve";
	bins[1].descrip = "Bearing";
	bins[2].descrip = "Bushing";
	bins[3].descrip = "Coupling";
	bins[4].descrip = "Flange";
	bins[5].descrip = "Gear";
	bins[6].descrip = "Gear Housing";
	bins[7].descrip = "Vacuum Gripper";
	bins[8].descrip = "Cable";
	bins[9].descrip = "Rod";

	int value = 0;
	char choice = ' ';
	int selection = 0;
	//Setting values of bins to 0
	for (int i = 0; i<10; i++){
		bins[i].num = 0;
	}
	do{
		//Displaying the menu and inventory
		cout<<"Part Description"<<setw(50)<<"Number of parts in the Bin"<<endl;
		for (int i = 0; i<10; i++){
			if(bins[i].descrip.length()>=8){
				cout<<bins[i].descrip<<"\t\t\t\t"<<bins[i].num<<endl;
			}
			else{
				cout<<bins[i].descrip<<"\t\t\t\t\t"<<bins[i].num<<endl;
			}
		
		}	
		cout<<endl<<"Would you like to add subtract or quit? (Q, S, A): ";
		cin>>choice;
		choice=toupper(choice);

		//Switch statement to evaluate the choice selected by the user
		switch(choice){
			case 'A':	//Case A will validate input and then add to the indicated bin
				cout<<"Please select a bin (1-10): ";
				cin>>selection;
				while(selection > 10 || selection < 0){
					cout<<"Error, please enter a new selection: ";
					cin>>selection;
				}
				cout<<"Please enter the amount you would like to add to this bin: ";
				cin>>value;
				while(value >= 31){
					cout<<"Error, please enter a new amount: ";
					cin>>value;
				}
				while((bins[selection-1].num+value)>30){
					cout<<"This bin has exceded the maximum capacity, please enter a new value: ";
					cin>>value;
				}
				bins[selection-1].num+=value;
				break;
			case 'S':	//Case S will validate input and then subtract from the indicated bin
				cout<<"Please select a bin (1-10): ";
				cin>>selection;
				while(selection > 10 || selection < 0){
					cout<<"Error, please enter a new selection: ";
					cin>>selection;
				}
				cout<<"Please enter the amount you would like to subtract from this bin: ";
				cin>>value;
				while(value < 0 || value > bins[selection-1].num){
					cout<<"Error, please enter a new amount: ";
					cin>>value;
				}
				while((bins[selection-1].num-value)<0){
					cout<<"There is not that much to take from the bin, please enter a new value: ";
					cin>>value;
				}
				bins[selection-1].num-=value;
				break;
		}
	}while(choice != 'Q');	//Breaks out of loop one 
	//system("pause");
	return 0;
}
