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

	// ������
	public MySQLHandler() {
		connectDB();
	}

	// ������ �ȿ��� ���Ǳ� ������ ���� �ܺη� ����� �ʿ���� -> private�� ����ϴ� ����
	private void connectDB() {
		try {
			Class.forName(jdbcDriver);// .newInstance();
			con = DriverManager.getConnection(dbURL, USER_ID, USER_PW);
			if (con != null) {
				state = con.createStatement();
				System.out.println("DB���Ӽ���!");
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
			System.out.println("DB ���� ����");
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
			System.out.println("���̺� ���� ����!");
		} catch (SQLException e) {
			checkError(e);
		}
	}

	public void dropTB() {
		String query = "drop table addrbook";
		try {
			state.executeUpdate(query);
			System.out.println("���̺� ���� ����!");
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
			System.out.println("����Ϸ�!");
		} else {
			String query1 = String.format("update addrbook set %s='%s' where %s='%s'", colName, after, colName, before);
			state.executeUpdate(query1);
			System.out.println("����Ϸ�!");
		}
	}

	public void UpdateData(Scanner s) throws SQLException {
		Menu me = new Menu();
		switch (me.UpdateMenu(s)) {
		case Menu.UP_NAME:
			System.out.print("������ �̸��� �Է��ϼ��� :");
			String bfn = s.next();
			System.out.print("������ �̸��� �Է��ϼ��� :");
			String afn = s.next();
			UpdateData2("name", afn, bfn);
			break;
		case Menu.UP_AGE:
			System.out.print("������ ���̸� �Է��ϼ��� :");
			String bfa = s.next();
			System.out.print("������ ���̸� �Է��ϼ��� :");
			String afa = s.next();
			UpdateData2("age", afa, bfa);
			break;
		case Menu.UP_TEL:
			System.out.print("������ ��ȣ�� �Է��ϼ��� :");
			String bft = s.next();
			System.out.print("������ ��ȣ�� �Է��ϼ��� :");
			String aft = s.next();
			UpdateData2("tel", aft, bft);
			break;
		case Menu.UP_ADDR:
			System.out.print("������ �ּҸ� �Է��ϼ��� :");
			String bfad = s.next();
			System.out.print("������ �ּҸ� �Է��ϼ��� :");
			String afad = s.next();
			UpdateData2("addr", afad, bfad);
			break;
		case Menu.UP_EMAIL:
			System.out.print("������ ������ �Է��ϼ��� :");
			String bfm = s.next();
			System.out.print("������ ������ �Է��ϼ��� :");
			String afm = s.next();
			UpdateData2("email", afm, bfm);
			break;
		}
	}

	public void DelData() {
		String query = "delete from addrbook";

		try {
			state.executeUpdate(query);
			System.out.println("��� �����Ͱ� �����Ǿ����ϴ�.");
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	// �������� �޼ҵ�
	public void checkError(SQLException e) {
		switch (e.getErrorCode()) {
		case 1050:
			System.out.println("���̺��� �̹� �����մϴ�.");
			break;
		case 1051:
			System.out.println("������ ���̺��� �������� �ʽ��ϴ�.");
			break;
		}
	}
}
