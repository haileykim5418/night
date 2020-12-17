package loopTest1216;

public class Loop1 {

	public static void main(String[] args) {
		//i가 0부터 시작해서 5가 되기 전까지 1씩 증가
		for (int i = 0; i<5; i++) {
			System.out.println("반복 횟수: " + i);
			//1부터 시작하고싶으면 "반복횟수 :" + (i+1)
		}
		for (int j=5; j>0; j--) {
			System.out.println("반복 횟수:" + j);
		}
	}

}
