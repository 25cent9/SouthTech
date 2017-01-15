/*
	Innocent Niyibizi (The Brogrammer)
	10/21/15
	Vectors of objects
*/

#include <iostream>
#include "student.h"
#include <string>
#include <iomanip>
using namespace std;

void fillVector(vector<Student>&);
	//Method to fill vector with students

int main(){
	vector<Student> myClass;
	fillVector(myClass);
	int size = myClass.size();
	for(unsigned i=0; i < size; i++){
		cout<<"**************************************"<<endl;
		cout<<"*Name: "<<myClass[i].getName()<<setw(23)<<"*"<<endl;
		cout<<"*Grade: "<<myClass[i].getGrade()<<setw(28)<<"*"<<endl;
		cout<<"**************************************"<<endl;
	}
	system("pause");
	return 0;
}
void fillVector(vector<Student>& list){
	string name;
	string grade;
	cout<<"How many students are in your class: ";
	int number = 0;
	cin>>number;

	for(unsigned i = 0; i<number; i++){
		cout<<endl<<"Student Name: ";
		cin>>name;
		cout<<"Student Grade: ";
		cin>>grade;
		Student newStudent(name, grade);
		list.push_back(newStudent);
		cout<<endl;
	}
	
}