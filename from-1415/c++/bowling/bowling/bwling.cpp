/*
	Programmer: Innocent
	Date: 5-11-15
	Purpose: To create a program to calculate the points in a session of bowling
*/

#include <iostream>
#include <string>
#include <iomanip>
using namespace std;
void strike(int , int, int, int &);
void validate(int, int, int &);
void spare(int , int , int &);
int main(){
	int val = 0;
	int total = 0;
	int frameTotal = 0;
	int frame_first = 0;
	int frame_second = 0;
	char choice = ' ';
	int totals[10] = {};
	int numStrike = 0;
	int numSpare = 0;
	int numOpen = 0;
	do{	//Loop to run one time and then ask the user if they want to contiue by entering y
		for(int x=0; x<9; x++){	//Loop to run until it reaches the 10th frame
			do{
				cout<<"Please enter the first ball for frame "<<x+1<<" :";
				cin>>frame_first;
				if(frame_first!=10){
					cout<<"Please enter the second ball for frame "<<x+1<<" :";
					cin>>frame_second;
				}
				validate(frame_first, frame_second, val);
			}while(val==1);
		
			if(frame_first==10){
				frameTotal = frame_first+frame_second;
				x++;
				do{
					cout<<"Please enter the first ball for frame "<<x+1<<" :";
					cin>>frame_first;
					if(frame_first!=10){
						cout<<"Please enter the second ball for frame "<<x+1<<" :";
						cin>>frame_second;
					}
					validate(frame_first, frame_second, val);
				}while(val==1);
				strike(frameTotal, frame_first, frame_second, total);
				numStrike++;
			}
			else if(frame_first+frame_second==10){
				x++;
				do{
					cout<<"Please enter the first ball for frame "<<x+1<<" :";
					cin>>frame_first;
					if(frame_first!=10){
						cout<<"Please enter the second ball for frame "<<x+1<<" :";
						cin>>frame_second;
					}
					validate(frame_first, frame_second, val);
				}while(val==1);
				spare(10, frame_first, total);
				numSpare++;
			}
			else{
				totals[x]=frame_first+frame_second;
			}
			
		}
	}while(choice=='y');

	cout<<"Frame"<<setw(5)<<"Score"<<endl;
	cout<<"------"<<setw(5)<<"------"<<endl;
	for(int z=0; z<10; z++){
		cout<<z+1<<setw(5)<<totals[z]<<endl;
	}
	cout<<"Number of strikes : "<<numStrike<<endl;
	cout<<"Number of spares : "<<numSpare<<endl;
	cout<<"Open frames : "<<numOpen<<endl;
	cout<<total;
	system("pause");
	return 0;
}
void spare(int ten, int nextBall, int &tot){
	tot += ten+nextBall; 
}
void strike(int frame, int first, int second, int &tot){
	tot += frame+(first+second);
}
void validate(int first, int second, int &val){
	if(first+second>10){
		cout<<"The values that you inputed are more than 10 combined, please reenter"<<endl;
		val=1;
	}
	if(first>10 || first<0){
		cout<<"The first ball is less than 0 or greater than 10 please reenter "<<endl;
		val=1;
	}
	else if(second>10 || second<0){
		cout<<"The first ball is less than 0 or greater than 10 please reenter "<<endl;
		val=1;
	}
	else{
		val=0;
	}
}