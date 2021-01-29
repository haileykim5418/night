package collect0127;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

public class CollectMain {

	public static void main(String[] args) {
		System.out.println("##########배열########");
		String strArr[] = new String[3];
		strArr[0] = "홍길동";
		strArr[1] = "김길동";
		strArr[2] = "박길동";

		for (String str : strArr) { // 향상된for문
			System.out.println(str);
		}
		for (int i = 0; i < strArr.length; i++) {
			System.out.println(strArr[i]);
		}
		System.out.println("###########ArrayList#########");
		ArrayList<String> list = new ArrayList<>(); // <>가 제너릭클래스 스트링데이터를 넣을 수 있는 제너릭클래스를 생성한것.
		list.add("홍길동");
		list.add("김길동");
		list.add("박길동");

		for (int i = 0; i < list.size(); i++) {
			System.out.println(list.get(i));
		}

		System.out.println("########stack#########");

		// LIFO (last in first out)
		// push:데이터 추가
		// pop:데이터 가져오기
		Stack<String> st = new Stack<>(); // import
		st.push("홍길동"); // 맨아래
		st.push("김길동");
		st.push("박길동"); // 가져오려면 박길동부터 나오게됨

		while (!st.isEmpty()) { // stack이 비어있을때까지
			System.out.println(st.pop());
		}
		
		System.out.println("######queue########");
		
		Queue<String> qu = new LinkedList<>();  //arraylist랑 가장 비슷
		qu.add("홍길동");
		qu.add("김길동");
		qu.add("박길동");
		
		while (qu.isEmpty()==false) {
			System.out.println(qu.poll());  //리스트처럼 입력된 순서대로 나옴
		}
		
		System.out.println("######HashMap########");
		//키값으로 관리되는 자료구조
		HashMap<Integer,String> map = new HashMap<>();
		map.put(1, "홍길동");
		map.put(2, "김길동");
		map.put(3, "박길동");
		
		Iterator<Integer> keySetIt=map.keySet().iterator();
	while(keySetIt.hasNext()) {
		Integer key = keySetIt.next();
		System.out.printf("key=%d, 값=%s\n", key, map.get(key));
	}
	
	}
}
