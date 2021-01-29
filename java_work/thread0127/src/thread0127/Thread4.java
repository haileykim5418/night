package thread0127;

import java.awt.Toolkit;

public class Thread4 {

	   public static void main(String[] args) {
	      // TODO Auto-generated method stub
	      MovieThread th =new MovieThread();
	      th.start();
	      
	      for(int i=0;i<5;i++) {
	         System.out.println("메인쓰레드 동작 "+i);
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

	class MovieThread extends Thread{
	//무한 루프   
	   public void run() {
	      while(true) {
	         System.err.println("동영상 재생");
	         if(isInterrupted()) {
	         System.out.println("인터럽트 신호받음");
	         break;
	      }
	         try {
	            Thread.sleep(500);
	         } catch (InterruptedException e) {
	            // TODO Auto-generated catch block
	            System.out.println("인터럽터 신호받음2");
	            e.printStackTrace();
	            break;
	         }
	      }
	      System.out.println("작업 스레드 종료");
	   }
	}