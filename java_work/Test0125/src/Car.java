
public class Car {
	String manu;
	String color;
	int price;
	String model;
	
	
	public Car(String manu, String color, int price, String model) {
		super();
		this.manu = manu;
		this.color = color;
		this.price = price;
		this.model = model;
	}


	
	public String getManu() {
		return manu;
	}



	public void setManu(String manu) {
		this.manu = manu;
	}



	public String getColor() {
		return color;
	}



	public void setColor(String color) {
		this.color = color;
	}



	public int getPrice() {
		return price;
	}



	public void setPrice(int price) {
		this.price = price;
	}



	public String getModel() {
		return model;
	}



	public void setModel(String model) {
		this.model = model;
	}



	public Car(){
		manu = "기아";
		color = "블랙";
		model = "k7";
		price = 4000;
	}
	
	
}
