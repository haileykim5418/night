package assign;

import java.util.Scanner;

public class Ass {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		  int num = 0;
	      int num2 = 0;
	      int num3 = 0;
	      int num4 = 0;
	      
	      num = 500;
	      num2 = 100;
	      num3 = 50;
	      num4 = 10;
	      
	      Scanner s = new Scanner(System.in);
	      
	      System.out.print("ÁöÆó : " );
	      int put = s.nextInt();
	      
	      System.out.println("------------------------");
	      System.out.println("  µ¿Àü ±³È¯±â ÇÁ·Î±×·¥ 1.0   ");
	      System.out.println("------------------------");
	      System.out.println("500¿øÀÇ °¹¼ö : " + put/num);
	      System.out.println("100¿ø °¹¼ö : " + (put%num)/num2);
	      System.out.println("50¿ø °¹¼ö : " +  ((put%num)%num2)/num3);
	      System.out.println("10¿ø °¹¼ö : " + ((put%num)%num2)%num3/num4);
	      System.out.println("¹Ù²ÙÁö ¸øÇÑ ÀÜµ· : " + ((put%num)%num2)%num3%num4/1);
	      System.out.println("------------------------");
	         
	      s.close();
	      
	}

}
