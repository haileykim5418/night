

public class Q4 {

	public static void main(String[] args) {
		
		StudentScore ss = new StudentScore();
		ss.studentGradeCreate();
	}

}

class StudentScore {
	
	private static int[][] grades;

	public static int[][] getGrades() {
		return grades;
	}

	public static void setGrades(int[][] grades) {
		StudentScore.grades = grades;
	}

	StudentScore() {
		grades = new int[5][];
		// studentGradeCreate();
	}

	private int[] studentGradesRandomInput() {
		int[] studentGrades = new int[3];

		for(int i = 0; i < studentGrades.length; i++)
			studentGrades[i] = (int)((Math.random() * 10000) % 100);

		return studentGrades;
	}
	
	public void studentGradeCreate() {
		for(int i = 0; i < grades.length; i++) {
			grades[i] = studentGradesRandomInput();
		}
		int total = 0, avg = 0;
		for(int i = 0; i < grades.length; i++) {
			for(int j = 0; j < grades[i].length; j++) {
				total += grades[i][j];
			}
			avg = total / grades[i].length;
			System.out.print("[" + (i + 1) + "번째 학생]  ");
			if((90 <= avg) && (avg <= 100))
				System.out.print("A학점입니다 !!   ");
			else if((80 <= avg) && (avg <= 89))
				System.out.print("B학점입니다 !!   ");
			else if((70 <= avg) && (avg <= 79))
				System.out.print("C학점입니다 !!   ");
			else if((60 <= avg) && (avg <= 69))
				System.out.print("D학점입니다 !!   ");
			else if((50 <= avg) && (avg <= 59))
				System.out.print("E학점입니다 !!   ");
			else
				System.out.print("F학점입니다 !!   ");
			System.out.println("평균 : " + avg + "   총점 : " + total);
			total = 0;
			avg = 0;
		}
	}

}