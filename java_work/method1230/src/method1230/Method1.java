package method1230;

public class Method1 {
	//메인이 시작점
	public static void main(String[] args) {
		System.out.println("func() 호출전");
		func(); //메소드 사용(호출)
		System.out.println("func()호출후");
		
		System.out.println("");
		for(int i=0;i<5;i++) {
			func();
		}
	}
	
	//메소드 선언(정의)
	public static void func() {
		System.out.println("메소드 사용");
	}
}
