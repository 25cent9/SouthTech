
public class rock {

	/**
	 * Name: Innocent Nyibizi
	 * Date: 10-18-13
	 * Purpose: To have the computer play RPSLS against itself
	 */
	static int counter=0;
	public static int counter1=0;
	public static int counter2=0;
	public static int counter3=0;
	static int Rock=1;
	static int Paper=2;
	static int Scissors=3;
	static int Lizards=4;
	static int Spock=5;
	public static int PLayer1;
	public static int Player2;

	public static int playerTwo (int Player2, int Player1){
		if(Player1==1 && Player2==2){								//Declaring the winner of each possible outcome.					
			TextIO.putln(" Paper Covers Rock, Player Two wins!");
			counter2++;	
		}
		if(Player1==3 && Player2==1){
			TextIO.putln("Rock breaks Scissors, Player Two wins!");
			counter2++;
		}
		if(Player1==1 && Player2==5){
			TextIO.putln("Spock vaporises Rock, Player Two wins!");
			counter2++;
		}
		if(Player1==4 && Player2==1){
			TextIO.putln("Rock crushes Lizard, Player Two wins!");
			counter2++;;
		}
		if(Player1==2 && Player2==3){
			TextIO.putln("Scissors cuts Paper, Player Two wins!");
			counter2++;
		}
		if(Player1==5 && Player2==4){
			TextIO.putln("Lizard poisons Spock, Player Two wins!");
			counter2++;
		}
		if(Player1==3 && Player2==5){
			TextIO.putln("Spock smashes Scissors, Player Two wins!");
			counter2++;
		}
		if(Player1==4 && Player2==3){
			TextIO.putln("Scissors decapitate lizard, Player Two wins!");
			counter2++;
		}
		if(Player1==2 && Player2==4){
			TextIO.putln("Lizard eats Paper, Player Two wins!");
			counter2++;
		}
		if(Player1==5 && Player2==2){
			TextIO.putln("Paper disproves Spock, Player Two wins!");
			counter2++;
		}
		return Player2;
	}
		
	public static void main(String[] args) {
		
		while (counter<=9){								//Looping the program if it hasn't ran 9 times
			
			int Player1=(int) (Math.random()*5) + 1;    //Declaring a random integer for Player one and Two
			int Player2=(int) (Math.random()*5) + 1;
			
			if(Player1==Player2 || Player2==Player1){   //Printing out a tie if the value of Player 1 and Player 2 are equal
				TextIO.putln("Its a tie!");
				counter3++;
			}
			
			playerTwo(Player2, Player1);		//Calling the subroutine to get Player Two's wins
				
			if(Player1==2 && Player2==1){
				TextIO.putln("Paper covers Rock, Player One wins!");
				counter1++;
			}
			if(Player1==1 && Player2==3){
				TextIO.putln("Rock breaks Scissors, Player One wins!");
				counter1++;
			}
			
			if(Player1==5 && Player2==1){
				TextIO.putln("Spock vaporises Rock, Player One wins!");
				counter1++;
			} 
		    if(Player1==1 && Player2==4){
				TextIO.putln("Rock crushes Lizard, Player One wins!");
				counter1++;
			}
		    
			if(Player1==3 && Player2==2){
				TextIO.putln("Scissors cuts Paper, Player One wins!");
				counter1++;
			}
			
			if(Player1==4 && Player2==5){
				TextIO.putln("Lizard poisons Spock, Player One wins!");
				counter1++;
			}
			
			if(Player1==5 && Player2==3){
				TextIO.putln("Spock smashes scissors, Player One wins!");
				counter1++;
			}
			
			if(Player1==3 && Player2==4){
				TextIO.putln("Scissors decapitae lizard, Player One wins");
				counter1++;
			}
			
			if(Player1==4 && Player2==2){
				TextIO.putln("Lizard eats paper, Player One wins!");
				counter1++;
			}
			
			if(Player1==2 && Player2==5){
				TextIO.putln("Paper disproves Spock, Player One wins!");
				counter1++;
			}
			
			++counter;													//Adding one to the original counter to keep the loop true
		}
		System.out.println("Player One won:"+counter1 + " times.");		//Printing out the number of wins that Player one had
		System.out.println("Player Two won:"+counter2 + " times.");		//Printing out the number of wins that Player two had
		TextIO.putln("There were "+ counter3+" ties.");					//Printing out the number of ties
	}
	

}
