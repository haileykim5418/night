package com.jb.addrApp.util;

import java.util.Random;

import com.jb.addrApp.model.AddrBook;

public class RandData {
	
	
	String name[] =  {"ȫ�浿", "��浿", "�̱浿", "�ڱ浿", "�ֱ浿"};
	int[] age = {10,20,30,40,50};
	String[] tel = {"010-1111-1111","010-2222-2222", "010-2222-3333","010-2222-4444", "010-2222-5555"};
	String[] addr = {"�뱸�� ���� �žϵ�","���ֽ� ���� �žϵ�", "����� ���� �žϵ�","������ ���� �žϵ�", "�λ�� ���� �žϵ�"};
	String[] email = {"hong@naver.com","kim@naver.com", "lee@naver.com","park@naver.com", "choi@naver.com"};
	
	Random r = new Random();
	
	public String getRName() {
		return name[r.nextInt(5)];
	}

	public int getRAge() {
		return age[r.nextInt(5)];
	}

	public String getRTel() {
		return tel[r.nextInt(5)];
	}


	public String getRAddr() {
		return addr[r.nextInt(5)];
	}

	public String getREmail() {
		return email[r.nextInt(5)];
	}


	public AddrBook getABook() {
		AddrBook ab = new AddrBook(getRName(), getRAge(), getRTel(), getRAddr(), getREmail());
		return ab;
	}
}
