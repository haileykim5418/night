package com.gh.app;

public class ClassStudent{
	private String name;
	private int age;
	private char gender;
	private String address;

	ClassStudent() {
		name = "";
		age = 0;
		gender = ' ';
		address = "";

	}

	//	ClassStudent(String a, int b, char c, String d) {
	//		name = a;
	//		this.age = b;
	//		gender = c;
	//		address = d;
	//	}




	public String getName() {
		return name;
	}

	public ClassStudent(String name, int age, char gender, String address) {
		// super();
		this.name = name;
		this.age = age;
		this.gender = gender;
		this.address = address;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public char getGender() {
		return gender;
	}

	public void setGender(char gender) {
		this.gender = gender;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public void showStudentInfo() {
		System.out.println("이름 : "+ name);
		System.out.println("나이 : "+ age);
		System.out.println("성별 : "+ gender);
		System.out.println("주소 : "+ address);
	}
}