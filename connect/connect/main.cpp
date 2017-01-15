//Griffin Melson, Keith Wilson, Innocent Niyibizi
//08/28/2015
//two users play a game of Connect 4
#include<iostream>
#include<string>
#include<vector>
#include<algorithm>
using namespace std;
string valStr(string,vector<string>,bool);
void toUpper(string &);
char checkWin(char[7][6]);
void play();
string boardStr(char[7][6], char);
string boardStr(char[7][6]);
int main()
{
        cout<<"Time to play Connect 4!\n";
        bool playAgain=true;
        vector<string>responses;
        responses.push_back("y");
        responses.push_back("n");
        do
        {
			play();
            if(valStr("Would you like to play again? (y/n)\n",responses,true)=="N")
            {
				playAgain=false;
            }
        }while(playAgain);
        system("pause");
        return 0;
}
//generic validating function for strings, has a message asking the user for the input, the possible values for the user's input, and if the input should be made uppercase. Asks user for input until they give a valid one, then returns it
string valStr(string message,vector<string>responses,bool upperCase)
{
        bool valid=false;
        string input;
		
        do
        {
                cout<<message;
                cin>>input;
                if(upperCase==true)
                {
                        toUpper(input);
                        for(size_t i=0;i<responses.size();i++)
                        {
                                toUpper(responses[i]);
                        }
                }
				for (size_t i = 0; i<responses.size(); i++)
                {
                        if(input==responses[i])
                        {
                                valid=true;
                                break;
                        }
                }
                if(valid==false)
                {
                        cout<<"Invalid input\n";
                }	
        }while(valid==false);
        return input;
}
//converts a string to uppercase
void toUpper(string &input)
{
        transform(input.begin(), input.end(), input.begin(), ::toupper);
}
//plays connect 4
void play()
{
        vector<string>responses;
			for(int i=1;i<=7;i++)
			{
					responses.push_back(to_string(static_cast<long long>(i)));
			}
			char board[7][6];

			for(int i=6;i>=0;i--)
			{
					for(int j=5;j>=0;j--)
					{
							board[i][j]=' ';
					}
			}
			cout << boardStr(board);
			while (board[6][5] == ' '){
				char input = valStr("Please enter the position in which you would like to place your peice (1-7): ", responses, false)[0];
				cout << boardStr(board, input);
			}
			
}
//checks the board to see if anyone has won the game
char checkWin(char board[7][6])
{
        int count=0;
        char player='z';
        //check for horizontal wins
        for(int i=5;i>=0;i--)
        {
                for(int j=6;j>=0;j--)
                {
                        if(board[j][i]==' ')
                        {
                                count=0;
                        }
                        else
                        {
                                if(player==board[j][i])
                                {
                                        count++;
                                }
                                else
                                {
                                        player=board[j][i];
                                        count=1;
                                }
                                if(count>=4)
                                {
                                        return player;
                                }
                        }
                }
        }
        count=0;
        player='z';
        //check for vertical wins
        for(int i=6;i>=0;i--)
        {
                for(int j=5;j>=0;j--)
                {
                        if(board[i][j]==' ')
                        {
                                count=0;
                        }
                        else
                        {
                                if(player==board[i][j])
                                {
                                        count++;
                                }
                                else
                                {
                                        player=board[i][j];
                                        count=1;
                                }
                                if(count>=4)
                                {
                                        return player;
                                }
                        }
                }
        }
        count=0;
        player='z';
        //check for rtl ttb diagonal wins
        for(int i=2;i>=0;i--)
        {
                for(int j=6;j>=3;j--)
                {
                        count=0;
                        if(board[j][i]!=' ')
                        {
                                player=board[j][i];
                                int x=j;
                                int y=i;
                                do
                                {
                                        x--;
                                        y++;
                                        if(board[x][y]==' ')
                                        {
                                                count=0;
                                        }
                                        else
                                        {
                                                if(player==board[x][y])
                                                {
                                                        count++;
                                                }
                                                else
                                                {
                                                        player=board[i][j];
                                                        count=1;
                                                }
                                                if(count>=4)
                                                {
                                                        return player;
                                                }
                                        }
                                }while(count>0&&x>3&&y<5);
                        }
                }
        }
        count=0;
        player='z';
        //check for ltr ttb diagonal wins
        for(int i=2;i>=0;i--)
        {
                for(int j=3;j<=6;j++)
                {
                        count=0;
                        if(board[j][i]!=' ')
                        {
                                player=board[j][i];
                                int x=j;
                                int y=i;
                                do
                                {
                                        x++;
                                        y++;
                                        if(board[x][y]==' ')
                                        {
                                                count=0;
                                        }
                                        else
                                        {
                                                if(player==board[x][y])
                                                {
                                                        count++;
                                                }
                                                else
                                                {
                                                        player=board[i][j];
                                                        count=1;
                                                }
                                                if(count>=4)
                                                {
                                                        return player;
                                                }
                                        }
                                }while(count>0&&x>3&&y<5);
                        }
                }
        }
        return'!';
}
string boardStr(char board[7][6])
{
        string temp;
        
		for(int i=6;i>=0;i--)
		{
			for(int j=5;j>=0;j--)
			{
				board[i][j]=' ';
			}
		}

		//vertical
		for(int i=0;i<6;i++)
		{
			cout<<"---------------\n";
			//horizontal
			for(int j=0;j<7;j++)
			{
				cout<<"|"<<board[j][i];	
			}

			cout<<"|\n";
		}
		cout<<"---------------\n";
 
        return temp;
}
string boardStr(char  board[7][6], char position)
{
        string temp;
        int cnt1 = 0;
		for(int i=6;i>=0;i--)
		{
			for(int j=5;j>=0;j--)
			{
				switch(position){
					case '1':
						if (board[0][5] = 'X' && i>6){
							board[0][4]='X';
							break;
						}
						board[0][5] = 'X';
						break;
					case '2':
						if (board[1][5] = 'X'){
							break;
						}
						board[1][5] = 'X';
						break;
					case '3':
						if (board[2][5] = 'X'){
							break;
						}
						board[2][5] = 'X';
						break;
					case '4':
						if (board[3][5] = 'X'){
							break;
						}
						board[3][5] = 'X';
						break;
					case '5':
						if (board[4][5] = 'X'){
							break;
						}
						board[4][5] = 'X';
						break;
					case '6':
						if (board[5][5] = 'X'){
							break;
						}
						board[5][5] = 'X';
						break;
					case '7':
						if (board[6][5] = 'X'){
							break;
						}
						board[6][5] = 'X';
						break;
					default: 
						board[i][j]=' ';
					break;
				}
			}
		}

		//vertical
		for(int i=0;i<6;i++)
		{
			cout<<"---------------\n";
			//horizontal
			for(int j=0;j<7;j++)
			{
				cout<<"|"<<board[j][i];	
			}

			cout<<"|\n";
		}
		cout<<"---------------\n";
 
        return temp;
}