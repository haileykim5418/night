import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
	Scanner s = new Scanner(System.in);
	System.out.print("숫자입력1:");
	int num = s.nextInt();
	System.out.print("숫자입력2:");
	int num2 = s.nextInt();
	
	
	if(num>num2) {
		System.out.println(">");
	}
	else if(num<num2) {
		System.out.println("<");
	}
	else {
		System.out.println("==");
	}
	
	}

}
