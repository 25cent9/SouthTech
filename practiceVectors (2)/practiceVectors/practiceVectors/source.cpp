/*
	Innocent Niyibizi
	9/14/15
	Practice vectors by creating a shopping list
*/

#include <iostream>
#include <vector>
#include <string>

using namespace std;
//Function to print contents of vector
void print(vector<string>& list1){
	for(int i=0; i<list1.size(); i++){
		cout<<list1[i]<<" ";
	}
	cout<<endl;
}
int main(){
	vector<string> list;	//Declaring vector called list

	print(list);	
	
	//Appending Eggs, Milk, Sugar, Chocolate, and Flour to vector
	list.push_back("Eggs");
	list.push_back("Milk");
	list.push_back("Sugar");
	list.push_back("Chocolate");
	list.push_back("Flour");

	print(list);	//Printing vector
		
	list.pop_back();	//Deleting last element of vector
	print(list);
	list.push_back("Coffee");	//Adding "Coffee" to the end of the array
	print(list);

	//Loop to search for the word "Sugar" and replace it with the word "Honey"
	for(int i=0; i<list.size(); i++){
		if(list[i]=="Sugar"){
			list[i]="Honey";
		}
	}

	print(list);

	//Loop to search for word "Milk" and remove it from the vector
	for(int i=0; i<list.size(); i++){
		if(list[i]=="Milk"){
			list[i].erase();
		}
	}

	print(list);
	
	system("pause");
	return 0;
}