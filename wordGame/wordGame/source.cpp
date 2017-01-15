/*
	Innocent Niyibizi
	10/6/15
	Create program to play a game where the user gusess a secret word while a counter is present
*/

#include <iostream>
#include <vector>
#include <string>
#include <stdlib.h> 
#include <time.h> 
#include <iomanip>

using namespace std;
void place(vector<string> &);
void secret(string, vector<char>&);
void print(vector<char>, vector<char>);
char val(char, vector<char>);
bool check(char, vector<char>);
int main(){
	bool match = false;	//Boolean to decide whether or not the input matches a character in the secret word
	vector<string>words;	//Vector of all the secret words
	vector<char> fuse;	//Vector to hold the characters for  the fuse
	place(words);	//Function to place all of the words into the words vector
	string secretWord = "";
	vector<char>placeHolder;	//Vector used that holds all characters of the secret word. Used to check for a match based on input
	vector<char>temp;	
	vector<char>usedLetters;
	char input = ' ';
	srand (time(NULL));
	for(int i = 0; i<10; i++){	//Loop to create the fuse
		fuse.push_back('#');
	}
	secretWord = words[rand() % 15+0 ];	//Setting the secret word from a random number from 0-15
	secret(secretWord, placeHolder);
	for(int i = 0; i<placeHolder.size(); i++){
		temp.push_back('*');
	}
	print(temp, fuse);
	cout<<"Please enter the first character you would like to guess: ";
	cin>>input;
	input = val(input, usedLetters);
	usedLetters.push_back(input);
	for(int i = 0; i<placeHolder.size(); i++){
		if(placeHolder[i]==input){
			temp[i]=input;
			match = true;
		}
	}
	if(match == false){
		fuse.pop_back();
	}
	match = false;
	print(temp, fuse);
	do{
		cout<<"Please enter your next character: ";
		cin>>input;
		input = val(input, usedLetters);
		usedLetters.push_back(input);

		for(int i = 0; i<placeHolder.size(); i++){
			if(placeHolder[i]==input){
				temp[i]=input;
				match = true;
			}
		}
		if(match == false){
			fuse.pop_back();
		}
		match = false;
		print(temp, fuse);
		if(fuse.size() == 0){
			cout<<"The fuse has finished and the bomb has blown up!!!!!!!!!!!!!"<<endl;
			break;
		}
		if(temp==placeHolder){
			cout<<"Congrats you got the correctly figured out the word!!!!"<<endl;
			break;
		}
	}while(temp!=placeHolder);
	system("pause");
	return 0;
}
void place(vector<string>&list){
	list.push_back("administration");
	list.push_back("babbling");
	list.push_back("clairvoyant");
	list.push_back("empathy");
	list.push_back("exasperation");
	list.push_back("intuitive");
	list.push_back("spurious");
	list.push_back("prodigious");
	list.push_back("magnanimous");
	list.push_back("zealous");
	list.push_back("waft");
	list.push_back("sycophant");
	list.push_back("rhetoric");
	list.push_back("ostracize");
	list.push_back("infinitesimal");
}
//Function to set the values of the placeHolder vector equal to the characters in the secret word 
void secret(string in, vector<char>& holder){
	for(int j = 0; j<in.length(); j++){
		holder.push_back('-');
	}
	for(int i = 0; i<in.length(); i++){
		holder[i]=in[i];
	}
}
//Function used to print the fuse and the temporary string
void print(vector<char>tempo, vector<char>time){
	cout<<"Your guess: "<<setw(20)<<"Fuse: "<<endl;
	for(int i = 0; i<tempo.size(); i++){
		cout<<tempo[i];
	}
	cout<<setw(19);
	for(int i = 0; i < time.size(); i++){
		cout<<time[i];
	}
	cout<<endl;
}
//Function to ensure that the user has entered a letter
char val(char in, vector<char> used){
	while(!isalpha(in)){
		if(isdigit(in)){
			cout<<"Invalid input, you entered a number, please enter a different character: ";
			cin>>in;
		}
		else if(!isalpha(in) && !isdigit(in)){
			cout<<"Invalid input, you entered a special character, please enter a differnt character: ";
			cin>>in;
		}
	}
	while(check(in, used)==true){
		cout<<"You have already used that character, please enter a new one: ";
		cin>>in;
	}
	return in;
}
//Function to check if character passed through was already used 
bool check(char in, vector<char> used){
	for(int i = 0; i < used.size(); i++){
		if(in == used[i]){
			return true;
		}
	}
	return false;
}