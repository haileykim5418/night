
public class Main {

	public static void main(String[] args) {
		Car car = new Car();
		car.showCarInfo();
		
		//2-6
	//객체 생성할 때만 사용
		Car car2 = new Car("그렌저", "현대", "흰색", "3천만원");
		car2.showCarInfo();
		
		new Car()).showCarInfo();
	}

}
