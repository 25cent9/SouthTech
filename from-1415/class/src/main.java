import java.util.Scanner;

public class main {

	static int x;
	static boolean hi;
	static Scanner scanner = new Scanner(System.in);
	static int userInput;
	static String userName;
	static String userConcerns;
	
	static void favoriteNumber(int userInput) {
		if(userInput<=10){
			System.out.println("That's a pretty low number");
		}
		else{
			System.out.println("Woah that's a large number");
		}
	}


	public static void main(String[] args) {
		System.out.println("What is your name?");
		
		userName= scanner.nextLine();
		
		System.out.println("Hello,"+userName + " what is your favorite number");
		
		userInput= scanner.nextInt();
		
		
		System.out.println("So your name is "+ userName +" and your favorite number is "+userInput);
		favoriteNumber(userInput);
		
		System.out.println("Do you have any concerns about that?");
		
		userConcerns = TextIO.getln();
		
		System.out.println("Your concerns are:" +userConcerns);
		
	}

}
	