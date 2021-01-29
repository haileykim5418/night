package thread0127;

public class Thread1 {

	public static void main(String[] args) throws InterruptedException {
		MyThread t1 = new MyThread("T1");
		MyThread t2 = new MyThread("T2");
		t1.start(); //t1스레드 객체 동작 시작
		t2.start();
	for(int i=0;i<10;i++) {
		System.out.println("main스레드 동작중");
		Thread.sleep(1000);  //출력하고 0.1초 대기
	}
		System.out.println("메인 스레드 종료");
		
	}

}
class MyThread extends Thread{ //Thread가 부모클래스. 즉 부모클래스에서 쓰던걸 다 상속받겠다  
	String str;
	public MyThread(String str) {
		this.str = str;
	}
	
	//오버로딩:중복정의
	//오버라이딩:부모의것을 재정의
	//work(작업):스레드로 동작하는 부분
	@Override
	public void run() {
		for(int i=0; i<10; i++) {
			System.out.println(str);
			//1000ms = 1초
			try {
				Thread.sleep(100);//잠시 딜레이
			} catch (InterruptedException e) {
				
				
				e.printStackTrace();
			} 
			
			
		}
		System.out.println("작업 스레드 종료");
	}
}