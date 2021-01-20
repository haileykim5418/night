package method1230;

public class Method5 {



		public static void divide (int num1,int num2)	{
			if(num2 == 0) { //if(!num2)
				System.out.println("0으로 나눌수 없습니다.");
				//void method 에서 return을 사용하면 메소드 종료
				//sys .exit프로그램 강제 종료 현재 진행죽인 메소드 탈출
				return;
			}
			System.out.println("나눗셈 결과: " +(num1/num2));
			
			}
		public static void main(String[] args) {
			divide(4,2);
			divide(4,0);
			System.out.println("메인() 종료");
		
		}
	 
	}

