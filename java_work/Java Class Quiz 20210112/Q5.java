package Class0106_1;

import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.Random;
import java.util.StringTokenizer;

public class Q5 {

	public static void main(String[] args) throws IOException {

		MyFileWrite mw = new MyFileWrite();
		mw.setPath("d:/name.txt");
		mw.crateFile();
		mw.writeFileByRandomNames();
		mw.closeFile();
		
		MyFileRead mr = new MyFileRead(mw.getPath());
		mr.readFile();
		mr.closeFile();
	}

}

class MyFileWrite {

	private String path = "d:/name.txt";
	private BufferedOutputStream bs = null;
	
	public String getPath() {
		return path;
	}

	public void setPath(String path) {
		this.path = path;
	}
	
	public void crateFile() throws FileNotFoundException {
		bs = new BufferedOutputStream(new FileOutputStream(path));
	}
	
	public void writeFileByRandomNames() throws IOException {
		for (int i = 0; i < 50; i++) {
			bs.write((NameData.getFullName() + "/").getBytes());
		}
	}
	
	public void closeFile() throws IOException {
		bs.close();
	}

}

class MyFileRead {
	
	private ArrayList<String> arrStr;
	private BufferedReader br = null;
	
	MyFileRead(String path) throws IOException {
		arrStr = new ArrayList<String>();
		br = new BufferedReader(new FileReader(new File(path)));
	}
	
	public void readFile() throws IOException {
		if(br != null) {
			StringTokenizer st = new StringTokenizer(br.readLine(), "/");
			while(st.hasMoreTokens()) {
				arrStr.add(st.nextToken());
			}
			
			for(String name : arrStr) {
				System.out.println(name);
			}
			
		}
			
	}
	
	public void closeFile() throws IOException {
		br.close();
	}
}

class NameData {
	private static final String[] first = { "김", "박", "이", "최", "장" };
	private static final String[] mid = { "가", "나", "다", "라", "마" };
	private static final String[] last = { "바", "사", "아", "자", "차" };

	private static String fullName;

	public static String getFullName() {
		Random r = new Random();
		fullName = "";

		fullName += first[r.nextInt(first.length - 1)];
		fullName += mid[r.nextInt(mid.length - 1)];
		fullName += last[r.nextInt(last.length - 1)];
		
		// System.out.println("만들어진 이름 : " + fullName);

		return fullName;
	}

}