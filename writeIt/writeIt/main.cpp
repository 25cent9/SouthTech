/*
	Innocent Niyibizi
	11/2/15
	Create program to record payroll codes
*/

#include <iostream>
#include <string>
#include <fstream>
#include <vector>
using namespace std;

int main(){
	ofstream outFile;
	outFile.open("codes.txt", ios::out);
	char code = ' ';
	bool valid = false;
	int counter = 1;
	vector<char> usedCodes;
	double salary = 0.0;
	cout<<"Enter a salary code: "<<code;
	cin>>code;
	do{
		if(!isalpha(code)){
			cout<<"Invalid input; Please enter an alpha charcter: ";
			cin>>code;
		}
		if(isalpha(code)){
			valid = true;
		}
	}while(valid!=true);
	usedCodes.push_back(code);
	cout<<"Enter a salary associated with the code: ";
	cin>>salary;
	if(outFile.is_open()==true){
		outFile<<code<<"#"<<salary;
		while(counter!=5){
			cout<<"Enter a salary code: ";
			cin>>code;
			do{
				if(!isalpha(code)){
					cout<<"Invalid input; Please enter an alpha charcter: ";
					cin>>code;
				}
				if(isalpha(code)){
					valid = true;
				}
				for(int i = 0; i<usedCodes.size(); i++){
					if(usedCodes[i]==code){
						cout<<"Code has already been used; Please enter a new one: ";
						cin>>code;
					}
				}
			}while(valid!=true);
			usedCodes.push_back(code);
			counter++;
		}

	}
	system("pause");
	return 0;
}