package method1230;

import java.util.Scanner;

public class Exam5 {

	public static void gugu(int num) {
		
		   System.out.println("--------------------");
		      System.out.println("간단한 로또 프로그램 v1.1");
		      System.out.println("--------------------");

		      // 배열 사용
		      int lottoarr[] = new int[6]; // 0으로 표시되는 6개 비어있는 방 생성
		      System.out.println(lottoarr.length);
		      for (int i = 0; i < lottoarr.length; i++) {
		         int lottoarr2 = (int) (Math.random() * 45) + 1;
		         System.out.println("로또 번호 : " + lottoarr2);
		         // 비어있는 배열에 번호 저장
		         if (i == 0) { // i==0 : 0으로 표시되는 6개의 방
		            lottoarr[i] = lottoarr2;
		         }
		         else {
		            lottoarr[i] = lottoarr2;
		            for (int j = 0; j < i; j++) {
		               if (lottoarr[j] == lottoarr[i]) {
		                  System.out.println("중복 발생");
		                  i--;
		                  break;
		               }

		            }

		         }

		      }
		      for (int i = 0; i < 6; i++) {
		         System.out.print(lottoarr[i] + " ");
		      }
		      System.out.println();
		   }

		
//		for(int i=1; i<=9; i++) {
//				System.out.println(num +"*"+i+"="+(i*num));
//			}
//		}
//
//	public static void main(String[] args) {
//		Scanner s = new Scanner(System.in);
//		System.out.println("숫자입력 :");
//		int num = s.nextInt();
//		
//		gugu(num);

	}

