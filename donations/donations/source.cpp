/*
	Innocent Niyibizi
	9/17/15
*/

#include <iostream>
using namespace std;
const int NumDons = 15;
void ArrSelectSort(int *[], int);
void ShowArrPtr(int *[], int);
void ShowArray(int [], int);
int main(){
	int Donations[NumDons] = {5, 100, 5, 25, 10, 5, 25, 5, 5, 100, 10, 15, 5, 10, 200};
	int *ArrPtr[NumDons];

	for(int count = 0; count < NumDons; count++){
		ArrPtr[count] = &Donations[count];
	}
	ArrSelectSort(ArrPtr, NumDons);
	cout<<"The donations sorted in ascending ordere are: \n";
	ShowArrPtr(ArrPtr, NumDons);
	cout<<"The donations, in their original order are: \n";
	ShowArray(Donations, NumDons);
	//Deletes the pointers
	for(int i=0; i < NumDons; i++){
		ArrPtr[i]=NULL;
	}

	system("pause");
}
//This function performs an ascending oder selection sort on Array, which is an array of pointers. Each array points to an element of a second array. After the sort, Array will point to the elements of the second array in ascending order. 
void ArrSelectSort(int *Arry[], int Elms){
	int StartScan, MinIndex; 
	int * MinElem;
	for(StartScan = 0; StartScan < (Elms-1); StartScan++){
		MinIndex = StartScan; 
		MinElem = Arry[StartScan];
		for(int index = StartScan+1; index < Elms; index++){
			if(*Arry[index] < *MinElem){
				MinElem = Arry[index];
				MinIndex = index;
			}
		}
		Arry[MinIndex] =Arry[StartScan];
		Arry[StartScan] = MinElem;
	}

}
void ShowArrPtr(int *A[] , int Elems){	//This function displays the contents of Array. Elems is the number of elements
	for(int i = 0; i < Elems; i++){
		cout<<*A[i]<<" ";
	}
	cout<<endl;

}
void ShowArray(int A[], int Elems){
	for(int i = 0; i < Elems; i++){
		cout<<A[i]<<" ";
	}
	cout<<endl;
}