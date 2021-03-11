package com.lg.addrApp.util;

import java.util.Random;

import com.lg.addrApp.model.AddrBook;

public class RandData {
	static String[] name = {"홍길동","김길동","박길동","최길동","이길동"};
	static int[] age = {100,200,300,400,500};
	static String[] tel = {"010-1111-1111","010-1111-1112","010-1111-1113","010-1111-1114","010-1111-1115"};
	static String[] address = {"대구","서울","인천","부산","대전"};
	static String[]email = {"hong@naver.com","kim@naver.com","park@naver.com","choi@naver.com","lee@naver.com"};
	
	Random r = new Random();
	
	public String getRName() { //클래스 사용하지 않고 하는 방법
		return name[r.nextInt(5)];
	}
	public int getRAge() {
		return age[r.nextInt(5)];
	}
	public String getRTel() {
		return tel[r.nextInt(5)];
	}
	public String getRNAddress() {
		return address[r.nextInt(5)];
	}
	public String getREmail() {
		return email[r.nextInt(5)];
	}
	
	public AddrBook getABook() {//클래스 사용하는법
		return new AddrBook(getRName(),getRAge(),getRTel(),getRNAddress(),getREmail());				
	}
}
