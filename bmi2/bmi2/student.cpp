#include "student.h"


Student::Student(){
	newName = " ";
	newGrade = " ";
}
Student::Student(string name, string grade){
	newName = name;
	newGrade = grade;

}
Student::~Student(){

}
string Student::getGrade() const{
	return newGrade;
}
string Student::getName() const{
	return newName;
}
void Student::setName(string name){
	newName = name;
}
void Student::setGrade(string grade){
	newGrade = grade;
}