package com.gh2;

import java.util.Random;

public class CarAppMain {

	public static void main(String[] args) {
		String name[]= {"홍길동","박길동","이길동","최길동","김길동"};
		String tel[]= {"010-1234-1234","010-1234-1238","010-1234-1237","010-1234-1236","010-1234-1235"};
		String address[] = {"대구","서울","부산","인천","광주"};
		String model[]= {"sm6","소나타","산타페","그렌저","k7"};
		String color[]= {"블랙","실버","화이트","그레이","레드"};
		int year[] = {2021,2020,2019,2018,2017};
		String company[]= {"르노삼성","현대","기아","쌍용","GM"};
		String price[] = {"삼천만원","사천만원","오천만원","이천만원","사천오백만원"};

		Random r = new Random();
		Customer cu [] = new Customer[10];
		for (int i=0; i<cu.length; i++) {
			cu[i] = new Customer(name[r.nextInt(5)],tel[r.nextInt(5)],address[r.nextInt(5)],
					new Car(model[r.nextInt(5)],year[r.nextInt(5)], color[r.nextInt(5)], company[r.nextInt(5)],price[r.nextInt(5)]));
		cu[i].printCustomerInfo();
		}
	}

}
