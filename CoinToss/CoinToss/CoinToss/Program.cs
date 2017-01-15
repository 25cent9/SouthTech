/*
 * Inncoent Niyibizi
 * 1-13-16
 * Create a program that will ask user for input, compare that input, and give the user a win or loss. The program will then tally up the wins and losses and display them at the end 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinToss{
    class Program{
        static void Main(string[] args){
            //Declaring variables
            char user = ' ';
            int goOn = 0;
            Random random = new Random();
            int coin; 
            int wins=0, losses = 0;
            //Loop that will run as long as user wants to continue playing
            do{
                Console.Clear();    //Clearing the console
                GatherInput(ref user);  //Gathering input
                coin = random.Next(0,2);    //Setting the coin equal to a random number
                Compare(win:ref wins, lose: ref losses, pick:user, coin: coin); //Copmparing the side of the coin and the user's selection
                Console.Write("Would you like to continue? <0 to exit, 1 to continue>: ");  //Asking the user if they would like to continue
                goOn = int.Parse(Console.ReadLine());
            }while(goOn != 0);
            Console.Clear();
            Print(win:wins, loss: losses);  //Printing the results
            Console.ReadLine();
        }
        //Function to get input from the user
        private static void GatherInput(ref char player) {
            Console.Write("Heads or tails? <A or B>:  ");
            player = char.Parse(Console.ReadLine());
            while(player!='A' && player != 'a' && player != 'B' && player != 'b'){
                Console.Write("Error; Invalid input!\nPlease re-enter: ");
                player = char.Parse(Console.ReadLine());
            } 
        }
        //Function to compare the user's selection and the side of the coin
        private static void Compare(ref int win, ref int lose, char pick, int coin) {
            if (pick == 'A' || pick == 'a' && coin == 0){
                win++;
            }
            else if (pick == 'B' || pick == 'b' && coin == 1){
                win++;
            }
            else {
                lose++;
            }
        }
        //Function to print wins and losses
        private static void Print(int win, int loss) {
            Console.WriteLine("Wins:\t\t\tLosses");
            Console.WriteLine("{0}\t\t\t{1}",win,loss);
        }
    }
}
