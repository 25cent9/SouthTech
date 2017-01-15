/*
	Innocent Niyibizi
	10/22/15
	Use vectors and objects
*/

#include <iostream>

#include <string>
#include <vector>

using namespace std;
//Declare the type of item stored in the bag object
//A typedef must precede #include "bag"
typedef string BAG_ELEMENT_TYPE;
#include "bag.h"

int main(){

	bag bagOfStrings(10);
	cout<<"Empty?: "<<bagOfStrings.isEmpty()<<endl;
	bagOfStrings.add("A string");
	bagOfStrings.add("A rope");
	bagOfStrings.add("A ladder");
	bagOfStrings.add("A hook");

	//Remove an item 
	//bagOfStrings.remove("A ladder");
	
	//Send a remove message that  dosen't find the argument
	if(bagOfStrings.remove("A rope")){
		cout<<"Remove successful"<<endl;
	}
	else{
		cout<<"String not found, bagOfStrings not changed"<<endl;
	}
	cout<<"Empty? "<<bagOfStrings.isEmpty()<<endl;
	cout<<"Capacity is "<<bagOfStrings.capacity()<<endl;
	cout<<"Current size is "<<bagOfStrings.size()<<endl;
	system("pause");
	return 0;
}