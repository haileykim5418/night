
public class Student03 {
private String name;
private int num;
private String gender;


public String getName() {
	return name;
}

public void setName(String name) {
	this.name = name;
}

public int getNum() {
	return num;
}

public void setNum(int num) {
	this.num = num;
}

public String getGender() {
	return gender;
}

public void setGender(String gender) {
	this.gender = gender;
}



public Student03(String name, int num, String gender) {
	super();
	this.name = name;
	this.num = num;
	this.gender = gender;
}
	public void info() {
		System.out.println("이름:"+ name);
		System.out.println("학번"+ num);
		System.out.println("성별:"+ gender);
	}
}




