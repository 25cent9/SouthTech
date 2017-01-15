/*
	Innocent Niyibizi
	10/7/15
	String manipulations 
*/

#include <iostream>
#include <string>

using namespace std;
namespace {
	int Troll = 3;
	float wizard = 0.3;
}
namespace NewWiz{
	int Troll = 1;
	float wizard = 0.5;
}
namespace Mordor{
	int Troll = 2;
	float wizard = 0.5;
}

namespace hogwarts = NewWiz;
//using namespace hogwarts;
//using namespace Mordor;
void printInfo(string &s){
	cout<<"length= "<<s.length()<<endl;
	cout<<"Capacity= "<<s.capacity()<<endl;
	cout<<"Max Size= "<<s.max_size()<<endl;

}
namespace s{
	int A = 1; 
}
namespace s{
	int B = A+2;
}
int main(){
	s::A=s::A+1;
	{using namespace s;
		B++;
	}
	cout<<s::B<<s::A;
	//cout<<Troll<<Mordor::Troll<<endl;
	/*
	{
		using namespace hogwarts;
		cout<<Troll<<" "<<endl;
	}
	{
		using namespace Mordor;
		cout<<Troll<<" "<<endl;
	}
	cout<<hogwarts::Troll<<endl;
	
	cout<<hogwarts::Troll<<" "<<hogwarts::wizard<<" "<<endl;
	*/
	/*
	using Mordor::Troll;
	using hogwarts::wizard;
	
	cout<<hogwarts::Troll<<" "<<wizard<<endl;
	hogwarts::Troll = 14;
	cout<<Troll<<" "<<Mordor::wizard<<endl;
	cout<<Troll<<wizard<<endl;
	cout<<hogwarts::Troll<<" "<<wizard<<endl;
	*/
	/*
	string TheGood = "Jekyll", TheBad = "Hyde";
	cout<<TheGood+" & "+TheBad<<endl;
	cout<<TheBad+" & "+TheGood<<endl;
	*/
	/*
	a is greater than A
	z is greater than a
	a is greater than 1
	1 is less than a or A 
	a is less than z
	z is greater than Z 
	Z is greater than " "
	. is less than z 
	string String;
	string a = "a";
	string b = "b";
	String = a + b;
	String = String + "c";
	String = "b"+String;
	String += " or not to be"; //Short cutting
	cout<<String<<endl;
	*/
	//Inputting strings
	/*
	string lineOfTypes; 
	getline(cin, lineOfTypes);
	cout<<lineOfTypes<<endl;
	*/
	/*
	 string secret = "1";
	 string password;
	 cout<<"Please enter your password: ";
	 getline(cin, password);
	 if(secret == password){
		cout<<"Access granted"<<endl;
	 }
	 else{
		cout<<"Sorry"<<endl;
	 }
	 */
	/*
	string str1, str2;
	cout<<"Enter 2 lines of text: ";
	getline(cin, str1);
	getline(cin,  str2);
	if(str1==str2){
		cout<<"\""<<str1<<"\"==\""<<str2<<"\""<<endl;	
	}
	else if(str1>str2){
		cout<<"\""<<str2<<"\"<\""<<str1<<"\""<<endl;
	}
	else{
		cout<<"\""<<str2<<"\">\""<<str1<<"\""<<endl;
	}
	*/

	/*Compare Function*/
	/*
	string secret = "dog";
	string passwrd;
	cout<<"Enter password: ";
	getline(cin, passwrd);
	if(secret.compare(passwrd)==0){
		cout<<"They are equal "<<secret.compare(passwrd)<<endl;
	}
	else{
		if(secret.compare(passwrd)==1){
			cout<<secret<<" is greater than "<< passwrd<<secret.compare(passwrd)<<endl;
		}
		else{
			cout<<secret<<" is less than "<< passwrd<<secret.compare(passwrd)<<endl;
		}
	}
	*/
	/*
		substring newstr = oldstr.substring(substr_start_pos, length_of_string)
		s.substr(1,2)	Starts at  2nd char and ends at the third char - inclusively
		s.substr(1)	Starts at second character containing all remaining characters
		s.substr()	Just a copy of the whole string s
	*/
	/*
	//You musn't define a substring which dosen't wholly fit inside the original string (starts besides theoriginal string's end) this will cause an exception
	string str1, str2;
	str1 = "ABCDEF";
	str2 = str1.substr(1,1) + str1.substr(4)+str1.substr();
	//length	size
	string st = "12345";
	int pos = 1;
	cout<<st.substr(pos)<<endl;
	cout<<st.substr(pos).substr(pos)<<endl;
	cout<<st.substr
		(pos).substr(pos).substr(pos)<<endl;

	cout<<st.substr
		(pos).substr(pos).substr(pos).size()<<endl;
	cout<<str2<<endl;
	*/
	/*Comparing to part of stings
		s.compare(substr_start, substr_length, other_string)
		s.compare(substr_start, substr_length, other_string, other_substr_start, other_substr_length)
	
	string A = "ABC";
	cout<<A.compare(1,1,"B")<<endl;	//returns 0
	cout<<A.compare(1,1,"ABC", 1,1)<<endl;	//returns 0
	string x = "ABC";
	cout<<x.compare(1,1, "BC")<<endl;
	cout<<x.substr(2,2);
	cout<<x.compare(2,1,x,2,2)<<endl;
	cout<<x.compare(1,1, "BC")+x.compare(2,1,x,2,2)<<endl;

	//find - find a substring within other string
	//int where_it_begins = S.find(another_string, start_here);
	//int where_it_is = s.find(any_char, starts__here)
	//start_here defaults to 0 if left off.
	//returns is the first psoition withihn the string where the searched string beigins or where the search character is located

	string greet = "My name is Chad.";
	string we_need_him = "Chad";
	if(greet.find(we_need_him) != string::npos){
		cout<<"OMG Chad is a tool!"<<endl;
	}
	else{
		cout<<"It's not Chad."<<endl;
	}
	int comma = greet.find('#');
	cout<<greet.find('#');
	if(comma != string::npos){
		cout<<"Curious. He used a comma. "<<endl;
	}
		

	//Capacity	and	max_size
	//Capacity - size of the currently allocated buffers. Expressed in terms of bytes
	//max_size - every string can grow, but there is no limit. This is the max size that can be allocated
	string x = "Chad and Brody wuz here.";
	int cur_used = x.capacity();
	cout<<cur_used<<endl;
	unsigned int not_more_than = x.max_size();
	cout<<not_more_than<<endl;
	

	string cont = "content";
	printInfo(cont);
	cont = "con";
	cont.reserve(0);
	printInfo(cont);
	cont.reserve(1000);
	printInfo(cont);
	
	for(int i = 0; i<21; i++){
		cont += cont;
	}
	
	printInfo(cont);
	
	
	string theString  = "Acontent";
	cout<<theString<<endl;
	//unsigned int x;
	for(int i = 0; i<theString.length(); i++){
		theString[i]= theString[i]-'a'+'A';
		cout<<theString[i]-'a'<<endl;
		cout<<theString[i]<<endl;
	}
	cout<<theString<<endl;
	

	//	Append fucntion is much more flexible
	//	Changes the str1 value by adding the str2 at the end
	//	+= concatonate is similar 

	string str1 = "Chad";
	string str2 = " Brody";
	str1.append(str2);
	cout<<str1<<endl;
	//Chad Brody
	str1.append(3,'6');
	cout<<str1<<endl;
	//Chad Brody666
	str2.append(str1, 1, 3);
	cout<<str2<<endl;
	// Brodyad

	string f; 
	for(char c= 'A'; c<='Z'; c++){
		f.push_back(c);
	}
	cout<<f<<endl;
	
	//swap
	
	string drink = "A martini";
	string needs = "Shaken, not stirred";

	cout<<drink<<". "<<needs<<"."<<endl;
	drink.swap(needs);
	cout<<drink<<". "<<needs<<"."<<endl;
	*/
	//cout<<Troll<<Mordor::Troll;
/*
	string sky;
	string sky1;
	sky.assign(80,'*');
	sky1.append(80,'*');
	cout<<sky<<endl;
	cout<<sky1<<endl;
	*/
	system("pause");
	return 0;
}
