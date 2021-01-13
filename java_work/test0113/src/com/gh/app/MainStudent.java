package com.gh.app;

import java.util.Random;

public class MainStudent {
	
	static final String name[] = {"홍길동","김길동","박길동","이길동","최길동"};
	static final int age[] = {20,25,30,35,40};
	static final char gender[] = {'남','여'};
	static final String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동","부산시 동구 신암4동","인천시 동구 신암4동","광주시 동구 신암4동"};

	public static void main(String[] args) {
//		int a0;
//		int a1;
//		int a2;
//		int a3;
//		int a4;
//		
//		int a[];
//		a = new int[5];

//	    int a[] = new int[5];
//		
//		a[0] = 10;
//		a[1] = 2;
//		a[2] = 3;
//		
//		ClassStudent b0;
//		ClassStudent b1;
//		ClassStudent b2;
//		ClassStudent b3;
//		ClassStudent b4;
//		
//		ClassStudent b[];
//		b = new ClassStudent[5];
//		
//		
//		b[0] = new ClassStudent();
//		b[0].setAddress("대구");
//		b[0].getName();
		
		ClassStudent x[] = new ClassStudent[10];
		   
//		for (int i = 0; i < x.length; i++) {
//			x[i] = new ClassStudent();
//		}
		
		Random r = new Random();
		// r.nextInt(5)
		for (int i = 0; i < x.length; i++) {
//			x[i].setName(name[r.nextInt(5)]);
//			x[i].setGender(gender[r.nextInt(2)]);
//			x[i].setAge(age[r.nextInt(5)]);
//			x[i].setAddress(address[r.nextInt(5)]);
			x[i] = new ClassStudent(name[r.nextInt(5)], age[r.nextInt(5)], gender[r.nextInt(2)], address[r.nextInt(5)]);
		}
		
//		x[0].showStudentInfo();
//		x[1].showStudentInfo();
//		x[2].showStudentInfo();
		for (int i = 0; i < x.length; i++) {
			x[i].showStudentInfo();
		}
		
		x[9].setName("전우치");
		x[9].setAge(24);
		x[9].setGender('남');
		x[9].setAddress("조선 한양인근 두메산골");
		
		x[9].showStudentInfo();
	}

	public void random() {
		Random r = new Random();
		String str = name[r.nextInt(name.length)];
		int	tmpInt = age[r.nextInt(age.length)];
//			gender = r.next(101);
//			address = r.next(101);
//			
	}
}
