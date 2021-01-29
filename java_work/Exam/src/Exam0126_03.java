
public class Exam0126_03 {

	public static void main(String[] args) {
		String name[] = {"이동준","이제영"};
		int number[] = {2009038033,2007012034};
		String gender[] = {"남","여"};
		
		Student03 info[] = new Student03[2];
	      for (int i = 0; i < info.length; i++) {
	         info[i] = new Student03(name[i], number[i], gender[i]);
	         info[i].info();
	      }
	      info[0] = new Student03("이동준",2019038033,"남");
	      info[0].info();
	      
	     
	}

}
