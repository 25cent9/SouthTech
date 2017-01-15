/*
	Innocent Niyibizi
	10/5/15
	Crate program that validates password based on these cirteria:
		The password should be at least 8 characters long
		The password should contain at least one uppercase and at least one lowercase letter 
		The password should have at least one special character
		The password should have 1 combination of 2 numbers and a letter
		The password should start with a letter.
*/
#include <iostream>
#include <string>

using namespace std;
bool validate(string);

int main(){
	string password = " "; 
	bool valid = true;
	do{
		cout<<"Please enter your password: ";
		cin>>password;
		valid = validate(password);
	}while(valid == false);

	system("pause");
	return 0;
}

bool validate(string pass){
	bool hasUpper = false;
	bool hasLower = false;
	bool alphaNum = false;
	bool special = false;
	//Checking for letters
	if(!isalpha(pass[0])){
		cout<<"Your password must start with a letter!"<<endl;
		return false;
	}
	//Checking that length is at least 8 characters 
	if(pass.length()<8){
		cout<<"Yoour password must be at least 8 characters in length!"<<endl;
		return false;
	}

	//Checking for lower and upper case letter
	for(int i = 0; i<pass.length(); i++){
		if(toupper(pass[i])==pass[i] && isalpha(pass[i])){
			hasUpper=true;
		}
		else if(tolower(pass[i])==pass[i] && isalpha(pass[i])){
			hasLower=true;
		}
	}

	if(hasLower == false && hasUpper==false || hasLower == false && hasUpper==true || hasLower == true && hasUpper==false){
			cout<<"Your password must have at least one lowercase and uppercase letter!"<<endl;
			return false;
		}
	
	//Checking for two number and one letter combination 
	for(int i = 0; i<pass.length(); i++){
		if(i+3< pass.length() && isdigit(pass[i]) && isdigit(pass[i+1]) && isalpha(pass[i+2])){
			alphaNum=true;
		}
	}

	if(alphaNum==false){
		cout<<"Your password must have at least one combination of two numbers and a letter!"<<endl;
		return false;
	}
	
	//Checking for special 
	for(int i = 0; i<pass.length(); i++){
		if(!isdigit(pass[i]) && !isalpha(pass[i])){
			special = true;
		}
	}
	if(special != true){
		cout<<"Your password must have at least one special character!"<<endl;
		return false;
	
	}
		return true;


}