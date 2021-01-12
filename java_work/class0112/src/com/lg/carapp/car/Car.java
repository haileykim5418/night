package com.lg.carapp.car;

public class Car {
	private String model;
	private int year;
	private String money;
	
	//클래스 내부 정보 초기화
	public Car() {
		model="k7";
		year = 2020;
		money = "4천만원";
		
		System.out.println("기본 생성자 생성");
		showCarInfo();
	
	}
	//오버로딩.중복정의
	//반드시 매개변수 개수가 다름
	//매개변수 타입이 다름
	
	public Car(String model, int year, String money) {
		super();
		this.model = model;
		this.year = year;
		this.money = money;
	}

	public String getModel() {
		return model;
	}
	public void setModel(String model) {
		this.model = model;
	}
	public int getYear() {
		return year;
	}
	public void setYear(int year) {
		this.year = year;
	}
	public String getMoney() {
		return money;
	}
	public void setMoney(String money) {
		this.money = money;
	}
	public void showCarInfo() {
		System.out.println("모델:"+model);
		System.out.println("연식:"+year);
		System.out.println("가격:"+money);
		System.out.println("---------------------");
		
	}
}
