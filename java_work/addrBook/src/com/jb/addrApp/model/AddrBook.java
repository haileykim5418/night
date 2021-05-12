package com.jb.addrApp.model;

public class AddrBook {
	private String name;
	private int age;
	private String tel;
	private String address;
	private String email;
	
	public AddrBook(String name, int age, String tel, String address, String email) {
		super();
		this.name = name;
		this.age = age;
		this.tel = tel;
		this.address = address;
		this.email = email;
	}

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

	public String getTel() {
		return tel;
	}

	public void setTel(String tel) {
		this.tel = tel;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}
	

}
