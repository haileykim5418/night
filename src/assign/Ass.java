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
	      
	      System.out.print("���� : " );
	      int put = s.nextInt();
	      
	      System.out.println("------------------------");
	      System.out.println("  ���� ��ȯ�� ���α׷� 1.0   ");
	      System.out.println("------------------------");
	      System.out.println("500���� ���� : " + put/num);
	      System.out.println("100�� ���� : " + (put%num)/num2);
	      System.out.println("50�� ���� : " +  ((put%num)%num2)/num3);
	      System.out.println("10�� ���� : " + ((put%num)%num2)%num3/num4);
	      System.out.println("�ٲ��� ���� �ܵ� : " + ((put%num)%num2)%num3%num4/1);
	      System.out.println("------------------------");
	         
	      s.close();
	      
	}

}
