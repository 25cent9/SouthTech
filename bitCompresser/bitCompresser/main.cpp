/*
	Innocent Niyibizi
	11/11/15
	Create program to read input and compress bits based on the input
*/

#include <iostream>
#include <fstream>
#include <string>
#include <bitset>
#include <vector>

using namespace std;
void findUnique(int, string);

int main(){
	int num = 0;
	string bit = "";
	ifstream input;
	input.open("bit.txt", ios::in);

	if(input.is_open()){
		while(input.eof()==false){
			input>>num;
			input>>bit;
			findUnique(num, bit);
		}
	}
	else{
		cout<<"Error opening file, 'bit.txt'"<<endl;
	}
	input.close();
	system("pause");
	return 0;
}

void findUnique(int length, string number){
	int subNum = 0;
	vector<string> groups;
	for(int i = 0; i<groups.size(); i++){
		cout<<groups[i]<<" ";
	}
	if(number.length()%4==true){
		subNum=4;
	}
	else if(number.length()%3==true){
		subNum=3;
	}
	else if(number.length()%2==true){
		subNum=2;
	}
	for(int i = 0; i<number.length(); i++){
		groups.push_back(i);	
	}
	
}