package thread0127;

import java.awt.Toolkit;

public class Thread2 {

	public static void main(String[] args) {
		BeepThread beep = new BeepThread();
		//작업 스레드 시작
		beep.start();
		
		for(int i=0;i<5;i++) {
			System.out.println("메인스레드 동작:"+i);
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		System.out.println("메인 스레드 종료");
	}

}

class BeepThread extends Thread{
	//스레드 사용하기 위해서는 run()이라는 메소드를 반드시 오버라이딩 필요
	//부모클래스인 Thread 상속
	@Override
	public void run() {
		Toolkit toolkit = Toolkit.getDefaultToolkit();
		for(int i=0;i<5;i++) {
			toolkit.beep(); //소리 나는거
			System.out.println("작업스레드: "+i);
			try {
				Thread.sleep(2000);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		System.out.println("작업 스레드 종료");
	} 
	
}