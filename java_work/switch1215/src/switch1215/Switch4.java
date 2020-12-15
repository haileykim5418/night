package switch1215;

public class Switch4 {

	public static void main(String[] args) {
		int time = (int)(Math.random()*4)+8;
		//Math라는 수학 클래스
		//랜덤한 값을 1~4사이에서 임의로 뽑아줘
		System.out.println("현재 시간: " + time);
		switch (time) {
		case 8:
			System.out.println("출근");
		case 9:
			System.out.println("회의");
		case 10:
			System.out.println("업무");
		default :
			System.out.println("출장");
		}
		
	}

}
