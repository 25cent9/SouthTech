/*
	Innocent Niyibizi
	9/16/15
	Create a program to ask the user for a number set and use a pointer to find the max value
*/

#include <string>
#include <iostream>
#include <vector>
using namespace std;
bool is_digit(int);
int fun1(int *a);
int *fun2(int *a);
int *fun3(int &);
int main(){
	/*
	int nums = 0;
	int * maxNum;
	vector<int> numbers;
	cout<<"How many numbers would you like to check?: ";
	cin>>nums;
	while(nums<0){
		cout<<"\nError, invalid nmber. Please enter a new number: ";
		cin>>nums;
	}
	cout<<"Please enter your first number: ";
	cin>>numbers.push_back(0);
	for(int i = 1; i<nums; i++){
		cout<<endl<<"Please enter your next number: ";
		cin>>numbers[i];
	}
	cout<<"\nThe highest value that you entered was: ";
	*/
	int value=2;
	cout<<fun1(fun2(fun3(value)));
	system("pause");
	return 0;
}
int fun1(int *a){
	return *a;
}
int *fun2 (int *a){
	return a;
}
int *fun3 (int &a){
	return &a;
}