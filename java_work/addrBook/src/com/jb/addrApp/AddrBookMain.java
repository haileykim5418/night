package com.jb.addrApp;

import java.sql.SQLException;
import java.util.Scanner;
import com.jb.addrApp.dao.MySQLHandler;
import com.jb.addrApp.util.Menu;
import com.jb.addrApp.util.RandData;

public class AddrBookMain {

	public static void main(String[] args) throws SQLException {
		Scanner s = new Scanner(System.in);

		MySQLHandler db = new MySQLHandler();
		Menu me = new Menu();

		while (true) {
			switch (me.mainMenu(s)) {
			case Menu.CREATE_TABLE:
				db.CreateTB();
				break;
			case Menu.DEL_TABLE:
				db.dropTB();
				break;
			case Menu.INSERT_DATA:
				db.InsertData(me.addMenu(s));
				System.out.println("데이터 생성 성공!");
				break;
			case Menu.RANDOM_DATA:
				RandData data = new RandData();
				for (int i = 0; i < 10; i++) {
					db.InsertData(data.getABook());
				}
				System.out.println("랜덤 데이터 생성 성공!");
				break;
			case Menu.VIEW_DATA:
				db.ViewData();
				break;
			case Menu.UPDATE_DATA:
				db.UpdateData(s);
				break;
			case Menu.DEL_DATA:
				db.DelData();
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


