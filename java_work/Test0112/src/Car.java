
public class Car {
	//클래스 변수(static 붙으면)
	public static final String JIJUM = "동대구 영업소";
	//인스턴스변수
	private String model;
	private String company;
	private String color;
	private String price;
	
	//초기화. 클래스 이름과 동일. 객체 생성될때는 항상 생성자를 사용함. 기본 생성자 만드는것. 다른걸 쓰고싶을때는 불편함
	public Car() {	
		model = "k7";
		company = "kia";
		color = "블랙";
		price = "사천만원";		
	}

	// 동일한 이름의 메소드 사용할 수 있음. 오버로딩. 조건은 매개변수의 개수가 다르고 타입이 달라야함
	// 1-4
	public Car(String model, String company, String color, String price) {
		this.model = model;
		this.company = company;
		this.color = color;
		this.price = price;
	}
	
	//조건2-2~4
	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public String getPrice() {
		return price;
	}

	public void setPrice(String price) {
		this.price = price;
	}

	public void showCarInfo() {
		//인스턴스 메소드. 모든 변수 출력
		System.out.println(Car.JIJUM);
		System.out.println("제조사: " + company);
		System.out.println("모델: " + model);
		System.out.println("가격: " + price);
		System.out.println("색상: " + color);
	}
}
