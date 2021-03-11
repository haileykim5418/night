package jdbc0304_2;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class JdbcTest {

	static Connection con; // db에 접속하기 위한것
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static Statement state;
	static final String DBNAME = "mydb";
	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";

	static final int CREATE_TABLE = 1;
	static final int DEL_TABLE = 2;
	static final int INSERT_DATA = 3;
	static final int INSERT_RAND_DATA = 4;
	static final int VIEW_DATA = 5;
	static final int UPDATE_DATA = 6;
	static final int DEL_DATA = 7;
	static final int MAIN_EXIT = 8;

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in); // 스캐너 메인에 빼면 나머지 메소드에 매개변수로 s던짐
		connectDB();
		while (true) {
			switch (menu(s)) {
			case CREATE_TABLE:
				createTB();
				break;
			case DEL_TABLE:
				dropTB();
				break;
			case INSERT_DATA:
				insertDT();
				break;
			case INSERT_RAND_DATA:
//				randDT();
				break;
			case VIEW_DATA:
				viewDT();
				break;
			case UPDATE_DATA:
				break;
			case DEL_DATA:
				break;
			case MAIN_EXIT:
				System.out.println("프로그램 종료");
				closeDB();
				s.close();
				System.exit(0);
				break;
			}
		}

	}

	public static int menu(Scanner s) {

		System.out.println("---------------------");
		System.out.println("MySQL DB 관리 v1.0");
		System.out.println("---------------------");
		System.out.println("1.테이블 생성");
		System.out.println("2.테이블 삭제");
		System.out.println("3.데이터 추가");
		System.out.println("4.랜덤 데이터 추가");
		System.out.println("5.테이블 보기");
		System.out.println("6.테이블 수정");
		System.out.println("7.테이블 삭제");
		System.out.println("8.종료");
		System.out.println("---------------------");
		System.out.print("메인 메뉴 선택 : ");
		return s.nextInt();
	}

	public static void connectDB() {
		try {
			Class.forName(jdbcDriver).newInstance();
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);
			if (con != null) {
				state = con.createStatement();
				System.out.println("DB접속 성공!");
			}
		} catch (InstantiationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IllegalAccessException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void del_table() {

	}

	public static void closeDB() {
		try {
			state.close();
			con.close();
			System.out.println("DB접속 해제");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void createTB() {
		String query = "create table addrbook(" + "id INT(10) NOT NULL AUTO_INCREMENT," + "name VARCHAR(10) NOT NULL,"
				+ "age INT(3) NOT NULL," + "tel VARCHAR(20) NOT NULL," + "address VARCHAR(40) NOT NULL,"
				+ "email VARCHAR(30) NULL," + "date DATETIME NOT NULL," + "PRIMARY KEY(id))";

		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
//			System.out.println(g.getSQLState());
//			System.out.println(e.getMessage());
//			System.out.println(e.getErrorCode());
//			System.out.println(e.getCause().toString());
//			e.printStackTrace();

			if (e.getErrorCode() == 1050) {
				System.out.println("테이블이 이미 존재합니다");
				System.out.println(e.getMessage());
			}
		}
	}

	public static void dropTB() {
		String query = "drop table addrbook";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			checkError(e);

		}
	}

	public static void insertDT() {
		String query = "insert into k_user values" + "(0, '양화영', 100, 'hong@naver.com', '010-1111-1111', '서울', now())";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void randDt() {
		String[] name = { "김화영", "이화영", "박화영", "최화영", "한화영" };
		int[] age = { 100, 10, 30, 50, 70 };
		String[]email = {"kim@naver.com","lee@naver.com","park@naver.com","choi@naver.com","han@naver.com"};
		
	}

	public static void viewDT() {

	}

	public static void checkError(SQLException e) {
		switch (e.getErrorCode()) {
		case 1050:
			System.out.println("테이블이 이미 존재합니다");
			break;
		case 1051:
			System.out.println("삭제할 테이블이 존재하지 않습니다");
			break;
		}
	}
}