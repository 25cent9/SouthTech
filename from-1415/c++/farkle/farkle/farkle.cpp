/*
	Programmer: Innocent Niyibizi
	Date: 5-6-15
	Purpose: To recreate Farkle
*/

#include <iostream>
#include <time.h>

using namespace std;
int checkDi(int);
void main(){
	//Setting contsant point values for di 
	int const ONE = 100;
	int const FIVE = 50;
	int const FOUR_KIND = 1000;
	int const FIVE_KIND = 2000;
	int const SIX_KIND = 3000;
	int const FOUR_KIND_PAIR = 1000;
	int const THREE_PAIRS = 1500; //Three different pairs
	int const TWO_SETS_OF_THREE = 25000;
	int const THREE_SIXES = 600;
	int const THREE_FIVE = 500;
	int const THREE_TWO = 200;
	int const THREE_THREE = 300;
	int const THREE_FOUR = 400;
	int const THREE_ONE = 100;
	int const STRIGHT_SIX = 1500;


	int pointsPlr = 0;
	int di [6] = {};
	srand(time(NULL));
	int rndNbr = 0;
	int points = 0;
	while (points<500){
			//initial roll to get up to 500 points
		for(int x=0; x<6; x++){
			rndNbr = rand() % 6+1;
			di[x] = rndNbr;
			cout<<di[x];
		}
		points = checkDi(di);

	}
	system("pause");
}
int checkDi(int di[]){
	int choice = 0;
	for(int y=0; y<6; y++){
		if(di[y]==1 || di[y]==5){
			do{
				cout<<"Which di would you like to take (1 or 5): ";
				cin>>choice;
			}while(choice!= 1 || choice!=5);
		}
	}

}