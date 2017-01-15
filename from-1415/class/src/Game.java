
/**
 * @author 16NyibiziI1220
 *
 */
public class Game {
	static int counter;
	static int x=0;
	static int  player;

	public static void main(String[] args) {
		while (x==0){
			TextIO.putln("Give me ay number from 1-100 and I could guess it!");
			x=TextIO.getInt();
			if(x<=0){
				TextIO.putln("Give me a higher number please.");
				x=TextIO.getInt();
			}
			if(x>0 && x<10){
				TextIO.putln("Is your number between 1 and 10");
				player=TextIO.getInt();
				if(player==1){
					TextIO.putln("UO");
				}
			}
		}

	}

}
