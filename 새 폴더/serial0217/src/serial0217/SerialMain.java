package serial0217;

import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain {

	public static final String ADMIN_ID = "admin";
	public static final String GUEST_ID = "guest";
	public static final String ADMIN_PW = "1234";
	public static final String GUEST_PW = "1111";
	public static final String ADMIN_MODE = "admin_mode";
	public static final String GUEST_MODE = "guest_mode";
	public static final String OTHER_MODE = "other_mode";

	public static final int TV_ON = 1;
	public static final int TV_OFF = 2;
	public static final int HOTTER_ON = 3;
	public static final int CLEANER_ON = 4;
	public static final int EMG = 5;
	public static final int GUEST_LOGOUT = 5;
	public static final int ADMIN_LOGOUT = 6;
	public static final int GUEST_EXIT = 6;
	public static final int ADMIN_EXIT = 7;

	static final int CMD_TV_ON = '1';
	static final int CMD_TV_OFF = '0';
	static final int CMD_HOTTER_ON = '2';
	static final int CMD_CLEANER_ON = '3';

	public static String login(Scanner s) {
		System.out.println("-------------------------");
		System.out.println("스마트홈 제어 로그인");
		System.out.println("-------------------------");
		System.out.print("ID:");
		String id = s.next();
		System.out.print("PW:");
		String passwd = s.next();
		String mode;

		if (id.equals(ADMIN_ID) && passwd.equals(ADMIN_PW)) {
			mode = ADMIN_MODE;
		} else if (id.equals(GUEST_ID) && passwd.equals(GUEST_PW)) {
			mode = GUEST_MODE;
		} else {
			mode = OTHER_MODE;
		}

		return mode;
	}

	public static int adminMenu(Scanner s) {

		System.out.println("----------------------------");
		System.out.println("      스마트 홈 제어 관리자       ");
		System.out.println("----------------------------");
		System.out.println("1.TV 켜기");
		System.out.println("2.TV 끄기");
		System.out.println("3.보일러 동작");
		System.out.println("4.세탁기 동작");
		System.out.println("5.긴급정지");
		System.out.println("6.로그아웃");
		System.out.println("6.종료");
		System.out.println("----------------------------");
		System.out.print("메뉴 선택: ");
		return s.nextInt();
	}

	public static int guestMenu(Scanner s) {
		System.out.println("----------------------------");
		System.out.println("      스마트 홈 제어 사용자      ");
		System.out.println("----------------------------");
		System.out.println("1.TV 켜기");
		System.out.println("2.TV 끄기");
		System.out.println("3.보일러 동작");
		System.out.println("4.세탁기 동작");
		System.out.println("5.로그아웃");
		System.out.println("6.종료");
		System.out.println("----------------------------");
		System.out.print("메뉴 선택: ");
		return s.nextInt();
	}

	public static boolean guestWork(Scanner s, SerialPort serial) {
		switch (adminMenu(s)) {
		case TV_ON:
			System.out.println("TV 켜기");
			try {
				serial.writeInt(CMD_TV_ON);
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			break;
		case TV_OFF:
			System.out.println("TV 끄기");
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
		case GUEST_LOGOUT:
			System.out.println("사용자 로그 아웃");
			return false;
		case GUEST_EXIT:
			System.out.println("프로그램 종료");
			s.close();
			System.exit(0);
		}
		return true;
	}

	public static boolean adminWork(Scanner s, SerialPort serial) {
		switch (adminMenu(s)) {
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
		case EMG:
			System.out.println("긴급 정지");
			try {
				serial.writeInt(EMG);
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			break;
		case ADMIN_LOGOUT:
			System.out.println("관리자 로그아웃");
			return false;
		case ADMIN_EXIT:
			System.out.println("프로그램 종료");
			s.close();
			System.exit(0);
		}
		return true;
	}

	public static SerialPort initial() {
		// 사용가능한 포트정보 받아옴(케이블이 장치와 연결되어있으면 열려있다는 의미)
		String[] portName = SerialPortList.getPortNames();
		for (int i = 0; i < portName.length; i++) {
			System.out.println("사용가능 포트: " + portName[i]);
		}
		// 포트네임부분에 내가 연결되어있는 포트 연결해도됨 ex.COM5
		SerialPort serialPort = new SerialPort(portName[0]);

		try {
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
//			System.out.println("포트 사용 가능!");
		} catch (SerialPortException e) {
			e.printStackTrace();
		}

		return serialPort;

	}

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		SerialPort serial = initial();

		while (true) {
			String mode = login(s);
			if (mode.equals(ADMIN_MODE)) {
				while (true) {
					if (adminWork(s, serial) == false) {
						break;
					}
				}
			} else if (mode.equals(GUEST_MODE)) {
				while (true) {
					if (!guestWork(s, serial)) {
						break;
					}
				}
			} else

			{
				System.out.println("ID 또는 비번이 잘못되었습니다.");
				System.out.println("다시 입력하세요.");
			}

		}
	}
}
