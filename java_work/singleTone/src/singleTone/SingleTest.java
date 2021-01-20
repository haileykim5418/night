package singleTone;

public class SingleTest {
	private static SingleTest inst;  //클래스변수
	private int data;  //인스턴스변수
	
	public SingleTest() {
		data = (int)(Math.random()*100);
	}
	
	//클래스메소드
	public static SingleTest getInstance() {
		if(inst == null) {
			inst = new SingleTest();
		}
		return inst;
	}
	public int getData() {
		return data;
	}
}
