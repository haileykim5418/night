package reTest;

public class ReRe {
private String name;
private int number;
private char gender;

public ReRe() {
	
}


	public ReRe(String name, int number, char gender) {
	super();
	this.name = name;
	this.number = number;
	this.gender = gender;
}



	public String getName() {
		return name;
	}


	public void setName(String name) {
		this.name = name;
	}


	public int getNumber() {
		return number;
	}


	public void setNumber(int number) {
		this.number = number;
	}


	public char getGender() {
		return gender;
	}


	public void setGender(char gender) {
		this.gender = gender;
	}
	
	
	public void info() {
		System.out.println("이름"+name);
		System.out.println("학번"+number);
		System.out.println("성별"+gender);
	}


	public static void main(String[] args) {
		ReRe studentArr[] = new ReRe[2];
		studentArr[0] = new ReRe("이동준",2009038033,'남');
		studentArr[1] = new ReRe("이제영",2007012034,'여');
		for(int i=0; i<=studentArr.length;i++) {
			studentArr[i].info();
		}
		System.out.println("이동준 정보 변경");
		studentArr[0].setNumber(2019038033);
			for(int i=0; i<=studentArr.length;i++) {
				studentArr[i].info();
		}
	}

}
