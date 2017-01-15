/*
	Innocent Niyibizi
	9/15/15
	Practice pointers
*/

#include <iostream>
#include <cstring>
using namespace std;

//Protoypes....
int square(int);	//Pass by value
void squar(int *);		//Pass by reference
void squ(int &);	//Pass-by 
//const 
int sqConst(const int);
int sqNonConst(int);
int sqConstRef(const int &);
int sqNonConstRef(int &);
//Passing the functions return value
int & sqRef(int &);	//return by reference
int * sqPtr(int *);	//return pointer
//Dynamically allocate memory as return value by reference
int * squrPtr(int);
int & squrRef(int);
int main(){
	/**********************
	//Pointer examples
	int number = 88;	//Declaring a variable that is an integer and giving an initial value
	int * pNumber;	//Assign the address of the variable number to pointer pNUmber
	pNumber = &number;

	cout<<pNumber<<endl;	//Prints content of pNumber - address
	cout<<&number<<endl;	//Prints address of number
	cout<<*pNumber<<endl;	//Prints out value pointed to by pNumber - 88
	cout<<number<<endl;		//Prints value of number - 88
	cout<<&pNumber<<endl;	//Prints the address of pointer variable pNumber
	

	//unimitialized pointers - This can be serious logic error.......
	//Does not execute
	//Can not assign a literal to a pointer

	int * iPtr;
	*iPtr = 55;
	cout<<*iPtr<<endl;
	


	//null pointers 
	//initialize a pointer to 0 or NULL - points to nothing
	//Dereferencing a null pointer (*p) causes a STATUS_ACCESS_VIOLATION exception
	int *iPtr = 0;	//Declared an int pointer, and initialized the pointer to point to nothing
	cout<<*iPtr<<endl;
	int * p = NULL;	//Also declares a NULL pointer that points to nothing
	//Initalize a pointer to null during declaration is a good software engineering practice
	//C++11 uses a new keyword which represents null pointer: nullptr
	
/****************
	//Refernces (or Aliases) &
	//& is  usesd to denote the address-of-operator in an expression. You can use the 7 to pass and return the address of the variables
	//However when & is used in a declaration it is part of the type identifier and is used to declare a reference varaiable. It is used  to provide another name, or another reference, or alias to an existing variable
	/*
		Syntax: 
		type &newName = existingName;
		or
		type& newName = existingName
		or
		type & newName = existingName
	int nbr = 88;
	int & refNbr = nbr;	//Declaring a reference to the variable number. Both refnbr and nbr refer t o the same value
	cout<<nbr<<endl;	//99
	cout<<refNbr<<endl;	//99

	refNbr = 99;	
	cout<<endl<<nbr<<endl;	//99
	cout<<refNbr<<endl;		//99

	nbr=55;
	cout<<endl<<nbr<<endl;	//55
	cout<<refNbr<<endl;		//55
	*/
	
	//Reference vs pointer 
	/*************************************
		Pointer and references are equivelent, except: 
		1.) A refernce is a name of a constant for an address. You need to initialize the reference during declaration.	int & iRef - error: iRef declared as a reference but not intialized 
		2.) To get the value pointed to by a pointer, you need to use the dereferncing operator * - *pNum. *pNum would be return the value pointed to by pNum. To assign an address of a   variable into a pointer, you need to use the address-of-operator (&)
	

	int nbr1 = 88;
	int nbr2 = 22;
	//Creaate a pointer pointing to nbr1
	int * pnbr1 = &nbr1;	//Explicit referencing
	*pnbr1 = 99;	//Explicit dereferncing
	cout<<*pnbr1<<endl;	//Prints 99
	cout<<&nbr1<<endl;	//Prints address
	cout<<pnbr1<<endl;	//Prints address
	cout<<&pnbr1<<endl;	//address

	pnbr1 = &nbr2;	//Pointer is reassigned to store another address
	//Create a reference to nbr1
	int & refnbr1 = nbr1; //implicit referencing (NOT &nbr1)
	refnbr1 = 11;	//Implicit dereferencing (NOT *refnbr1) 
	cout<<refnbr1<<endl;	//11
	cout<<&nbr1<<endl;		//Address
	cout<<&refnbr1<<endl;	//Adress
	//refnbr1 = &nbr2; //Will cause an error because it can not be re-assigned
	refnbr1 = nbr2;	//refnbr1 still an alias to nbr1 - assign value of nbr2 (22) to refnbr1 and nbr1
	nbr2++;
	cout<<refnbr1<<endl;	//22
	cout<<nbr1<<endl;	//22
	cout<<nbr2<<endl;	//23
	*/
	/**************
		Pass by reference into functions with refernce arguments vs pointer arguments

	
	//Pass by value
	int nbr = 8;
	cout<<"In main(): "<<&nbr<<endl;	//address
	cout<<nbr<<endl;	//8
	cout<<square(nbr)<<endl;	//64
	cout<<nbr<<endl;
	*********
	Pass by reference
	
	//Reference can update the arguments that get passed to he function. 
	int nbr = 2;
	cout<<"In main(): "<<&nbr<<endl;	//Address
	cout<<nbr<<endl;	//8
	squar(&nbr);	//Explicit referencing to pass an address 
	cout<<nbr<<endl;

	//Pass by reference arguments
	

	int nbr = 9;
	cout<<"In main(): "<<&nbr<<endl;	//Address
	cout<<nbr<<endl;	//9
	squ(nbr);	//Explicit referencing to pass an address 
	cout<<nbr<<endl;
	******************
	const function reference/pointer parameters
	a const function formal parameter cannot be modified inside the function. Use const whenever possible as it protects you from inadvertently modifying the parameter and protects you against may program error.
	a const function parameter can receive both const and non const argument. On the other hand, a const function reference/pointer parameter can only receive non-const argument.
	
	int nbr = 8;
	const int CONSTNBR = 9;
	cout<<sqConst(nbr)<<endl;
	cout<<sqConst(CONSTNBR)<<endl;
	cout<<sqNonConst(nbr)<<endl;
	cout<<sqNonConst(CONSTNBR)<<endl;

	cout<<sqConstRef(nbr)<<endl;
	cout<<sqConstRef(CONSTNBR)<<endl;
	cout<<sqNonConstRef(nbr)<<endl;
	//cout<<sqNonConstRef(CONSTNBR)<<endl;
	//cout<<sqNonConstRef(nbr)<<endl;	error: invalid intitalization or refernce of type  int& from expression of type "constin"
	**********
	Passing the function return value
	
	int nbr1 = 8;
	cout<<"In main(): nbr1"<<nbr1<<endl;
	int & result = sqRef(nbr1);
	cout<<" in main() &result "<<&result<<endl;
	cout<<result<<endl;
	cout<<nbr1<<endl;

	int nbr2 = 9;
	cout<<" In main(): &nbr2"<<&nbr2<<endl;
	int * pResult = sqPtr(&nbr2);
	cout<<" in main() pResult "<<pResult<<endl;
	cout<<*pResult<<endl;
	cout<<nbr2<<endl;
	**************
	new and delete operators
	Passing dynamically allocated memory as return value by reference
	

	int nbr = 8 ;
	cout<<nbr<<endl;
	cout<<*squrPtr(nbr)<<endl;
	cout<<squarRef(nbr)<<endl;
	*/

	int num = 5;
	int *p1 = &num;
	cout<<*p1<<endl;
	cout<<p1<<endl;
	cout<<&p1<<endl;
	
	system("pause");
	return 0;
}
//Pass by value
int square(int num){
	cout<<"in Square(): "<<&num<<endl;	//Address
	return num*=num;
}
//Pass by reference
void squar(int * n){	//Function takes an int reference 
	cout<<"In squar(): "<<n<<endl;//address
	*n *= *n;
}
void squ(int & num1){	//Funct
	cout<<"In squ(): "<<&num1<<endl;//address
	num1 *= num1;
}
int sqConst(const int nbr){
	//nbr *= //error: assignment of read-only parameter
	return nbr * nbr;
}
int sqNonConst(int nbr){
	nbr *= nbr;
	return nbr;
}
int sqConstRef(const int & nbr){
	return nbr * nbr;
}
int sqNonConstRef(int & nbr){
	return nbr * nbr;
}
//Passing the functions return value
int & sqRef(int & rnum){
	cout<<" In sqRef(): "<<&rnum<<endl;
	rnum *= rnum;
	return rnum;
}
int * sqPtr(int * pnum){
	cout<<" In sqRef(): "<<pnum<<endl;
	*pnum *= *pnum;
	return pnum;
}
//Dynamically allocate memory as return value by reference
int * squrPtr(int n){
	int * dynamicALLResult = new int(n * n);
	return dynamicALLResult;

}
int & squrRef(int n){
	int * dynamicALLResult = new int (n * n);
	return *dynamicALLResult;

}
