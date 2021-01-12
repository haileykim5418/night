package Class0106_1;

public class Q1 {

	public static void main(String[] args) {

		Car c1 = new Car("제조사", "색상", "가격", "모델");
		c1.print();
		
		Car c2 = new Car();
		c2.setModel("모델모델");
		c2.setPrice("가격가격");
		c2.print();
	}

}

class Car {
	static final String affiliate = "동대구 영업소";
	
	String manufacturer = "기아"; // 제조사
	String color = "블랙"; // 색상
	String price = "사천만원"; // 가격
	String model = "K7"; // 모델명
	
	public String getPrice() {
		return price;
	}

	public void setPrice(String price) {
		this.price = price;
	}

	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	Car() {
		
	}
	
	Car(String manufacturer, String color, String price, String model) {
		this.manufacturer = manufacturer;
		this.color = color;
		this.price = price;
		this.model = model;
	}
	
	public void print() {
		System.out.println("제조사 : " + manufacturer
				+ "\n색상 : " + color
				+ "\n이름 : " + model
				+ "\n가격 : " + price
				+ "\n대리점명 : " + affiliate);
	}
	
}