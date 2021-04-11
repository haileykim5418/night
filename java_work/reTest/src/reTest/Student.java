package reTest;

public class Student {

	public static void main(String[] args) {
		StudentClass students[] = new StudentClass[2];
		students[0] = new StudentClass("이동준",2009038033,'남');
		students[1] = new StudentClass("이제영",2007012034,'여');
		for(int i=0;i<students.length;i++) {
			students[i].info();
		}
		System.out.println("이동준 변경");
		students[0].setNum(2019038033);
		for(int i=0;i<students.length;i++) {
			students[i].info();
		}
	}

}
