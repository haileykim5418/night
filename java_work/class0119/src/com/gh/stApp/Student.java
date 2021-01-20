package com.gh.stApp;

public class Student {
//변수=속성
	
	//3번
	private String name;
	private int age;
	private char gender;
	private String address;
	
	//4번 속성(변수) 생성자 생성(3번의 특성을 가지고 객체를 생성하면서 정보를 인스턴스 변수들에게 전달하겠다)
	public Student(String name, int age, char gender, String address) {
		super();  //부모클래스 object
		this.name = name;
		this.age = age;
		this.gender = gender;
		this.address = address;
	}

	//5번 get set
	public String getName() {
		return name;
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
	//6번 모든 변수들(속성정보) 출력하는 메소드
	public void showStudentInfo() {
		System.out.println("이름: " + name);
		System.out.println("나이: " + age);
		System.out.println("성별: " + gender);
		System.out.println("주소: " + address);
		System.out.println("-----------------");
	}
}

