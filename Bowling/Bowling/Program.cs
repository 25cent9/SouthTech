/*
 * Innocent Niyibizi
 * 1-19-16
 * Create a program to score a bowling game
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling{
    class Program{
        
        //Structure for the bowlers
        private struct Bowler{
           //Declaring vavriables for the stucture
           public string name;
           public int [,] frames;
           public int [] frameScores;
           public int score;
           public int extraFrame;
        }
       
        static void Main(string[] args){
            //Displaying the instructions
            instructions();
            
            //Creating the first bowler  
            int frameCount = 1;
            Bowler first;
            first.frames = new int[10, 2];
            first.score = 0;
            first.frameScores = new int[10];
            first.extraFrame = 0;

            //Creating the second bowler 
            Bowler second;
            second.frames = new int[10, 2];
            second.score = 0;
            second.frameScores = new int[10];
            second.extraFrame = 0;

            Console.Write("Please enter the name of the first bowler: ");
            first.name = Console.ReadLine();

            do{
                Console.Write("Please enter the name of the second bowler: ");
                second.name = Console.ReadLine();

                if (second.name == first.name){
                    Console.WriteLine("Error: Both bowlers cannot have the same name!");
                }
            }while (second.name == first.name);

            //Calling the bowl methods
            while (frameCount <= 10){
                if (frameCount != 10)
                {
                    bowl(ref first, ref frameCount);
                    bowl(ref second, ref frameCount);
                    frameCount++;
                }
                else {
                    FrameTen(ref first);
                    FrameTen(ref second); 
                    frameCount++;
                }
            }

            first.score += first.extraFrame;
            second.score += second.extraFrame;
            CalcScore(bowler: ref first);
            CalcScore(bowler: ref second);
            DisplayResults(first, second);
            Console.ReadLine();
                    
        }

        //Function to display the winner
        private static void instructions() {
            Console.Write("Welcome to 'Bowl, Bowl, Bowl' where we put the 'bowl' in bowling!!\nTwo players will play; Each player must have different names.\n\nWhen asked to input the pins knocked over during the frame.\n\nHave fun and remember to come again!!\n\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        //Function to input the stats of each bowler
        private static void bowl(ref Bowler bowler, ref int count){
            Console.Clear();
            int fOne = 0;
            int fTwo = 0;

            //Loop to run until the user inputs a number between 0 and 10
            do{
                Console.Write("Enter the pins knocked down on the first roll for {0} for frame {1}: ",bowler.name,count);
                try{
                    fOne = int.Parse(Console.ReadLine());
                }
                catch{
                    Console.WriteLine("Error; please enter a number from 1-10");
                    fOne = -1;
                }
            } while (fOne > 10 || fOne<0);

            //Loop to run until the user inputs a value that wont exceed the frame maximun of 10
            do{
                if (fOne < 10){
                    Console.Write("Enter the pins knocked down on the second roll: ");
                    try
                    {
                        fTwo = int.Parse(Console.ReadLine());
                    }
                    catch 
                    {
                        Console.WriteLine("Error; please enter a number from 1-10");
                        fTwo = -1;
                    }
                }
                if(fOne+fTwo>10){
                    Console.Write("Error; the value of the second roll makes the total of the frame greater than 10; Please re-enter\n\n");
                }
                else if(fOne==10){
                    fTwo = 0;
                }
            }while(fOne+fTwo>10 || 0>fTwo);
            
            //Setting the values of fOne and fTwo to the values of the 2D array that holds in the corresponding locations
            bowler.frames[count-1,0] = fOne;
            bowler.frames[count-1,1] = fTwo;
        }

        //Function to calculate the score for each bowler
        private static void CalcScore(ref Bowler bowler)
        {
            //Loop to run for the total number of frames, 10
            for (int i = 0; i < 10; i++ ){
                //Condidtion to check if the frame was a strike and if the current flame is not 10
                if (bowler.frames[i, 0] == 10 && i < 10)
                {
                    try
                    {
                        if (bowler.frames[i + 1, 0] == 10)
                        {
                            try
                            {
                                try
                                {   //Try to check if there are two frames ahead, if not catch the error
                                    if (bowler.frames[i + 2, 0] == 10)
                                    {
                                        bowler.frameScores[i] = bowler.frameScores[i - 1] + bowler.frames[i, 0] + (bowler.frames[i + 1, 0] + bowler.frames[i + 2, 0]);
                                    }
                                    else
                                    {
                                        bowler.frameScores[i] = bowler.frameScores[i - 1] + bowler.frames[i, 0] + (bowler.frames[i + 1, 0] + bowler.frames[i + 2, 1]);
                                    }
                                }
                                catch (IndexOutOfRangeException)
                                {   //Do the same as the try except add the extra frame 
                                    bowler.frameScores[i] = bowler.frameScores[i - 1] + bowler.frames[i, 0] + (bowler.frames[i + 1, 0] + bowler.extraFrame);
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                bowler.frameScores[i] = bowler.frames[i, 0] + (bowler.frames[i + 1, 0] + bowler.frames[i + 2, 0]);
                            }
                        }
                        //Spare
                        else if(bowler.frames[i+1,0] + bowler.frames[i+1,1]==10)
                        {
                            try
                            {
                                bowler.frameScores[i] = bowler.frameScores[i - 1] + bowler.frames[i, 0] + (bowler.frames[i + 1, 0] + bowler.frames[i + 1, 1]);
                            }
                            catch(IndexOutOfRangeException) 
                            {
                                bowler.frameScores[i] = bowler.frames[i, 0] + (bowler.frames[i + 1, 0] + bowler.frames[i + 1, 1]);
                            }
                        }
                        else
                        {
                            try
                            {
                                bowler.frameScores[i] = bowler.frameScores[i - 1] + bowler.frames[i, 0] + (bowler.frames[i + 1, 0] + bowler.frames[i + 1, 1]);
                            }
                            catch (IndexOutOfRangeException)
                            {
                                bowler.frameScores[i] = bowler.frames[i, 0] + (bowler.frames[i + 1, 0] + bowler.frames[i + 1, 1]);
                            }
                        }
                    }
                    catch(IndexOutOfRangeException){
                        bowler.frameScores[i] = bowler.frameScores[i - 1] + bowler.frames[i, 0] + (bowler.frames[i,1] + bowler.extraFrame);
                    }
                }
                //Scoring the spares
                else if(bowler.frames[i,0]+bowler.frames[i,1]==10 && bowler.frames[i,1]!=0){
                    try
                    {
                        bowler.frameScores[i] = bowler.frameScores[i - 1] + bowler.frames[i, 0] + bowler.frames[i, 1] + bowler.frames[i+1,0];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        try
                        {
                            bowler.frameScores[i] = bowler.frameScores[i-1]+bowler.frames[i, 0] + bowler.frames[i+1, 0] + bowler.frames[i + 1, 1];
                        }
                        catch (IndexOutOfRangeException){
                            try
                            {
                                bowler.frameScores[i] = bowler.frameScores[i - 1] + bowler.frames[i, 0] + bowler.frames[i, 1] + bowler.extraFrame;
                            }
                            catch (IndexOutOfRangeException) {
                                bowler.frameScores[i] =  bowler.frames[i, 0] + bowler.frames[i + 1, 0] + bowler.frames[i + 1, 1];
                            }
                        }
                        
                    }
                }
                //Scoring any other type of frame besides a spare or a strike 
                else
                {
                    try
                    {
                        bowler.frameScores[i] = bowler.frameScores[i - 1] + bowler.frames[i, 0] + bowler.frames[i, 1];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        bowler.frameScores[i] = bowler.frames[i, 0] + bowler.frames[i, 1];
                    }

                }

                
            }

        }

        //Function to display results and winner
        private static void DisplayResults(Bowler first, Bowler second){
            Console.Clear();
            Console.Write("Frames:\t\t");
            for (int i = 0; i < 10; i++ )
            {
                Console.Write(i+1+"\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            PrintFrames(first);
            Console.WriteLine();
            Console.WriteLine();
            PrintFrames(second);
            Console.WriteLine();
            Console.WriteLine("{2} has a score of: {0}\n{3} has a score of: {1}", first.frameScores[9], second.frameScores[9], first.name, second.name);
            if (first.frameScores[9] > second.frameScores[9]){
                Console.Write("The winner is: {0}!! Congradulations!", first.name);
            }
            else if (first.frameScores[9] < second.frameScores[9])
            {
                Console.Write("The winner is: {0}!! Congradulations!!", second.name);
            }
            else {
                Console.Write("It is a tie!!!!");
            }
        }

        //Function to collect the open frame from the player if the frame is 10
        private static void FrameTen(ref Bowler bowler) {
            Console.Clear();
            int fOne = 0;
            int fTwo = 0;

            do
            {
                Console.Write("Enter the pins knocked down on the first roll for {0} for frame 10: ", bowler.name);
                try
                {
                    fOne = int.Parse(Console.ReadLine());
                }
                catch
                {
                    fOne = 10;
                }
                if (fOne > 10 || fOne < 0)
                {
                    Console.WriteLine("Error; your first roll cannot exceed 10 or be below 0!");
                }
            } while (fOne > 10);
            
            if (fOne <= 10){
                Console.Write("Enter the pins knocked down on the second roll: ");
               fTwo = int.Parse(Console.ReadLine());
            }

            //Chceking to see if both the first and second roll
            if(fOne == 10 && fTwo == 10 || fOne+fTwo==10){
                do
                {
                    Console.Write("Enter the pins knocked down on the next roll: ");
                    try{
                        bowler.extraFrame = int.Parse(Console.ReadLine());
                    }
                    catch{
                        bowler.extraFrame = 10;
                    }
                    if (bowler.extraFrame > 10){
                        Console.WriteLine("Error; your roll cannot exceed 10");
                    }
                } while (bowler.extraFrame > 10);
            }

            bowler.frames[9, 0] = fOne;
            bowler.frames[9, 1] = fTwo;         
        }
        
        //Function to print out the results from each frame and the score from each frame
        private static void PrintFrames(Bowler bowler){
            for (int i = 0; i < 2; i++ )
            {
                if (i ==0 ){    //Printing the name if the it is the first line
                    Console.Write(bowler.name+":\t\t");
                }
                for (int j = 0; j < 10; j++ )
                {   
                    if (i == 0)
                    {   //If it is the first line, then print the results from each frame
                        if (j < 9)
                        {
                            Console.Write(bowler.frames[j, 0] + " " + bowler.frames[j, 1]+"\t");
                        }
                        else if(j==9)
                        {
                            Console.Write(bowler.frames[j, 0] + " " + bowler.frames[j, 1] + " " + bowler.extraFrame);
                        }
                    }
                    else {  //Print frame score if it is the last line
                        if (j == 0)
                        {
                            Console.Write("\t\t" + bowler.frameScores[j]);
                        }
                        else
                        {
                            Console.Write("\t" + bowler.frameScores[j]);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
