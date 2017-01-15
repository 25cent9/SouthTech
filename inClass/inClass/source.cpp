/*
	Innocent Niyibizi
	9/21/15
	In class examples
*/
#include <iostream>

using namespace std;

int main(){
	/*
	float * ollie;
	ollie = new float;
	*ollie = 3.14159;
	delete ollie;

	int i=0;
	int &alias = i;
	//int *ptr = &i;
	i = 9;
	//cout<<"Alias: "<<alias<<" Ptr: "<<*ptr<<" I: "<<i<<endl;
	int * ptr = &i;
	int * ptr2= &i;
	cout<<i<<endl;
	cout<<ptr<<endl;
	cout<<*ptr<<endl;
	*/
	int *tabptr, sum=0;
	tabptr = new int [5];
	for(int i = 0; i<5; i++){
		tabptr[i]=i;
	}
	sum = 0;
	for(int i = 0; i<5; i++){
		sum += tabptr[i];
		cout<<tabptr[i]<<endl;
	}
	delete [] tabptr;

	system("pause");
	return 0;
}