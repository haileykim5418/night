package class0106;

public class Class2 {

	public static void main(String[] args) {
		Student2 s = new Student2();
		
		s.setName("홍길동");
		s.setEmail("hong@naver.com");
		s.setTel("010-1234-1234");
		
		System.out.println("이름: "+s.getName());
		System.out.println("메일: "+s.getEmail());
		System.out.println("전화: "+s.getTel());
		System.out.println("과정: " + Student.category); //클래스 이름으로 바로 접근
		
		Student2 ss = new Student2();
		ss.setName("김길동"); 
		ss.setEmail("kim@naver.com");
		ss.setTel("010-1233-1233");
		
		System.out.println("이름: "+ss.getName());
		System.out.println("메일: "+ss.getEmail());
		System.out.println("전화: "+ss.getTel());
		System.out.println("과정: " + Student.category);
	
//		new Student2(); 익명개체 한번 사용은 가능하지만 다시 이 개체에 접근할 방법이 없음
		new Student2().setName("이길동");
		System.out.println(new Student2().getName());
	}

}
////주소록 클래스 정의
//class Student2 {
//	static String category = "통합응용sw과정"; //클래스 변수  공용으로 사용하기 위해
//	//인스턴스변수 생성
//	private String name;
//	private String tel;
//	private String email;
//	//private붙이면 외부 클래스에 접근 불가, 선언된 클래스 안에서만 접근가능
//	//public  외부 클래스에서 접근 가능
//	
//	
//	//setter 값을 설정하는 것
//	public void setName(String name) { //static 이 없으면 인스턴스 메소드
////		name = name;  이렇게 하면 지역변수 name을 가져옴. 나는 저 위에 name을 가져오고싶은데
//		this.name = name;  //this는 생성되어진 객체의 위치정보를 가져옴 헷갈리면 이름 바꾸면 됨 ex. name = name1 지역변수 이름을 name1로, 인스턴스 변수에만  this붙음
//	}
//	//getter 값을 가져오는 것
//	public String getName() {
//		return name;
//	}
//	public String getTel() {
//		return tel;
//	}
//	public void setTel(String tel) {
//		this.tel = tel;
//	}
//	public String getEmail() {
//		return email;
//	}
//	public void setEmail(String email) {
//		this.email = email;
//	}
//}
