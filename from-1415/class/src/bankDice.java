

public class bankDice {

	/**
	 * Name: Innocent Nyibizi
	 * Purpose: To get user input for a dice game
	 * Date: 10-28-13 
	 */

	static int bank=20;			//Declaring the variables. 
	static int points;
	static int offer;
	static String player;
	static int dice1;
	static int dice2;
	static int roll;
	static int die;

	public static int  pointsCalc (){		//Subroutine to calculate the player's point outcome.



		if(roll==die){						//If true the subroutine will run.

			if(die==2 || die==12){			//Writing the mathematical expressions to determine the point outcome 
				bank=(4*offer)+bank;
			}

			else if(die== 3 || die==11){
				bank=(3*offer)+bank;
			}

			else if(die==4 || die==10){
				bank=(2*offer)+bank;
			}

			else if(die==5 || die==9){
				bank= (3*offer)/2+bank;
			}

			else if(die==6 || die==8){
				bank=bank+6;
			}

			else if(die==7){
				bank= (1*offer)+bank;
				
			}
		}
		return bank;

	}




	public static void main(String[] args) {

		TextIO.putln("What is your name?"); 		//Asking for the player's name.

		player=TextIO.getln();

		TextIO.putln("Hello " +player+" lets play a game. ");

		while(bank != 0 || bank!=100){

			if(bank<=0 || bank>=100){				//Stopping the while loop when bank is 0 or 100.
				break;
			}

			int dice1= (int) (Math.random()*6) + 1;

			int dice2= (int) (Math.random()*6) + 1;

			TextIO.putln(player+" You have a total of "+bank+" points in your bank");

			TextIO.putln("What is the roll (from 2-12) that you think you will get "+player+"?");

			roll = TextIO.getInt();

			if(roll<2 || roll>12){
				TextIO.putln(player+" please pick a new number from 2-12.");
			}



			if(roll>=2 || roll==12){			//Running the program when the expected roll is 2-12.


				TextIO.putln(player+" your expected roll is " + roll);


				if(roll==6 || roll==8){
					TextIO.putln(player+ " since you picked " +roll+ " your offer can only be a 5.");
					offer=5;
				}

				else if(roll==5 || roll==9){
					TextIO.putln(player+ " since you picked "+roll+" your offer can only be a 2 or a 4.");
					offer=TextIO.getInt();

					while(offer!=2||offer!=4){
						TextIO.putln(player+" Please enter 2 or 4!");
						offer=TextIO.getInt();
						if(offer==2 || offer==4){
							break;
						}
					}
				}

				else if(roll!=6 || roll!=8){
					TextIO.putln(player+ " Please pick an offer from 1-5");
					offer=TextIO.getInt();
				}

				bank= bank-offer;						//Subtracting the offer from the bank.

				die=dice1+dice2;						//Adding both dice together.

				TextIO.putln("The roll was a " + die);

				pointsCalc ();							//Calling the subroutine.




			}
		}

		if(bank<=0){
			TextIO.putln("I'm sorry " +player  +  " you have "+bank+" points, you lose" );
		}
		else if(bank>=100){
			TextIO.putln("Woah"+player+" You have "+bank+"  points in your bank, You win!");		
		}


	}
}



