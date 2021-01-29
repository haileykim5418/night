package thread0127;

import java.io.File;
import java.io.IOException;

public class Thread6 {

	public static void main(String[] args) {
		FileDir fileDir = new FileDir();
		fileDir.start();

	}

}
class FileDir extends Thread {
	public void run() {
		subDirList("c:\\");
	}
public void subDirList(String source) {    
	File dir = new File(source);
	File[] fileList = dir.listFiles();
	
	for(int i=0; i<fileList.length; i++) {
		File file = fileList[i];
		if(file.isFile()) {
			String name = file.getName();
			System.out.println("\t파일:"+name);
		}
		else if (file.isDirectory()) {
			System.out.println("폴더:"+file.getName());
			try {
				String name = file.getCanonicalPath().toString();
						System.out.println("폴더:");
				subDirList(name);
				Thread.sleep(10);
			} catch (IOException e) {
				
				e.printStackTrace();
			} catch (InterruptedException e) {
				
				e.printStackTrace();
			} catch (NullPointerException e) {
				
				e.printStackTrace();
				
			}
		}
	}
}
}
