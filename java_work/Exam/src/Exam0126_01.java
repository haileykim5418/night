import java.util.Scanner;

public class Exam0126_01 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("반지름 입력 : ");
		double rad = s.nextDouble();

		if (rad < 0) {
			System.out.println("양수 입력하세요");
			System.exit(0);
		}

		Circle c = new Circle(rad);
		System.out.println("원의 면적: " + c.getArea());

	}

}

class Circle {
	static double rad = 0;
	final double pi = 3.14;

	public Circle(double r) {
		this.rad = rad;
	}

	public double getRad(double rad) {
		return rad;
	}

	public void setrad(double rad) {
		this.rad = rad;
	}

	public double getArea() {
		return (rad * rad) * pi;
	}

	public void setRad(double r) {

	}
}
