/*
	Innocent Niyibizi
	Nexus day
	Example coversion of variables
*/

#include <iostream>
#include <iomanip>
#include <typeinfo>	//for type
using namespace std;

int main(){
	//Implicit conversion - automatically performed 
	float  f = 3;	//Assign integer 3 to a floating point variable
	// Compiler can not just copy the bits representing the value three into float f. It needs to convert the integer 3 to a floating point number. Type conversion
	cout<<"Convert int to float: "<<f<<endl;
	//Type conversion 
	double d = 3;	//Assign integer value 3 to double var 
	double d2(3);	//Inititalize double variable with integer value 3
	/*
		void doSomething(long l){
			
		}
		doSomething(3);	//Passing integer value 3 to a function expecting a long paramerter
	*/
	double division = 4.0/3;	//Division with a double and an integer 

	int i = 30000;
	char c = i;
	cout<<"Integer to char "<<static_cast<int>(c)<<endl;	//Large integer to a char (that has range -128 to 127). This causes the char to overflow and produces the result of 48
	//Convert from a large integral or a large floating type to a smaller similar type
	int j = 2;
	short s = j;	//Convert from int to short
	cout<<"short value: "<<s<<endl;
	double r = 0.1234;
	float ff = r;
	cout<<"double to float"<<ff<<endl;	//Gives it a warning but does not stop the program. May truncate.

	float fx = 0.123456789; //Double value has 9 significant figs, but float  can only support about 7
	cout<<"float: "<<fx<<endl;	//0.123457
	cout<<setprecision(9)<<fx<<endl;	//This case, we see aloss of precision becasue the float can't hold as much precsion as a double
	int ii = 10;
	float ffx = ii;
	cout<<"Int fits into float: "<< ffx<<endl;
	int u = 3.5; 
	cout<<"Truncation "<<u<<endl;
	/*
		When evaluatng expressions the compiler breaks each expression down into individual subexpressions. The arithetic operators require their operands to be of the SAME type. If operands of mixed types are used, the compiler will implicitly convert one operand to agree with the other using a process called USAUL ARITHMETIC CONVERSION 
		-- if the operand is an int, it undergoes integeral promotion
		-- if the operands still do not match, then the compiler finds the highest priority operand and converts the other operand to match
		//Priority of operands:
			long double (highest)
			double
			float
			unsigned long long
			long long
			unsigned long 
			long
			unsigned int
			int(lowest)
	*/
	//Shorts are smaller intergers, when doing a calculation of shorts it will convert them to ints and create an int
	short aa(4);
	short bb(5);
	cout<<typeid(aa).name()<<" "<<endl;
	cout<<typeid(aa+bb).name()<<" "<<aa+bb<<endl;
	/****/
	double dx(4.0);
	short sx(2);
	cout<<typeid(dx+sx).name()<<" "<<dx+sx<<endl;
	cout<<typeid(5u-10).name()<<" "<<5u-10<<endl;
	cout<<typeid(5-10u).name()<<" "<<5-10u<<endl;	//the signed integer (10) is promoted to an unsigned integer (which has higher priority), and the expression is evaluated as an unsigned int. Overflow results, and we get 4294967291	******Avoid unsigned integers in general******
	/****/
	int tt;
	tt = 5u - 10;	// Ansewer is -5
	cout<<tt<<endl;	//When compiler encounters 5-10u, it promotes 5 to an unsigned value, and 5u-10 produces the result 4294967291 (unsinged). However, it's worth noting that 4294967291u and -5 have the exact same bit pattern -- the interpretation depends entirely on wether l

	//static_cast
	char cc = 97;
	cout<<static_cast<int>(cc)<<endl;	//int of 97 not an 'a'
	//Static casr is best used to convert one fundamental type into another 
	// main advantage of static_cast  is that it provides compile time type  checking, making it harder to make an inadvertent error. static_cast is also less powerful than C-style casts 
	int chad = 48;
	char chaz  = static_cast<char>(chad);	//Casting an int (4bytes) to char (1 byte). This is unsafe and the compiler will typically complain
	cout<<chaz<<endl;
	char chaz2 = chad; 
	cout<<"chaz "<<chaz<<" chaz2 "<<chaz2<<endl;


	int i7 = 101;
	
	i7 = static_cast<int>(i7/2.5);
	cout<<typeid(i7).name()<<" "<<i7<<" static casted"<<endl;
	i7 = 101;
	cout<<typeid(i7/2.5).name()<<" "<<i7<<" not casted"<<endl;

	system("pause");
	return 0;
}
