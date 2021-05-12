package com.jb.addrApp.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;
import com.jb.addrApp.model.AddrBook;
import com.jb.addrApp.util.Menu;

public class MySQLHandler {
	Connection con;
	Statement state;
	final String USER_ID = "root";
	final String USER_PW = "1126";
	final String DBNAME = "mydb";

	String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	String dbURL = "jdbc:mysql://127.0.0.1/" + DBNAME + "?autoReconnect=true&" + "serverTimezone=UTC";

	// 생성자
	public MySQLHandler() {
		connectDB();
	}

	// 생성자 안에서 사용되기 때문에 굳이 외부로 노출될 필요없음 -> private를 사용하는 이유
	private void connectDB() {
		try {
			Class.forName(jdbcDriver);// .newInstance();
			con = DriverManager.getConnection(dbURL, USER_ID, USER_PW);
			if (con != null) {
				state = con.createStatement();
				System.out.println("DB접속성공!");
			}
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void closeDB() {
		try {
			state.close();
			con.close();
			System.out.println("DB 접속 해제");
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void CreateTB() {
		String query = "create table addrbook (" + "id INT(10) NOT NULL AUTO_INCREMENT," + "name VARCHAR(10) NOT NULL,"
				+ "age INT(3) NOT NULL," + "tel VARCHAR(20) NOT NULL," + "address VARCHAR(40) NOT NULL,"
				+ "email VARCHAR(30) NULL," + "date DATETIME NOT NULL," + "PRIMARY KEY(id))";

		try {
			state.executeUpdate(query);
			System.out.println("테이블 생성 성공!");
		} catch (SQLException e) {
			checkError(e);
		}
	}

	public void dropTB() {
		String query = "drop table addrbook";
		try {
			state.executeUpdate(query);
			System.out.println("테이블 삭제 성공!");
		} catch (SQLException e) {
			checkError(e);
		}
	}

	public void InsertData(AddrBook ab) {

		String query = String.format(
				"insert into addrbook(id,name, age, tel, address, email, date)"
						+ "values(0,'%s',%d,'%s','%s','%s',now())",
				ab.getName(), ab.getAge(), ab.getTel(), ab.getAddress(), ab.getEmail());
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void ViewData() {
		String query = "select * from addrbook";
		try {
			ResultSet rs = state.executeQuery(query);
			if (rs != null) {
				rs = state.getResultSet();
				int count = 0;
				while (rs.next()) {
					System.out.print(count + "\t");
					System.out.print(rs.getString("name") + "\t");
					System.out.print(rs.getString("age") + "\t");
					System.out.print(rs.getString("tel") + "\t");
					System.out.print(rs.getString("address") + "\t");
					System.out.print(rs.getString("email") + "\t");
					System.out.println(rs.getString(7));
					count++;
				}
				rs.close();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void UpdateData2(String colName, String after, String before) throws SQLException {
		if (colName.equals("age")) {
			String query1 = String.format("update addrbook set %s=%d where %s=%d", colName, Integer.parseInt(after),
					colName, Integer.parseInt(before));
			state.executeUpdate(query1);
			System.out.println("변경완료!");
		} else {
			String query1 = String.format("update addrbook set %s='%s' where %s='%s'", colName, after, colName, before);
			state.executeUpdate(query1);
			System.out.println("변경완료!");
		}
	}

	public void UpdateData(Scanner s) throws SQLException {
		Menu me = new Menu();
		switch (me.UpdateMenu(s)) {
		case Menu.UP_NAME:
			System.out.print("수정전 이름을 입력하세요 :");
			String bfn = s.next();
			System.out.print("수정후 이름을 입력하세요 :");
			String afn = s.next();
			UpdateData2("name", afn, bfn);
			break;
		case Menu.UP_AGE:
			System.out.print("수정전 나이를 입력하세요 :");
			String bfa = s.next();
			System.out.print("수정후 나이를 입력하세요 :");
			String afa = s.next();
			UpdateData2("age", afa, bfa);
			break;
		case Menu.UP_TEL:
			System.out.print("수정전 번호를 입력하세요 :");
			String bft = s.next();
			System.out.print("수정후 번호를 입력하세요 :");
			String aft = s.next();
			UpdateData2("tel", aft, bft);
			break;
		case Menu.UP_ADDR:
			System.out.print("수정전 주소를 입력하세요 :");
			String bfad = s.next();
			System.out.print("수정후 주소를 입력하세요 :");
			String afad = s.next();
			UpdateData2("addr", afad, bfad);
			break;
		case Menu.UP_EMAIL:
			System.out.print("수정전 메일을 입력하세요 :");
			String bfm = s.next();
			System.out.print("수정후 메일을 입력하세요 :");
			String afm = s.next();
			UpdateData2("email", afm, bfm);
			break;
		}
	}

	public void DelData() {
		String query = "delete from addrbook";

		try {
			state.executeUpdate(query);
			System.out.println("모든 데이터가 삭제되었습니다.");
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	// 에러관리 메소드
	public void checkError(SQLException e) {
		switch (e.getErrorCode()) {
		case 1050:
			System.out.println("테이블이 이미 존재합니다.");
			break;
		case 1051:
			System.out.println("삭제할 테이블이 존재하지 않습니다.");
			break;
		}
	}
}
