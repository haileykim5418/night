package hateTeacher;

public class ManageStudent {

	public static void main(String[] args) {
		Student s1 = new Student("박보검",1999038033,"남");
		Student s2 = new Student("김가현",2007012034,"여");
				
		Student[] sArray = new Student[2];
		sArray[0] = s1;
		sArray[1] = s2;
		
		for (int i = 0; i < sArray.length; i++) {
			Student student = sArray[i];
			if(student.name.equals("박보검")) {
				student.number = 2017038033;
			}
			
		}
		for (int i = 0; i < sArray.length; i++) {
			Student student = sArray[i];
			System.out.println(student);
			
		}
	}

}
