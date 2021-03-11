package com.lg.addrApp;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

import com.lg.addrApp.dao.MySQLHandler;
import com.lg.addrApp.model.AddrBook;
import com.lg.addrApp.util.Menu;
import com.lg.addrApp.util.RandData;

public class AddrBookMain {

	public static void main(String[] args) {
		MySQLHandler db = new MySQLHandler(); // MySQLHandler 클래스 객체생성
		Menu me = new Menu();
		Scanner s = new Scanner(System.in); // 스캐너 메인에 빼면 나머지 메소드에 매개변수로 s던짐
		// db.connectDB();
		while (true) {
			switch (me.mainmenu(s)) {
			case Menu.CREATE_TABLE: // Menu. 쓰는 이유는 Menu 클래스에서 객체 생성할 필요없는 static, 외부 사용가능한 public으로 선언해줬기때문에 가능
				db.createTB();
				break;
			case Menu.DEL_TABLE:
				db.dropTB();
				break;
			case Menu.INSERT_DATA:
//				AddrBook addr = me.addmenu(s);
				db.insertDB(me.addmenu(s));
				break;
			case Menu.INSERT_RAND_DATA:
				RandData data = new RandData();
				for (int i = 0; i < 100; i++) {
					db.insertDB(data.getABook());
					System.out.println("랜덤 데이터가 추가되었습니다");
				}
				break;
			case Menu.VIEW_DATA:
				db.viewDT();
				break;
			case Menu.UPDATE_DATA:
				db.updateDT(s);
				System.out.println("데이터가 수정되었습니다");
				break;
			case Menu.DEL_DATA:
				db.del_table(s);
				System.out.println("데이터가 삭제되었습니다");
				break;
			case Menu.MAIN_EXIT:
				System.out.println("프로그램 종료");
				db.closeDB();
				s.close();
				System.exit(0);
				break;
			}
		}
	}
}