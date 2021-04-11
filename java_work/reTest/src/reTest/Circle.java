package reTest;

public class Circle {
	double rad = 0;
	final double PI = 3.14;

	public Circle(double r) {
		setRad(r);
	}

	public double getArea() {
		return (rad * rad) * PI;
	}

	private void setRad(double r) {
		if (rad < 0) {
			rad = 0;
			return;
		}

	}

}
