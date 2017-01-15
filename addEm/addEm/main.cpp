/*
	Innocent Niyibizi
	11/2/15
	Read input and add all them up
*/

#include <iostream>
#include <fstream>

using namespace std;

int main(){
	ifstream textFile;
	textFile.open("input.txt", ios::in);
	int sum = 0;
	if(textFile.is_open()==true){
		int num = 0;
		textFile >> num;
		sum+=num;
		while(textFile.eof()==false){
			textFile >> num;
			sum+=num;
		}
		textFile.close();
	}
	else{
		cout<<"Error opening file";
	}
	cout<<"The total is: "<<sum<<endl;



	//system("pause");
	return 0;
}
