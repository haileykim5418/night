import java.util.Scanner;

public class Exam0126_04_05 {

	public static void main(String[] args) {
		char eng[] = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
				't', 'u', 'v', 'x', 'w' };
		char kor[] = { 'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅅ', 'ㅇ', 'ㅈ', 'ㅊ', 'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 'ㅑ', 'ㅓ', 'ㅕ', 'ㅗ',
				'ㅛ', 'ㅜ', 'ㅠ', 'ㅡ', 'ㅣ' };
		int chCount[] = new int[24];
		
		Scanner s = new Scanner(System.in);
		System.out.print("알파벳 입력:");
		String lang = s.next();

		for (int i = 0; i < lang.length(); i++) { // 입력받은 길이만큼 돌기
			for (int j = 0; j < eng.length; j++) { // 안에 내용과 비교
				if (lang.charAt(i) == eng[j]) {  //기준이됨
					System.out.print(kor[j]);
					chCount[j]++;  // chCount[j]+=1;
					break;
				}
			}
		}
		System.out.println();
		for(int i=0;i<eng.length;i++) {
			if (chCount[i]!=0) {
//				System.out.println(eng[i]+":"+chCount[i]);
				System.out.printf("%c는 %d글자입니다.", eng[i], chCount[i]);
			}
			
		}

	}

}
