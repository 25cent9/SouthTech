
public class Dog {
	
	private  int x;
	private  int y; 
	private final int width;
	private final int height;
	private final String path;
	private final String name;
	
	
	public Dog(int x, int y, int width,int height, String path, String name){
		
		this.setX(x);
		this.setY(y);
		this.width = width;
		this.height = height;
		this.path = path;
		this.name = name;
		
		
	}


	public int getX() {
		return x;
	}


	public void setX(int x) {
		this.x = x;
	}


	public int getY() {
		return y;
	}


	public void setY(int y) {
		this.y = y;
	}


	public int getWidth() {
		return width;
	}


	public String getPath() {
		return path;
	}


	public String getName() {
		return name;
	}


	public int getHeight() {
		return height;
	}
	
	
	
}
