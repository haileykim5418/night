package serial0216_1;

import java.util.Scanner;

//라이브러리 임포트
import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain2 {
	static final int TV_ON = 1;
	static final int TV_OFF = 2;
	static final int HOTTER_ON = 3;
	static final int CLEANER_ON = 4;
	static final int PROGRAM_EXIT = 5;
	
	static final int CMD_TV_ON = '1';
	static final int CMD_TV_OFF = '0';
	static final int CMD_HOTTER_ON = '2';
	static final int CMD_CLEANER_ON = '3';

	public static int getMenu(Scanner s) {
		System.out.println("----------------------------");
		System.out.println("      스마트 홈 제어 v1.0       ");
		System.out.println("----------------------------");
		System.out.println("1.TV 켜기");
		System.out.println("2.TV 끄기");
		System.out.println("3.보일러 동작");
		System.out.println("4.세탁기 동작");
		System.out.println("5.종료");
		System.out.println("----------------------------");
		System.out.print("메뉴 선택: ");
//		int menu = s.nextInt()
//		return menu;  이 두줄이 밑에 한줄과 같은의미
		return s.nextInt();
	}
	
	public static SerialPort initial() {
		//사용가능한 포트정보 받아옴(케이블이 장치와 연결되어있으면 열려있다는 의미)
		String[] portName = SerialPortList.getPortNames();
		      for (int i=0; i<portName.length; i++) {
		         System.out.println("사용가능 포트: " + portName[i]);
		      }
		      //포트네임부분에 내가 연결되어있는 포트 연결해도됨 ex.COM5 
		      SerialPort serialPort = new SerialPort(portName[0]);
		      
		      try {
		         serialPort.openPort();
		         serialPort.setParams(SerialPort.BAUDRATE_9600,
		               SerialPort.DATABITS_8 ,
		               SerialPort.STOPBITS_1,
		               SerialPort.PARITY_NONE);
		         System.out.println("포트 사용 가능!");
		      } catch (SerialPortException e) {
		         e.printStackTrace();
		      }
		      
		      return serialPort;
		      
	}

	public static void main(String[] args) {  
		Scanner s = new Scanner(System.in);
		SerialPort serial = initial();
		while (true) {
			switch (getMenu(s)) {
			case TV_ON:
				System.out.println("TV ON");
				 try {
					serial.writeInt(CMD_TV_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case TV_OFF:
				System.out.println("TV OFF");
				 try {
					serial.writeInt(CMD_TV_OFF);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case HOTTER_ON:
				System.out.println("보일러 가동");
				 try {
					serial.writeInt(CMD_HOTTER_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case CLEANER_ON:
				System.out.println("세탁기 가동");
				 try {
					serial.writeInt(CMD_CLEANER_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case PROGRAM_EXIT:
				System.out.println("프로그램 종료");
				s.close();
				System.exit(0);
				break;
			}
		}
	}
}
