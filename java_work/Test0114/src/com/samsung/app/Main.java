package com.samsung.app;

import java.util.Random;

public class Main {

	public static void main(String[] args) {
		
		final String name[] = {"홍길동","김길동","박길동","이길동","최길동"};
		final int age[] = {20,25,30,35,40};
		final char gender[] = {'남','여'};
		final String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동","부산시 동구 신암4동","인천시 동구 신암4동","광주시 동구 신암4동"};
		
		Student student = new Student();
		student.setName("홍길동");
		System.out.println(student.getName());
	
 

		Student arr[] = new Student[10];
		Random rand = new Random(); 
		
		for (int i = 0; i < arr.length; i++) {
			arr[i]= new Student(name[rand.nextInt(5)], age[rand.nextInt(5)], gender[rand.nextInt(2)], address[rand.nextInt(5)]);
		}
		for (int i = 0; i < arr.length; i++) {
			arr[i].showStudentInfo();
			System.out.println("-------------------------");
		}
		
 
 
	}

}
