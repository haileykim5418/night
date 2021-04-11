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
		System.out.println("�뒪留덊듃�솃 �젣�뼱 濡쒓렇�씤");
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
		System.out.println("      �뒪留덊듃 �솃 �젣�뼱 愿�由ъ옄       ");
		System.out.println("----------------------------");
		System.out.println("1.TV 耳쒓린");
		System.out.println("2.TV �걚湲�");
		System.out.println("3.蹂댁씪�윭 �룞�옉");
		System.out.println("4.�꽭�긽湲� �룞�옉");
		System.out.println("5.湲닿툒�젙吏�");
		System.out.println("6.濡쒓렇�븘�썐");
		System.out.println("6.醫낅즺");
		System.out.println("----------------------------");
		System.out.print("硫붾돱 �꽑�깮: ");
		return s.nextInt();
	}

	public static int guestMenu(Scanner s) {
		System.out.println("----------------------------");
		System.out.println("      �뒪留덊듃 �솃 �젣�뼱 �궗�슜�옄      ");
		System.out.println("----------------------------");
		System.out.println("1.TV 耳쒓린");
		System.out.println("2.TV �걚湲�");
		System.out.println("3.蹂댁씪�윭 �룞�옉");
		System.out.println("4.�꽭�긽湲� �룞�옉");
		System.out.println("5.濡쒓렇�븘�썐");
		System.out.println("6.醫낅즺");
		System.out.println("----------------------------");
		System.out.print("硫붾돱 �꽑�깮: ");
		return s.nextInt();
	}

	public static boolean guestWork(Scanner s, SerialPort serial) {
		switch (adminMenu(s)) {
		case TV_ON:
			System.out.println("TV 耳쒓린");
			try {
				serial.writeInt(CMD_TV_ON);
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			break;
		case TV_OFF:
			System.out.println("TV �걚湲�");
			try {
				serial.writeInt(CMD_TV_OFF);
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			break;
		case HOTTER_ON:
			System.out.println("蹂댁씪�윭 媛��룞");
			try {
				serial.writeInt(CMD_HOTTER_ON);
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			break;
		case CLEANER_ON:
			System.out.println("�꽭�긽湲� 媛��룞");
			try {
				serial.writeInt(CMD_CLEANER_ON);
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			break;
		case GUEST_LOGOUT:
			System.out.println("�궗�슜�옄 濡쒓렇 �븘�썐");
			return false;
		case GUEST_EXIT:
			System.out.println("�봽濡쒓렇�옩 醫낅즺");
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
			System.out.println("蹂댁씪�윭 媛��룞");
			try {
				serial.writeInt(CMD_HOTTER_ON);
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			break;
		case CLEANER_ON:
			System.out.println("�꽭�긽湲� 媛��룞");
			try {
				serial.writeInt(CMD_CLEANER_ON);
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			break;
		case EMG:
			System.out.println("湲닿툒 �젙吏�");
			try {
				serial.writeInt(EMG);
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			break;
		case ADMIN_LOGOUT:
			System.out.println("愿�由ъ옄 濡쒓렇�븘�썐");
			return false;
		case ADMIN_EXIT:
			System.out.println("�봽濡쒓렇�옩 醫낅즺");
			s.close();
			System.exit(0);
		}
		return true;
	}

	public static SerialPort initial() {
		// �궗�슜媛��뒫�븳 �룷�듃�젙蹂� 諛쏆븘�샂(耳��씠釉붿씠 �옣移섏� �뿰寃곕릺�뼱�엳�쑝硫� �뿴�젮�엳�떎�뒗 �쓽誘�)
		String[] portName = SerialPortList.getPortNames();
		for (int i = 0; i < portName.length; i++) {
			System.out.println("�궗�슜媛��뒫 �룷�듃: " + portName[i]);
		}
		// �룷�듃�꽕�엫遺�遺꾩뿉 �궡媛� �뿰寃곕릺�뼱�엳�뒗 �룷�듃 �뿰寃고빐�룄�맖 ex.COM5
		SerialPort serialPort = new SerialPort(portName[0]);

		try {
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
//			System.out.println("�룷�듃 �궗�슜 媛��뒫!");
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
				System.out.println("ID �삉�뒗 鍮꾨쾲�씠 �옒紐삳릺�뿀�뒿�땲�떎.");
				System.out.println("�떎�떆 �엯�젰�븯�꽭�슂.");
			}

		}
	}
}
