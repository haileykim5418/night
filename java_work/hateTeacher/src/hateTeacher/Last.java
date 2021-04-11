package hateTeacher;

import java.util.Scanner;

public class Last {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		String input = s.nextLine();
		int[ ]al = new int[26];
		for (int i = 0; i < input.length(); i++) {
			int index = input.charAt(i)-(int)'a';
			al[index]++;
		}
		for (int i = 0; i < al.length; i++) {
			if(al[i]!=0) {
				String sentence = "'"+(char)(i+97)+"'는"+al[i]+"글자입니다.";
				System.out.println(sentence);
			}
			
		}
	}

}
