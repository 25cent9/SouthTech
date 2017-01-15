/*
	Innocent Niyibizi
	11/6/15
	Create program to simulate inventory using classes and files
*/

#include <iostream>
#include <string>
#include <fstream>
#include <iomanip>
#include "../../reportAssign/reportAssign/item.h"

using namespace std;

int main(){
	vector<Item> inventory;
	int reportNum = 1;
	int pageNum = 1;
	ifstream read;
	string input = "";
	read.open("../reportAssign/inventoryCopy.txt", ios::in);
	if(read.is_open()==true){	
		cout<<"File opening successful"<<endl;
		while(getline( read, input)){	//Loop to run as long as there still is input
			inventory.push_back(Item::findElements(input));
		}
		read.close();
	}
	else{
		cout<<"Error opening file"<<endl;
	}

	/*
	ofstream outFile;
		outFile.open("report.txt", ios::out);
		outFile<<reportNum<<" Inventory Report, Page "<<pageNum<<endl;
		outFile<<"Item"<<setw(10)<<" Qty "<<setw(10)<<"Wholesale"<<setw(10)<<"Retail"<<endl;
		outFile<<"------------------------------------------------------------"<<endl;
		/*
		for(int i=0; i < inventory.size(); i++){
			
		}
		
	//outFile.close();
	*/

	system("pause");
	return 0;
}
