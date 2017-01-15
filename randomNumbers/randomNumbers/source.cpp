/*
	Innocent Niyibizi
	9/24/15
	Create program to create an array of pointers based on the user inputed dimensions, then fill each cell with a radnom number
*/

#include <iostream>
#include <iomanip>
#include <string>
#include <time.h>
#include <stdlib.h> 

using namespace std;
void validate(int, string, bool &);

int main(){
	int **arr;
	int rows = 0; 
	int columns = 0;
	int x = 0;
	bool valid = false;
	srand (time(NULL));
	int random = 0;

	do{//Loop to collect input for rows
		cout<<"Please enter the amount of rows you would like: ";
		cin>>rows;
		validate(rows, "Input is invalid", valid);
	}while(valid==false);

	arr = new int *[rows];

	do{	//Loop to collect input for columns
		cout<<"Please enter the amount of columns you would like: ";
		cin>>columns;
		validate(rows, "Input is invalid", valid);
	}while(valid==false);

	for(int i = 0; i<rows; i++){	//Loop to create columns based on user input
		arr [i] = new int [columns]; 
	}

	for(int z = 0; z<rows; z++){	//Array to give each cell a random value
		for(int j = 0; j<columns; j++){
			random=rand() % 100+rows + 1;;
			arr[z][j]=random;
		}
	}
	
	for(int z = 0; z<rows; z++){	//Loop to print array
		for(int j = 0; j<columns; j++){
			cout<<arr[z][j];
			cout<<"\t";
		}
		cout<<endl;
	}

	delete [] arr;	//Deleting array from memory
	system("pause");
	return 0;
}

//Function to validate input
void validate(int x, string msg, bool  &v){
	if(x%1==0){
		v=true;
	}
	else{
		v=false;
		cout<<msg<<endl;
	}

}
