package thread0127;

import java.awt.Toolkit;

public class Thread3 {

	public static void main(String[] args) {
		Runnable task = new BeepTask();
		Thread th = new Thread(task);
		th.start();
	}

}
//runnable인터페이스를 사용
//인터페이스는 반드시 오버라이딩 필요
class BeepTask implements Runnable{

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