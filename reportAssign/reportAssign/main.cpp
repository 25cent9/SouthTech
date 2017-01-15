/*
	Innocent Niyibizi
	11/4/15
	Create program to simulate inventory using classes and files
*/


#include "item.h"
#include <iostream>
#include <string>
#include <vector>
#include <ctime>
#include <fstream>
#include <sstream>

using namespace std;
void addNewPart(vector<Item>&, string);
void updateInv(vector<Item>, ofstream&);
void menu();
bool valNum(string);
void displayPart(vector<Item>);
void changePart(vector<Item>&);
bool valDate(string);

int main(){


	char date[9];	//Date
	_strdate(date);

	char choice = ' ';

	vector<Item> inventory;
	ifstream masterInput;
	string input = "";
	masterInput.open("INVENTORY.TXT.docx", ios::in);
	if(masterInput.is_open()==true){
		cout<<"Input is open "<<endl;
	}
	else{
		cout<<"Error opening file 'INVENTORY.TXT'"<<endl;
	}

	while(getline( masterInput, input)){	//Loop to run as long as there still is input
		inventory.push_back(Item::findElements(input));
	}

	masterInput.close();
	ofstream masterCopy;
	masterCopy.open("InventoryCopy.txt", ios::out);

	if(masterCopy.is_open()==true){	//Will run as long as the file opened sucessfully 
		cout<<"Copy is open "<<endl;
		while(choice != 'Q' && choice != 'q' ){
			menu();
			cin>>choice;
			while(choice != 'A' && choice != 'a' && choice != 'D' && choice != 'd' && choice != 'C' && choice != 'c' && choice != 'Q' && choice != 'q'){
				cout<<"Invalid input; Please re-enter: ";
				cin>>choice;
			}
			choice = toupper(choice);
			switch(choice){
				case 'A':
					cin.ignore();
					addNewPart(inventory, date);
					break;
				case 'D':
					cin.ignore();
					displayPart(inventory);
					break;
				case 'C':
					changePart(inventory);
					cin.ignore();
					break;
			}
		}
		updateInv(inventory, masterCopy);
	}
	else{
		cout<<"Error opening file "<<endl;
	}
	masterCopy.close();

	
	system("pause");
	return 0;
}

//Function used to output value of vector to the output file
void updateInv(vector<Item> inv, ofstream& copy){
	for(unsigned i=0; i<inv.size(); i++){
		copy<<inv[i].getNum()<<"#"<<inv[i].getName()<<"#"<<inv[i].getQty()<<"#"<<inv[i].getWhlPrice()<<"#"<<inv[i].getRetPrice()<<"#"<<inv[i].getDate()<<endl;
	}

}

//Function used to display menu
void menu(){
	cout<<"*****************************************"<<endl;
	cout<<"* A - Add to inventory\t\t\t*"<<endl;
	cout<<"* D - Display record from inventory\t*"<<endl;
	cout<<"* C - Change record from inventory\t*"<<endl;
	cout<<"* Q - Quit\t\t\t\t*"<<endl;
	cout<<"*****************************************"<<endl;
	cout<<"Please enter a selection: ";
}

//Function used to add a part to the inventory
void addNewPart(vector<Item>& inv, string date){
	bool valid = true;
	unsigned int vecSize = inv.size()+1;
	ostringstream convert;
	convert << vecSize;
	string size = convert.str();
	string name = ""; 
	string quantity = ""; 
	string whole = ""; 
	string retail = ""; 
	cout<<"Please enter the item description: ";
	getline(cin, name);

	do{
		cout<<"Please enter the quantity: ";
		cin>>quantity;
		valid = valNum(quantity);
	}while(valid == false);

	do{
		cout<<"Please enter the whole sale price: ";
		cin>>whole;
		valid = valNum(whole);
	}while(valid == false);

	do{
		cout<<"Please enter the reatil price: ";
		cin>>retail;
		valid = valNum(retail);
	}while(valid == false);
	Item item(size, name, quantity, whole, retail, date);
	inv.push_back(item);
}

//Function used to display the value of a part
void displayPart(vector<Item>inv){
	int part = 0;
	cout<<"Enter the part number that you would like to display: ";
	cin>>part;
	ostringstream convert;
	convert << part;
	string partNum = convert.str();
	for(int i=0; i<inv.size(); i++){
		if(inv[i].getNum()==partNum){
			cout<<endl<<inv[i].getName()<<" "<<inv[i].getQty()<<" $"<<inv[i].getWhlPrice()<<" $"<<inv[i].getRetPrice()<<" "<<inv[i].getDate()<<endl<<endl;
			i=inv.size();
		}
	}
	
}

//Function used to change values of a specific part
void changePart(vector<Item>& inv){
	string select = " ";
	string input = " ";
	bool valid = true;
	int num = 0;
	cout<<"Please enter the item number that you would like to change: ";
	cin>>num;
	num--;
	cout<<"*************************"<<endl;
	cout<<"* ID - Item Description *"<<endl;
	cout<<"* Q - Quantity\t\t*"<<endl;
	cout<<"* W - Wholesale cost\t*"<<endl;
	cout<<"* R - Retail Cost\t*"<<endl;
	cout<<"* D - Date\t\t*"<<endl;
	cout<<"*************************"<<endl;
	cout<<"Please enter the item you would like to change: ";
	cin>>select;

	while(select != "ID" && select != "id" && select != "Q" && select != "q" && select != "w" && select != "W" && select != "R" && select !="r" && select != "d" && select != "D"){
		cout<<"Invalid input; Please re-enter: ";
		cin>>select;
		
	}
	if(select=="id" || select=="ID" || select=="Id" || select=="iD"){
		cout<<"Please input the name that you would like: ";
		cin.ignore();
		getline(cin, input);
		inv[num].setName(input);
	}
	else if(select=="Q" || select=="q"){
		do{
			cout<<"Please input the quantity that you would like: ";
			cin>>input;
			valid = valNum(input);
		}while(valid == false);
		inv[num].setQty(input);
	}
	else if(select=="W" ||  select=="w"){
		do{
			cout<<"Please input the wholesale price that you would like: ";
			cin>>input;
			valid = valNum(input);
		}while(valid==false);
		inv[num].setWhlPrice(input);
	}
	else if(select=="R" || select=="r"){
		do{
			cout<<"Please input the retail price that you would like: ";
			cin>>input;
			valid = valNum(input);
		}while(valid==false);
		inv[num].setRetPrice(input);
	}
	else{
		bool valid = true;
		
		do{
			cout<<"Please input the date that you would like [MM/DD/YY]: ";
			cin>>input;
			valid = valDate(input);
		}while(valid==false);

		inv[num].setDate(input);
	
	}
	
}

//Function to validate the date input
bool valDate(string date){

	if(date.length()>8){
		cout<<"Length is too long; Please re-enter"<<endl;
		return false;
	}
	else if(date.length()<8){
		cout<<"Length is too short; Please re-enter"<<endl;
			return false;
	}

	if(date[2]!='/' || date[5]!='/' ){
		cout<<"Please use the proper formating 'MM/DD/YY' "<<endl;
		return false;
	}

	if(date[0]!='0' && date[0]!='1'){
		cout<<"That is an invalid month; Please re-enter"<<endl;
		return false;
	}
	else if(date[3]!='0' && date[3]!='1' && date[3]!='2' && date[3] !='3'){
		cout<<"Invalid day; Please re-enter"<<endl;
		return false;
	}
	else if(date[6]!='1' || date[7]!='5'){
		cout<<"Invalid year; Please re-enter"<<endl;
		return false;
	}
	else{
		return true;
	}
}
//Function to determine whether or not the user inputed a value greater than 0
bool valNum(string input){
	std::string::size_type sz;
	int num = stod(input, &sz);
	if(num<=0.00){
		cout<<"Invalid input; Please re-enter"<<endl;
		return false;
	}
	else{
		return true;
	}
}