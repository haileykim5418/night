package loop1222;

public class Loop1 {

	public static void main(String[] args) {
		for (int i = 0; i<2; i++ ) {
			for (int j=0; j<3; j++) { 
				//i=0, j=012
				//i=1, j=012
			}
		}


		for (int i=0; i<3; i++) {
			for (int j=0; j<4; j++) {
				//i=0, j=0123
				//i=1, j=0123
				//i=2, j=0123
				
			}
		}
		for(int i=0; i<4; i++ ) {
			for (int j=0; j<2; j++) {
				//i=0, j=01
				//i=1, j=01
				//i=2, j=01
				//i=3, j=01
				System.out.printf("i:%d, j:%d\n", i,j);
				
			}
		}

	}}
