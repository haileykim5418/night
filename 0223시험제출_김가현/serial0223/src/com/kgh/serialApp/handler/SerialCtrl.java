package com.kgh.serialApp.handler;

import java.util.Scanner;

import com.kgh.serialApp.util.Menu;

import jssc.SerialPort;
import jssc.SerialPortException;

public class SerialCtrl {
	public static final int MENU_TV_ON = 1;
	public static final int MENU_TV_OFF = 2;
	public static final int MENU_HEATER_ON = 3;
	public static final int MENU_CLEANER_ON = 4;
	public static final int MENU_GUEST_LOGOUT = 5;
	public static final int MENU_ADMIN_LOGOUT = 7;
	public static final int MENU_GUEST_EXIT = 6;	
	public static final int MENU_ADMIN_EXIT = 8;
	public static final int MENU_EMARGENCY = 5;

	static final int CMD_TV_ON = '1';
	static final int CMD_TV_OFF = '2';
	static final int CMD_HEATER_ON = '3';
	static final int CMD_CLEANER_ON = '4';
	
	
	public static boolean adminWork(Scanner s, 
			SerialPort serial) {
		
		Menu m = new Menu();
		
			switch (m.adminMenu(s)) {
			case MENU_TV_ON:
				System.out.println("TV 켜기");
				try {
					serial.writeInt(CMD_TV_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case MENU_TV_OFF:
				System.out.println("TV 끄기");
				try {
					serial.writeInt(CMD_TV_OFF);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case MENU_HEATER_ON:
				System.out.println("보일러 가동");
				try {
					serial.writeInt(CMD_HEATER_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case MENU_CLEANER_ON:
				System.out.println("세탁기 가동");
				try {
					serial.writeInt(CMD_CLEANER_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case MENU_EMARGENCY:
				System.out.println("긴급 정지");
				try {
					serial.closePort();
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;			
			case MENU_ADMIN_LOGOUT:
				System.out.println("관리자 로그 아웃");
				return false;
			case MENU_ADMIN_EXIT:
				System.out.println("프로그램 종료");
				s.close();
				System.exit(0);
			}
			return true;
		}
		
		public static boolean guestWork(Scanner s, 
				SerialPort serial) {
			
			Menu m = new Menu();
			switch (m.guestMenu(s)) {
			case MENU_TV_ON:
				System.out.println("TV 켜기");
				try {
					serial.writeInt(CMD_TV_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case MENU_TV_OFF:
				System.out.println("TV 끄기");
				try {
					serial.writeInt(CMD_TV_OFF);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case MENU_HEATER_ON:
				System.out.println("보일러 가동");
				try {
					serial.writeInt(CMD_HEATER_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case MENU_CLEANER_ON:
				System.out.println("세탁기 가동");
				try {
					serial.writeInt(CMD_CLEANER_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case MENU_GUEST_LOGOUT:
				System.out.println("사용자 로그 아웃");
				return false;
			case MENU_GUEST_EXIT:
				System.out.println("프로그램 종료");
				s.close();
				System.exit(0);
			}
			return true;
		}
}
