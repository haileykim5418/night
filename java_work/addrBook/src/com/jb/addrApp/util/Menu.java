package com.jb.addrApp.util;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;
import com.jb.addrApp.model.AddrBook;

public class Menu {
	// static�� ���� ��������� ��ü�� �������� �ʰ� ������ �� �ִ�.
	// �ѹ� �����ΰ� �������� ��� ����ϰ� �����ϱ� ����
	// ���ο����� �������� �ܺο����� ���� ���� public ����
	public static final int CREATE_TABLE = 1;
	public static final int DEL_TABLE = 2;
	public static final int INSERT_DATA = 3;
	public static final int RANDOM_DATA = 4;
	public static final int VIEW_DATA = 5;
	public static final int UPDATE_DATA = 6;
	public static final int DEL_DATA = 7;
	public static final int MAIN_EXIT = 8;
	
	public static final int UP_NAME =1;
	public static final int UP_AGE =2;
	public static final int UP_TEL =3;
	public static final int UP_ADDR =4;
	public static final int UP_EMAIL =5;
		
	public int mainMenu(Scanner s) {
		System.out.println("----------------------");
		System.out.println("MySQL DB ���� v1.0");
		System.out.println("----------------------");
		System.out.println("1. ���̺� ����");
		System.out.println("2. ���̺� ����");
		System.out.println("3. ������ �߰�");
		System.out.println("4. ���� ������");
		System.out.println("5. ������ ����");
		System.out.println("6. ������ ����");
		System.out.println("7. ������ ����");
		System.out.println("8. ����");
		System.out.print("���� �޴� ���� : ");
		return s.nextInt();
	}
	

	public AddrBook addMenu(Scanner s) {
		System.out.println("----------------------");
		System.out.println("������ �߰� �޴�");
		System.out.println("----------------------");
		System.out.print("�̸� : ");
		String name = s.next();
		System.out.print("���� : ");
		int age = s.nextInt();
		System.out.print("��ȭ : ");
		String tel = s.next();
		
		//�ּ� ����� �����߻� �����
		BufferedReader br = 
				new BufferedReader(new InputStreamReader(System.in));
		System.out.print("�ּ� : ");
		String addr = null;
		try {
			addr = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		
		System.out.print("���� : ");
		String email = s.next();
		return new AddrBook(name, age, tel, addr, email);
	}
	
	public int UpdateMenu(Scanner s) {
		System.out.println("----------------------");
		System.out.println("������ �����ϱ�");
		System.out.println("----------------------");
		System.out.println("1.�̸�");
		System.out.println("2.����");
		System.out.println("3.��ȣ");
		System.out.println("4.�ּ�");
		System.out.println("5.����");
		System.out.println("----------------------");
		System.out.print("������ �׸��� �����ϼ��� : ");
			
		return s.nextInt();
	}
	
	
}
