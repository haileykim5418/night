package arr1223;

import java.io.BufferedOutputStream;
import java.util.Scanner;

public class Test7 {

	public static void main(String[] args) {
		final String last[] = {"김","박","이","최","장"};
		final String first[] = {"바","사","아","자","차"};
		final String mid[] = {"가","나","다","라","마"};
		final String[] fullName = new String[50];
		
		Scanner s = new Scanner(System.in);
		while (true) {
		System.out.println("--------------------");
		System.out.println("파일 제어 프로그램");
		System.out.println("--------------------");
		System.out.println("1.이름 생성하여 파일에 저장");
		System.out.println("2.파일에서 이름 읽어오기");
		System.out.println("3.프로그램 종료");
		System.out.println("--------------------");
		System.out.print("메뉴 선택 : ");
		int menu = s.nextInt();
		switch (menu) {
			case 1:
				BufferedOutputStream bs = null;
				bs = new BufferedOutputStream(new
						FileOutputStream(FileName));
			
			for(int i=0; i<50; i++) {
				int rand = (int)(Math.random()*5);
				fullName[i] = last[(int)(Math.random()*5)]+
						mid[(int)(Math.random()*5)]+
						first[(int)(Math.random()*5)];
				bs.write(fullName[i].getByte());
				bs.write("/".getBytes());
				
			}
			bs.close();
			System.out.println("파일 저장 성공");
				break;
			case 2:
				String str="홍길동/김길동/최길동";
				StringTokenizer stk=
				new StringTokenizer(stk,"/");
				while(stk.hasMoreTokens()) {
					System.out.println(stk.nextToken);
				}
				break;
			case 3:
				s.close();
				System.exit(0);
				break;
			default:
				System.out.println("잘못된 메뉴 선택");
			break;
		}
				
		
	}

}
}
