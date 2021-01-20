package com.gh.stApp;

import java.util.Random;

public class stAppMain {

	public static void main(String[] args) {
	//7번 
		final String name[] = {"홍길동","김길동","박길동","이길동","최길동"};
		final int age[] = {20,25,30,35,40};
		final char gender[] = {'남','여'};
		final String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동","부산시 동구 신암4동","인천시 동구 신암4동","광주시 동구 신암4동"};
		
		
		Student st[] = new Student[10]; //비어있는 배열
		Random r = new Random();
		
		//비어있는 배열에 요소 입력하도록
		for (int i=0; i<st.length; i++) {
			System.out.println("번호: "+(i+1));
		
		st[i] = new Student(name[r.nextInt(5)], age[r.nextInt(5)], gender[r.nextInt(2)], address[r.nextInt(5)]);
		st[i].showStudentInfo();
		}
	}

}
