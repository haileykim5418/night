import java.util.Scanner;

public class Circle {
		private double rad = 0;
		final double PI = 3.14;
		
		public Circle(double r) { setRad(r); }
		public double getArea() { return (rad*rad) * PI; }
		public double getRad() {
			return rad;
		}
		public void setRad(double rad) {
			if(rad < 0) {
				this.rad = rad*-1;
			}else {
				this.rad = rad;
			}
		}
		
		Scanner s = new Scanner(System.in);
		System.out.println("1.원 반지름 입력 :");
		Circle circle = new Circle(s.nextInt());
		System.out.println(circle.getArea());
}
