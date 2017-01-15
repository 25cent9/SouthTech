/*
	Programmer: Innocent Niyibizi
	Date: 5-1-15
	Purpose: To practice string to char and arrays
*/

#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

void main(){
	/*
	string str = "";
	int length ;
	cout<<"Enter a string: ";
	getline(cin, str);
	length=str.length();

	char chars[25];
	str.copy(chars, length);	//Copy is a method that works with strings
	cout<<chars[5]<<endl;
	*********/
	/********
	//toupper & tolower - converts characters to uppercase or lowercase

	char letter = 'r';
	letter = toupper(letter);
	cout<<letter<<endl;
	letter = tolower(letter);
	cout<<letter<<endl;

	//toupper and tolower on strings
	string strMsg = "Today";
	//transform(string.begin, string.end, string.placement, toupper)
	transform(strMsg.end()-1, strMsg.end(), strMsg.end()-1, toupper);
	cout<<strMsg<<endl;

	transform(strMsg.end()-1, strMsg.end(), strMsg.begin()+2, toupper);
	cout<<strMsg<<endl;

	transform(strMsg.begin(), strMsg.end(), strMsg.begin(), toupper);
	cout<<strMsg<<endl;
	*/

	//Asign string method
	string strAssign = "Friday";
	string strAfter;
	
	//cout<<"Before: "<<strAssign<<endl;
	strAfter.assign(strAssign, 1,2);
	
	cout<<"After: "<<strAfter<<endl;
	strAssign.assign("Programming is kool", 0,30);
	cout<<strAssign<<endl;
	strAssign.assign(10,'*');
	cout<<strAssign<<endl;
	system("pause");
}