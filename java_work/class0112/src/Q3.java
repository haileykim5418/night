

public class Q3 {

	public static void main(String[] args) {

		int[] arr = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};

		Arr a = new Arr(arr);
		
		System.out.println("총합 : " + a.calcSum() + "\n평균 : " + a.calcAvg());
	}

}

class Arr {
	int[] arr;
	int sum = 0;
	int avg = 0;
	
	Arr(int[] arr) {
		this.arr = arr;
		for (int i = 0; i < this.arr.length; i++)
			sum += this.arr[i];
		avg = sum / this.arr.length;
	}
	
	int calcSum() {
		return sum;
	}
	
	int calcAvg() {
		return avg;
	}
}