/*
Innocent Niyibizi
9/16/15
Create a program to ask the user for a number set and use a pointer to find the max value
*/

#include <string>
#include <iostream>
#include <vector>
using namespace std;
int findMaxNum(int *, vector<int> &);
int main(){
	int nums = 0;
	int * maxNum;
	int number = 0;
	vector<int> numbers;
	cout << "How many numbers would you like to check?: ";
	cin >> nums;
	//Asks user to input new number until their input is valid
	while (nums<0){
		cout << "\nError, invalid nmber. Please enter a new number: ";
		cin >> nums;
	}
	cout << "\nPlease enter your first number: ";
	cin >> number;
	while (number<0){
		cout << "\nError, invalid nmber. Please enter a new number: ";
		cin >> number;
	}
	numbers.push_back(number);
	//Loop to ask user for a new number based on the amount of numbers that they want to check
	for (int i = 1; i<nums; i++){
		cout << endl << "Please enter your next number: ";
		while (number<0){
			cout << "\nError, invalid nmber. Please enter a new number: ";
			cin >> number;
		}
		cin >> number;
		numbers.push_back(number);
	}
	//Setting the pointer to be equal to the first number in the vector 1
	maxNum = &numbers[0];
	
	//Setting the result of the search for 
	*maxNum = findMaxNum(maxNum, numbers);

	//Printing the max value from the user input 
	cout << "\nThe highest value that you entered was: " << *maxNum << endl;
	
	system("pause");
	
	return 0;
}
//Function to find the highest number entered
int findMaxNum(int *max, vector<int> &vecNum){
	for (int i = 1; i < vecNum.size(); i++){
		if (*max < vecNum[i]){
			max = &vecNum[i];
		}
	}
	return *max;
}

