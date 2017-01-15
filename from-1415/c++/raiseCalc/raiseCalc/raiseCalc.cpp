/*
	Programmer: Innocent Niyibizi
	Date: 4-27-15
	Purpose: Find the raise given a raise rate and current salary
*/

#include <iostream>
#include <iomanip>
using namespace std;


void getNewPayInfo(float &salary, float &raise){	//Actual parameters
	cout<<"What is your current salary? : $";
	cin>>salary;
	cout<<"What is the raise rate, in decimal form: ";
	cin>>raise;

	salary=(salary*raise)+salary;
}
int main(){
	float currentSalary = 0;
	float raiseRate = 0;
	getNewPayInfo(currentSalary, raiseRate);	//Formal paramerters 
	cout<<fixed<<std::setprecision(2);
	cout<<"Your raise rate was :"<<raiseRate*100<<"%"<<endl;
	cout<<"Your new salary is $"<<currentSalary<<endl;
	system("pause");
	return 0;
}