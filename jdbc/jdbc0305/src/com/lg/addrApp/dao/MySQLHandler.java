package com.lg.addrApp.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

import com.lg.addrApp.model.AddrBook;

public class MySQLHandler {
	//static 뺀 이유 : 객체지향은 인스턴스 클래스를 말하는거기때문에 
	//(인스턴스변수와 클래스변수 차이 : 인스턴스는 객체생성 , 클래스변수는 객체생성 없이 사용 가능)
	
	Connection con; // db에 접속하기 위한것
	Statement state;
	final String USER_ID = "root";
	final String USER_PW = "1126";
	final String DBNAME = "mydb";
	String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	
	public MySQLHandler() { //캡슐화  MySQLHandler객체가 실행될때 자동으로 connectDB 실행
		connectDB();
	}
	
	public void connectDB() {
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
	
	public void closeDB() {
		try {
			state.close();
			con.close();
			System.out.println("DB접속 해제");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public void createTB() {
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

	public void dropTB() {
		String query = "drop table addrbook";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			checkError(e);

		}
	}

	public void insertDB() {
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
	
	public void insertDB(AddrBook ab) {
		String query2 = String.format("insert into addrbook(name, age, tel, address, email, date)"
				+"values('%s',%d,'%s','%s','%s', now())",ab.getName(),ab.getAge(),ab.getTel(),ab.getAddress(),ab.getEmail());
		try {
			state.executeUpdate(query2);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public void checkError(SQLException e) {
		switch (e.getErrorCode()) {
		case 1050:
			System.out.println("테이블이 이미 존재합니다");
			break;
		case 1051:
			System.out.println("삭제할 테이블이 존재하지 않습니다");
			break;
		}
	}
	
	public void updateDT(Scanner s) {
		
	
		System.out.println("---------------------");
		System.out.println("변경할 아이디와 항목을 선택하세요");
		System.out.println("---------------------");
		System.out.println("1.이름");
		System.out.println("2.나이");
		System.out.println("3.전화번호");
		System.out.println("4.주소");
		System.out.println("5.이메일");
		
		switch (s.nextInt()){
			case 1:
				System.out.print("변경전 이름 : ");
			      String bfdb = s.next();
			      System.out.print("바꿀 이름: ");
			      String afdb = s.next();
			      
			      String query = String.format("update addrbook set name='%s' where name='%s'", afdb, bfdb); 
			      try {
						state.executeUpdate(query);
					} catch (SQLException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				break;
			case 2:
					System.out.print("변경전 나이 : ");
				      String bfage = s.next();
				      System.out.print("바꿀 나이: ");
				      String afage = s.next();
				      
				      String query2 = String.format("update addrbook set age='%s' where age='%s'", afage, bfage); 
				      try {
							state.executeUpdate(query2);
						} catch (SQLException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
						}
					break;
				case 3:
						System.out.print("변경전 전화번호 : ");
					      String bfnb = s.next();
					      System.out.print("바꿀 전화번호: ");
					      String afnb = s.next();
					      
					      String query3 = String.format("update addrbook set tel='%s' where tel='%s'", afnb, bfnb); 
					      try {
								state.executeUpdate(query3);
							} catch (SQLException e) {
								// TODO Auto-generated catch block
								e.printStackTrace();
							}
						break;
				case 4:
					System.out.print("변경전 주소 : ");
				      String bfad = s.next();
				      System.out.print("바꿀 주소: ");
				      String afad = s.next();
				      
				      String query4 = String.format("update addrbook set address='%s' where address='%s'", afad, bfad); 
				      try {
							state.executeUpdate(query4);
						} catch (SQLException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
						}
					break;
				case 5:
					System.out.print("변경전 전화번호 : ");
				      String bfml = s.next();
				      System.out.print("바꿀 전화번호: ");
				      String afml = s.next();
				      
				      String query5 = String.format("update addrbook set email='%s' where email='%s'", afml, bfml); 
				      try {
							state.executeUpdate(query5);
						} catch (SQLException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
						}
					break;
				
		}
	}
		
		
		
		
//		System.out.print("변경전 이름 : ");
//	      String bfdb = s.next();
//	      System.out.print("바꿀 이름: ");
//	      String afdb = s.next();
//	      
//	      String query = String.format("update addrbook set name='%s' where name='%s'", afdb, bfdb); 
//	      try {
//				state.executeUpdate(query);
//			} catch (SQLException e) {
//				// TODO Auto-generated catch block
//				e.printStackTrace();
//			}
//	}
	
	public void del_table(Scanner s) {
		System.out.print("삭제할 테이블 번호:");
		int id = s.nextInt();
		String query = String.format("delete from addrbook where id='%d'", id);
		 try {
				state.executeUpdate(query);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
	}

	
	public void viewDT() {
		String query = "select * from AddrBook";
		ResultSet rs;
		try {
			rs = state.executeQuery(query);
			if(rs !=null) {
				rs = state.getResultSet();
				int count = 0;
				while (rs.next()) {
					// System.out.print(count+"\t");
					System.out.print(rs.getString("id")+"\t");
					System.out.print(rs.getString("name")+"\t");
					System.out.print(rs.getString("age")+"\t");
					System.out.print(rs.getString("email")+"\t");
					System.out.print(rs.getString("tel")+"\t");
					System.out.print(rs.getString("address")+"\t");
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
