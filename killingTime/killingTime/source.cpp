/*
	Innocent Niyibizi
	11/18/15
	Simulate two people walking through a maze to enter a stronghouse 
*/

#include <iostream>
#include <string>
#include <fstream>
using namespace std;

string checkGrid(char**, int, int);

int main(){
	int c = 0; 
	string in;
	int rows = 0;
	int cols = 0;
	ifstream input;
	bool end = false;
	input.open("input.txt", ios::in);
	if(input.is_open()==true){

		input >> c;
		for(int count=0; count<c; count++){
				end = false;
				input >> rows;
				input >> cols;

				char** grid = new char*[rows];
			while(getline(input, in) && end==false){
				for(int i=0; i<rows; i++){
					grid[i] = new char [cols];
				}
				for(int i = 0; i<rows; i++){
					for(int j = 0; j<cols; j++){
						input >> grid[i][j];
					}
				}
				cout<<checkGrid(grid, rows, cols)<<endl;
				end = true;
			}
			delete grid;
		}
		
		

	}
	
	input.close();
	system("pause");
	return 0;
}

string checkGrid(char** grid1, int r, int c){
	//i corresponds with r
	//j corresponds with c
	char per = ' ';
	int blockCount = 0;
	int cant = 0;
	int blank = 0;
	int blockPattern = 0;
	for(int i = 0; i<r; i++){
		for(int j = 0; j<c; j++){
			if(grid1[i][j]=='R' || grid1[i][j]=='A'){
				per = 'R';
				if(grid1[i][j]=='R'/* && grid1[i][j+1]=='T' || iCheck && grid1[i+1][j]=='T' || jCheck && grid1[i][j-1]=='T'*/){
					if(j+1<=c && grid1[i][j+1]=='T' || j-1>=0 && grid1[i][j-1]=='T'){
						return "Ronny, no!";
					}
					else if(i+1<=r && grid1[i+1][j]=='T' || i-1>=0 && grid1[i-1][j]=='T'){
						return "Ronny, no!";
					}
					else if(j+1<=c && grid1[i][j+1]=='_' && i+1<r && grid1[i+1][j]=='_' && grid1[i+1][j+1]=='T'){
						return "Ronny, no!";
					}
					else if(j-1>=0 && grid1[i][j-1]=='_' && i-1>=0 && grid1[i-1][j]=='_' && grid1[i-1][j-1]=='T'){
						return "Ronny, no!";
					}
					else if(j-1>=0 && grid1[i][j-1]=='_' && i-1>=0 && grid1[i-1][j]=='_' && grid1[i][j+1]=='#' && grid1[i-1][j-1]=='T'){
						return "Ronny, no!";
					}
					else if(j-1>=0 && grid1[i][j-1]=='_' && i+1>=0 && grid1[i+1][j]=='_' && grid1[i][j+1]=='#' && grid1[i+1][j-1]=='T'){
						return "Ronny, no!";
					}
					/*
					else if(j-1>=0 && i-1>=0 && grid1[i-1][j-1]=='T'){
						return "Ronny, no!";
					}
					else if(j-1>=0 && i+1<=r && grid1[i+1][j-1]=='T'){
						return "Ronny, no!";
					}
					else if(j+1<=c && i+1<=r && grid1[i+1][j+1]=='T'){
						return "Ronny, no!";
					}
					else if(j+1<=c && i-1>0 && grid1[i-1][j+1]=='T'){
						return "Ronny, no!";
					}
					*/
				}
				/*
				if(grid1[i][j]=='S' && grid1[i][j+1]=='T' || grid1[i+1][j]=='T' || grid1[i][j-1]=='T'){
					return "Ronny, no!";
				}
				*/
				else if(grid1[i][j]=='A'){
					per = 'A';
					if(j+1<=c && grid1[i][j+1]=='T' || j-1>=0 && grid1[i][j-1]=='T'){
						return "Raniba, no!";
					}
					else if(i+1<=r && grid1[i+1][j]=='T' || i-1>=0 && grid1[i-1][j]=='T'){
						return "Raniba, no!";
					}
					else if(j+1<=c && grid1[i][j+1]=='_' && i+1<r && grid1[i+1][j]=='_' && grid1[i+1][j+1]=='T'){
						return "Raniba, no!";
					}
					else if(j-1>=0 && grid1[i][j-1]=='_' && i-1>=0 && grid1[i-1][j]=='_' && grid1[i][j+1]=='#' && grid1[i-1][j-1]=='T'){
						return "Raniba, no!";
					}
					else if(j-1>=0 && grid1[i][j-1]=='_' && i+1>=0 && grid1[i+1][j]=='_' && grid1[i][j+1]=='#' && grid1[i+1][j-1]=='T'){
						return "Raniba, no!";
					}
					/*
					else if(j-1>=0 && i-1>=0 && grid1[i-1][j-1]=='T'){
						return "Raniba, no!";
					}
					else if(j-1>=0 && i+1<=r && grid1[i+1][j-1]=='T'){
						return "Raniba, no!";
					}
					else if(j+1<=c && i+1<=r && grid1[i+1][j+1]=='T'){
						return "Raniba, no!";
					}
					else if(j+1<=c && i-1>0 && grid1[i-1][j+1]=='T'){
						return "Raniba, no!";
					}
					*/
				}
			}

			else if(grid1[i][j]=='T' && j+2 && grid1[i][j+1]=='_' && grid1[i][j+2]!='S'){
				blockPattern++;
			}
			if(blockPattern>=2 && blockPattern%c){
				if(per=='R'){
					return "Ronny, no!";
				}
				else if(per=='A'){
					return "Raniba, no!";
				}
			}
			else if((blockPattern)){
			
			}
		}
		
	}
	return "Huzzah";
}