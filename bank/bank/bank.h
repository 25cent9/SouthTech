#include <iostream>
#include <string>
using namespace std;

class Bank {
public:
	//default constructor
	Bank();

	//Overload constructor
	Bank(string, int, double);

	//destructor
	~Bank();

	//accessor
	string getName() const;
		// getName = returns name of user
		// @return string - name of user

	int getAccountNumber() const;
		// getAccountNumber = returns account number of user
		// @return int - account number of user

	double getBalance() const;
		// getBalance = returns balance of user
		// @return double - balance of user


	//Mutator
	void setName(string);
		// setName = sets name of user
		// @param string - name of user

	void setAccountNumber(int);
		// setAccountNumber = sets account number for user
		// @param int - account number of user

	void setBalance(double);
		// setBalance = sets balance of user
		// @param double - balance of user

	void withdraw(double);

	void deposit(double);

	static void printBankInfo();


private:
	//member variables
	string name;
	int accountNumber;
	double balance;

	static int totalAccounts;
	static double bankBalance;
};