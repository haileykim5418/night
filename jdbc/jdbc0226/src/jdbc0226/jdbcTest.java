package jdbc0226;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class jdbcTest {
	static Connection con;  //db에 접속하기 위한것
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static Statement state;
	static final String DBNAME = "mydb";
	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	static String dbUrl = "jdbc:mysql://localhost/" +
			DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	
			
	public static void main(String[] args) {
		connectDB();
		insertDB();
		showDB();
		closeDB();

	}
	public static void connectDB() {
		try {
			Class.forName(jdbcDriver).newInstance();
			con = DriverManager.getConnection(dbUrl,USER_ID,USER_PW);
			if(con != null) {
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
	public static void insertDB() {
 		String query = "insert into k_user values" + "(0, '홍길동', 100, 'hong@naver.com', '010-1111-1111', '조선 한양', now())";
		String name = "전우치";
		int age = 200;
		String email = "jeon@kakao.com";
		String tel = "010-1111-1111";
		String addr = "조선 두메산골";
		String query2 = String.format("insert into k_user(user_nm, user_age, email, user_phone, user_addr)"
				+"values('%s',%d,'%s','%s','%s')",name,age,email,tel,addr);
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	public static void showDB() {
		String query = "select * from k_user";
		ResultSet rs;
		try {
			rs = state.executeQuery(query);
			if(rs !=null) {
				rs = state.getResultSet();
				int count = 0;
				while (rs.next()) {
					System.out.print(count+"\t");
					System.out.print(rs.getString("user_nm")+"\t");
					System.out.print(rs.getString("user_age")+"\t");
					System.out.print(rs.getString("email")+"\t");
					System.out.print(rs.getString("user_phone")+"\t");
					System.out.print(rs.getString("user_addr")+"\t");
					System.out.println(rs.getString(7));
					count++;			
				}
				rs.close();
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
