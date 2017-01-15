/*
	Innocent Niyibizi
	5-8-15
*/

#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main(){
	/*
	int n[10];
	for (int i=0; i<10; i++){
		cout<<"Enter a number: ";
		cin>>n[i];
	}
	
	for (int x=0; x<10; x++){
		cout<<n[x]<<", ";
	}
	
	cout<<setw(7)<<"SUM"<<setw(14)<<"X"<<endl;
	for (int y=0; y<10; y++){
		//Want to print subscript 1 + subscript 2, 
		cout<<setw(7)<<n[y]+n[y+1]<<setw(14)<<y<<endl;
		y++;
	}
	*/
	//Get two grades and then average them
	cout<<"Enter 2 grades with a space between them: ";
	int g1, g2;
	float avg;
	cin>>g1>>g2;
	avg = (g1+g2)/2;
	cout<<"The average grade is: "<<avg<<endl;

	system("pause");
	return 0;
}