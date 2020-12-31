package arr1223;

import java.util.Scanner;

public class Test4 {

	public static void main(String[] args) {

		int arr[][]= {
				{1,2},
				{2,4},
				{3,6},
				{4,8},
				{5,10}
		};
		for(int i = 0; i<arr.length;i++) {
			for(int j=0;j<arr[i].length;j++) {
				System.out.print("arr"+"["+i+"]"+"["+j+"]"+"="+arr[i][j]+"\t");
			}
			System.out.println();
		
		}

	}

}
