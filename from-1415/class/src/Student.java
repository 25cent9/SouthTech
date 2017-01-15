
public class Student {

	public String name;
	public double test1, test2, test3;
	
	public double getAverage(){
		return(test1+test2+test3)/3;
	}
	
	static Student std, std1, std2, std3;{
	
	std= new Student();
	 
	std.name = "John";
	

}
	
	public static void main(String [] args){
		System.out.println(std.name);
	}

}




