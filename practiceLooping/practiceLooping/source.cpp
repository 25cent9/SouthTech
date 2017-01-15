/*
	Innocent Niyibizi
	9/14/15
	Create loop to print the first 100 Fibonacci numbers
*/
#include <iostream>
using namespace std;

int main(){
	unsigned long long a = 1;
	unsigned long long b = 1;
	unsigned long long c = a+b;
	cout<<"0"<<a<<" "<<b<<" ";
	for(int  i = 2; i<=200; i++){
		c = a+b;
		cout<<c<<" ";
		a=b;
		b=c;
	}
	system("pause");
	return 0;
}