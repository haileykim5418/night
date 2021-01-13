package com.gh.app;

import java.util.Random;

public class MainStudent {
	final static String name[] = {"홍길동","김길동","박길동","이길동","최길동"};
	final static int age[] = {20,25,30,35,40};
	final static char gender[] = {'남','여'};
	final static String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동","부산시 동구 신암4동","인천시 동구 신암4동","광주시 동구 신암4동"};
	
	

	public static void main(String[] args) {
		

	
	
		
	Student a [] = new Student[10];
		
	Random rand = new Random();
	
	for (int i = 0; i < a.length; i++) {
		int x = rand.nextInt(5);
		a[i] = new Student(name[x], age[x], gender[x], address[x]);
	}
		
	}
}
