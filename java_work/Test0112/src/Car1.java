
public class Car1 {
	private String model;
	private int year;
	private String money;
	public final static String JIJUM = "동대구영업소"
	
	public Car() {
		
	}
	//메소드 오버로딩
	public Car1(String model, int year, String money) {
		super();
		this.model = model;
		this.year = year;
		this.money = money;
	}
	public String getModel() {
		return model;
	}
	public void setModel(String model) {
		this.model = model;
	}
	public int getYear() {
		return year;
	}
	public void setYear(int year) {
		this.year = year;
	}
	public String getMoney() {
		return money;
	}
	public void setMoney(String money) {
		this.money = money;
	}
	public void showCarInfo() {
		System.out.println("모델:"+model);
		System.out.println("연식:"+year);
		System.out.println("가격:"+money);
		System.out.println("----------");
	}
}
