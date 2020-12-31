package arr1223;

import java.util.Scanner;

public class Arr8 {

	public static void main(String[] args) {
		int arr[][] = new int[4][3];  //비어있는 2*3배열 생성
		int value = 1;
		for(int i=0; i<4;i++) {
			for (int j=0; j<3; j++) {
				arr[i][j] = value++;
			}
		}
		
		for(int i=0; i<4; i++) {
			for(int j=0; j<3; j++) {
				System.out.print(arr[i][j]+"\t");
			}
			System.out.println();
		}
	}

}
