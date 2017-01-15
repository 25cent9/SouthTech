#include "bank.h"

//static member variables
int Bank::totalAccounts = 0;
double Bank::bankBalance = 10000;

	Bank::Bank() {
		accountNumber = 0;
		balance = 0.0;
		totalAccounts++;
	}

	Bank::Bank(string newName, int newAccountNumber, double newBalance) {
		name= newName;
		accountNumber = newAccountNumber;
		balance = newBalance;
		totalAccounts++;
		bankBalance += newBalance;

	}

	Bank::~Bank() {
		totalAccounts--;
		bankBalance -= balance;
	}

	string Bank::getName() const {
		return name;
	}

	int Bank::getAccountNumber() const{
		return accountNumber;
	}

	double Bank::getBalance() const {
		return balance;
	}


	//Mutator
	void Bank::setName(string newName){
		name = newName;

	}

	void Bank::setAccountNumber(int newAccountNumber){
		accountNumber = newAccountNumber;
	}

	void Bank::setBalance(double newBalance){
		bankBalance -= balance;
		balance = newBalance;
		bankBalance += balance;
	}

	void Bank::withdraw(double withdraw){
		balance -= withdraw;
		bankBalance -=withdraw;
	}

	void Bank::deposit(double deposit){
		balance += deposit;
		bankBalance +=deposit;
	}

	void Bank::printBankInfo(){
		cout<<endl<<endl<<"Number of Account: " <<totalAccounts<<endl;
		cout<<"Total Balance: "<<bankBalance<<endl<<endl;
	}
