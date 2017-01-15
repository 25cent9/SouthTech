/*
	Programmer: Innocent Niyibizi
	Date: 4-22-15
	Purpose: To build a pyramid of astrics based on user inputed number
*/

#include <iostream>
using namespace std;
void printPyramid(int h){
	//	Function to print pyramid using nested for loops
	int line;	//Local variable that is gone once you leave the function
	int const MARGIN = 10;	//Constant variable that cannot be changed
	cout<<endl<<endl;

	//	Outer Loop
	for(line=1; line<=h; line++){
		int count;	//Local variable and is only avaliable within this loop - once the outer loop is done, count no longer is avaliable
		int tot_no_spaces = MARGIN+h-line;
		//	Inner loop - prints the spaces
		for(count = 1; count<=tot_no_spaces; count++){
			cout<<" ";
		}
		//	Inner loop 2 - prints the pyramid
		for(count=1; count<line*2; count++){
			cout<<'*';
		}
		cout<<endl;
	}
}
int main(){
	int p_height = 0;
	cout<<"This program prints a pyramid shape of specified height on the screen."<<endl;
	cout<<"Please enter the desired height of your pyramid: ";
	cin>>p_height;

	//	While only needs to be executed when input is not in boundaries of 1-30
	while(p_height > 30 || p_height < 1){
		cout<<"The value that you entered is invalid. Please enter a new value between 1 and 30: ";
		cin>>p_height;
	}
	printPyramid(p_height);
	system("pause");
	return 0;
}