package class0106;

public class Class1 {

	public static void main(String[] args) {
		Student s = new Student();
		s.name = "홍길동";  //인스턴스 변수에 이름 입력
		s.email = "hong@naver.com";
		s.tel = "010-1234-1234";
		s.name="김길동";
		
		System.out.println("이름: "+s.name);
		System.out.println("메일: "+s.email);
		System.out.println("전화: "+s.tel);
		System.out.println("과정: " + Student.category); //클래스 이름으로 바로 접근
		
		Student ss = new Student();
		ss.name = "김길동"; 
		
		ss.email = "kim@naver.com";
		ss.tel = "010-1233-1233";
		System.out.println("이름: "+ss.name);
		System.out.println("메일: "+ss.email);
		System.out.println("전화: "+ss.tel);
		System.out.println("과정: " + Student.category);
		
	}

}
//주소록 클래스 정의
class Student {
	static String category = "통합응용sw과정"; //클래스 변수  공용으로 사용하기 위해
	//인스턴스변수 생성
	String name;
	String tel;
	String email;
}
