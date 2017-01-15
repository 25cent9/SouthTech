/*
	Innocent Niyibizi
	11/2/15
	Create a program to show examples of file reading
*/

#include <iostream>
#include <string>
#include <fstream>


using namespace std;

int main(){
	// ifsteam infile;	Creates an input file object
	// ofstream outSales;	Creates an output file object
	// infile.open("sales.txt, ios::in");	This is the default mode for input files. Open the file for input, which allows the computer to read the file's content.


	//outSales.open("sales2.txt", ios::out);	Opens the file for output but if the file does not exist it will create one, If the file does exist it deletes the old and creates a new one with nothing in it.

	//outSales.open("a:\sales3.txt", ios::app);	Opens the file appended which allows the computer to write new data to the end of the existing data in the file. If the file does not exis, it creates it before data is written to it.

	//Check to see if the file was opened properly.	if(outSales.is_open() == true) or if(!outSales.is_open())
	
	//write file out outSales<<"ABC Company"<<endl;

	//reading file	You need to check for eof - end of file
	//While (infile.eof == false)
	//	double salary = 0.0;
	//	infile >> salary;
	//	string name = "";
	//	getline(infile, name);
	//	string fname = "";
	//	getline(infile, name, '#');
	//	infile >> lname;

	//close a file
	//	infile.close();
	//	outSales.close();


	ofstream outFile;
	outFile.open("letters.dat", ios::out);
	char letter = ' ';
	int counter = 1;
	//	Check the open to be successful
	if(outFile.is_open()){
		//Wrrite records to the file
		while(counter <= 26){
			cout<<"Enter a letter: ";
			cin>>letter;
			outFile<<letter<<endl;
			counter++;
		}
		//Close file
		outFile.close();
	}
	else{	//if open fails
		cout<<"Error opening file"<<endl;
	}


	ifstream input;
	input.open("letters.date", ios::in);
	if(input.is_open()){
		input >> letter;	//preread 
		while(input.eof() == false){
			cout<<letter<<endl;
			input >> letter;
		}
		//close file
		input.close();
	}
	else{
		cout<<"Error opening file"<<endl;
	}

	ofstream outFile2;
	outFile2.open("output.txt", ios::app);
	if(outFile2.is_open()){
		outFile2<<"6666666"<<endl;
		cout<<"Enter a letter: ";
		cin>>letter;
		outFile2<<letter<<endl;
		cout<<"Enter a letter: ";
		cin>>letter;
		outFile2<<letter<<endl;
		outFile2.close();
	}
	else{
		cout<<"Error loding file";
	}
	system("pause");
	return 0;
}