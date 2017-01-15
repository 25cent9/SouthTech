#include <iostream>
#include <string>
#include <vector>

using namespace std;

#ifndef STUDENT_H
#define STUDENT_H



class Student{

public:

	Student();
	Student(string, string);
	~Student();
	string getName() const;
		//@getName
		//@return string - name of student
	string getGrade() const;
		//@getGrade
		//@return string - grade of student
	void setName(string);
		//@gsetName
		//@Storing name
	void setGrade(string);
		//@gsetGrade
		//@Storing grade

private:
	string newName;
	string newGrade;
};



#endif