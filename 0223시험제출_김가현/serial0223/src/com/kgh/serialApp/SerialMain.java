package com.kgh.serialApp;

import java.util.Scanner;

import com.kgh.serialApp.handler.SerialCtrl;
import com.kgh.serialApp.network.MySerial;
import com.kgh.serialApp.util.Menu;

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
	
	 public static String login(Scanner s) {
		 
			System.out.println("-----------------");
			System.out.println("스마트홈 제어 로그인");
			System.out.println("-----------------");
			System.out.print("ID: ");
			String id = s.next();
			System.out.print("PW: ");
			String passwd = s.next();
			String mode;

			if (id.equals(ADMIN_ID) && 
				passwd.equals(ADMIN_PW)) {
				mode = ADMIN_MODE;
			} else if (id.equals(GUEST_ID) && 
				passwd.equals(GUEST_PW)) {
				mode = GUEST_MODE;
			} else {
				mode = OTHER_MODE;
			}
			return mode;
		}
	 
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		MySerial ms = new MySerial();	
		SerialPort serial = ms.initSerial();
		
		SerialCtrl sc = new SerialCtrl();

		
		while (true) {
			String mode = login(s);
			if (mode.equals(ADMIN_MODE)) {
				while (true) {
					if (sc.adminWork(s, serial)==false) {
						break;
					}
				}
			}
			else if (mode.equals(GUEST_MODE)) {
				while (true) {
					if (!sc.guestWork(s, serial)) {
						break;
					}
				}
			}
			else {
				System.out.println("ID 또는 비번이 잘못되었습니다.");
				System.out.println("다시 입력하세요.");
			}
		}
	}

}



