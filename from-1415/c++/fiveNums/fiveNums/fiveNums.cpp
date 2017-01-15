/*
	Programmer: Innocent Niyibizi
	Date: 4-22-1
	Purpose: To find the average, lowest number, and highest number of 5 user inputed numbers
*/
#include <iostream>
using namespace std;
//Function used to find the average of the five inputed numbers
float aver(float n1, float n2, float n3, float n4, float n5){
	return (n1+n2+n3+n4+n5)/5;
}	

//Function used to find the lowest of five inputed numbers
float low(float n1, float n2, float n3, float n4, float n5){
	float lowest;
	if(n1<n2){
		lowest=n1;
	}
	else{
		lowest=n2;
	}
	if(lowest<n3){
		lowest=lowest;
	}
	else{
		lowest=n3;
	}
	if(lowest<n4){
		lowest=lowest;
	}
	else{
		lowest=n4;
	}
	if(lowest<n5){
		lowest=lowest;
	}
	else{
		lowest=n5;
	}
	return lowest;
}

//Function used to find the highest of five inputed numbers
float high(float n1, float n2, float n3, float n4, float n5){
	float highest;
	if(n1>n2){
		highest=n1;
	}
	else{
		highest=n2;
	}
	if(highest>n3){
		highest=highest;
	}
	else{
		highest=n3;
	}
	if(highest>n4){
		highest=highest;
	}
	else{
		highest=n4;
	}
	if(highest>n5){
		highest=highest;
	}
	else{
		highest=n5;
	}
	return highest;
} 
int main(){
	//Declaring variables
	float num1;
	float num2;
	float num3;
	float num4;
	float num5;

	//Gathering inputs
	cout<<"Please input the first number: ";
	cin>>num1;
	cout<<"Please input the next number: ";
	cin>>num2;
	cout<<"Please input the next number: ";
	cin>>num3;
	cout<<"Please input the next number: ";
	cin>>num4;
	cout<<"Please input the next number: ";
	cin>>num5;

	//Calling functions
	float average = aver(num1, num2, num3, num4, num5);
	float lowNum = low(num1, num2, num3, num4, num5);
	float highNum = high(num1, num2, num3, num4, num5);

	//Displaying average, lowest number, and highest number
	cout<<"Your average is "<<average<<", your lowest number was "<<lowNum<<", and your highest number was "<<highNum<<endl;
	system("pause");
	return 0;
}