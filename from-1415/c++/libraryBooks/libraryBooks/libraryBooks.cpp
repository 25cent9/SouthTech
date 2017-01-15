/*
	Programmer: Innocent Niyibizi
	Date: 4-7-15
	Purpose: To create a program that calculates the price due for someone who has an over due library book
*/

#include <iostream>

using namespace std;
int main() {
	//Declaring variables
	int days = 0;
	int books = 0;
	double charge = 0.25;
	float totalDue = 0;

	//Gathering input from user
	cout << "How many books were checked out? : ";
	cin >> books;
	cout << "How many days was/were the book(s) checked out? : ";
	cin >> days;
	charge *= books;

	//Loop to calculate total amount due based on amount of books and days late
	for (int i = days-1; i >= 0; i--) {
		totalDue += charge;
	}
	//Displaying total amount due
	cout << "The total amount due is: $" <<totalDue<<" for "<<books<<" book(s) that are "<<days<<" day(s) overdue."<<endl;
	system("pause");
}