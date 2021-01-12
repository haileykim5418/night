
public class QQ1 {

	public static void main(String[] args) {
		
		Car2 a = new Car2();
		a.methodPrint();
		
		Car2 b = new Car2("제조사1","색상1","이름1",7);
		b.methodPrint();
		
	}

}

class Car2 {

	public static final String af = "동대구 영업소";
	public String manu;
	String color;
	private int price;
	private String name;
	
	String getName() {
		return name;
	}
	
	void setName(String name) {
		this.name = name;
	}
	
	
	
	
	public int getPrice() {
		return price;
	}

	public void setPrice(int price) {
		this.price = price;
	}

	Car2() {
		manu = "기아";
		color = "블랙";
		name = "k7";
		price = 4000;
		
				
	}
	
	Car2(String manu,String color,String name, int price) {
		
		this.manu = manu;
		this.color = color;
		this.name = name;
		this.price = price;
		
		
		
	}

	void methodPrint() {
		System.out.println(manu);
		System.out.println(color);
		System.out.println(name);
		System.out.println(price);
		
	}
}