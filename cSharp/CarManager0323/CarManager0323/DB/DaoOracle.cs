using CarManager0323.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.DB
{
    class DaoOracle
    {
        const string CONNECT_ERR = "DB접속";
        const string DISCONNECT_ERR = "접속 해제";
        const string CREATE_TB_ERR = "테이블+시퀀스 생성";
        const string DROP_TB_ERR = "테이블+시퀀스 삭제";

        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
                "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));" +
                "User Id=c##scott;Password=1126";

        OracleConnection conn;
        OracleCommand cmd;

        public DaoOracle()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        ~DaoOracle() //객체가 파괴될때 호출된다는 의미
        {
            dbClose();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                errorMsg(CONNECT_ERR, e);
            }
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제");
            }
            catch (OracleException e)
            {
                errorMsg(DISCONNECT_ERR, e);
            }
        }

        public void createTable()
        {
            try
            {
                string query = "create table testTB (" + "id number not null," + "name varchar(20) not null," +
                                "age number not null," + "constraint pk_testTB_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence seq_testTB_id " + "increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블,시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void errorMsg(string msg, OracleException e)
        {
            Console.WriteLine(msg + ":에러번호" + e.Number);
            Console.WriteLine(msg + ":에러코드" + e.ErrorCode.ToString());
            Console.WriteLine(msg + ":에러내용" + e.Message);
        }

        public void makeTbCustomer()
        {
            try
            {
                string query = "create table customer (" +
                    "c_number INT NOT NULL," +
                    "c_name VARCHAR2(20) NOT NULL," +
                    "c_tel VARCHAR2(20) NOT NULL," +
                    "c_address VARCHAR2(50) NOT NULL," +
                    "c_mail VARCHAR2(40) NOT NULL," +
                    "CONSTRAINT CUSTOMER_PK PRIMARY KEY(c_number))";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE customer_SEQ START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("customer 테이블,시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbCar()
        {
            try
            {
                string query = "create table car(" +

            "car_number INT NOT NULL," +
             "car_model VARCHAR2(20) NOT NULL," +
             "car_price VARCHAR2(20) NOT NULL," +
             "car_color VARCHAR2(20) NOT NULL," +
             "car_manu VARCHAR2(20) NOT NULL," +
             "car_year VARCHAR2(20) NOT NULL," +
             "CONSTRAINT CAR_PK PRIMARY KEY(car_number))";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE car_SEQ START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("car 테이블,시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbSeller()
        {
            try
            {
                string query = "create table salesman (" +
                "em_number INT NOT NULL," +
                "em_name VARCHAR2(20) NOT NULL," +
                "em_tel VARCHAR2(20) NOT NULL," +
                "em_mail VARCHAR2(20) NOT NULL," +
                "em_pos VARCHAR2(20) NOT NULL," +
                "em_branch VARCHAR2(20) NOT NULL," +
                "CONSTRAINT SALESMAN_PK PRIMARY KEY(em_number))";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE salesman_SEQ START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("salesman 테이블,시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbDeal()
        {
            try
            {
                string query = "create table deal (" +
                "de_number INT NOT NULL, " +
                "de_date DATE NOT NULL," +
                "em_number INT NOT NULL, " +
                "car_number INT NOT NULL," +
                "c_number INT NOT NULL," +
                "CONSTRAINT DEAL_PK PRIMARY KEY(de_number, em_number, c_number)," +
                "CONSTRAINT FK_deal_c_number_customer_c_nu FOREIGN KEY (c_number)" +
                "REFERENCES customer(c_number)," +
                "CONSTRAINT FK_deal_car_number_car_car_num FOREIGN KEY(car_number)" +
                "REFERENCES car(car_number)," +
                "CONSTRAINT FK_deal_em_number_salesman_em_ FOREIGN KEY(em_number)" +
                "REFERENCES salesman(em_number))";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE deal_SEQ START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("deal 테이블,시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void dropTable()
        {
            try
            {
                string query = "drop table testTB";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "drop sequence seq_testTB_id";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블,시퀀스 삭제 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(DROP_TB_ERR, e);
            }
        }

        public void dropTable(string tb, string seq)
        {
            try
            {
                string query = "drop table " + tb;
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "drop sequence " + seq;
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블,시퀀스 삭제 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(DROP_TB_ERR, e);
            }
        }

        public void createAllTB()
        {
            makeTbCar();
            makeTbCustomer();
            makeTbSeller();
            makeTbDeal();
        }

        public void dropALLTB()
        {
            dropTable("deal", "deal_seq");
            dropTable("customer", "customer_seq");
            dropTable("car", "car_seq");
            dropTable("salesman", "salesman_seq");

        }

        public void insertCar()
        {
            try
            {
                string sql = "insert into car values (deal_SEQ.nextval," +
                 "'그랜저','40000000','은색','현대','2021년')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCar()", e);
            }
        }

        public void insertCar(Car car)
        {
            try
            {
                /*string sql = "insert into car values (deal_SEQ.nextval," +
                 "'그랜저','40000000','은색','현대','2021년')";*/
                string sql = string.Format("insert into car values(deal_SEQ.nextval, " +
                 "'{0}',{1},'{2}','{3}','{4}')", car.Model, car.Price, car.Color, car.Manu, car.Year);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCar()", e);
            }
        }

        public void insertsalesman()
        {
            try
            {
                string sql = "insert into salesman values (salesman_SEQ.nextval," +
                 "'김철수','010-1111-1111','kim@hyundai.com','대리','동대구영업소')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertSalesman()", e);
            }
        }
        public void insertsalesman(Seller seller)
        {
            try
            {
                string sql = string.Format("insert into salesman values(salesman_SEQ.nextval, " +
                 "'{0}','{1}','{2}','{3}','{4}')", seller.Name, seller.Tel, seller.Position, seller.Email, seller.Branch);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertSalesman()", e);
            }
        }

        public void insertCustomer()
        {
            try
            {
                string sql = string.Format("insert into customer values (customer_SEQ.nextval," +
                 "'김순자','010-1111-1234','대구 동구 신천동','kimsj@naver.com')");
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCar()", e);
            }
        }

        public void insertCustomer(Customer cust) 
        {
            try
            {
                string sql = String.Format("insert into customer values (customer_SEQ.nextval," +
                 "'{0}','{1}','{2}','{3}')",
                 cust.Name, cust.Tel, cust.Addr, cust.Email);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer(cust)", e);
            }
        }

        public void insertDeal()
        {
            try
            {
                string sql1 = "insert into deal (de_number, de_date, em_number, car_number, c_number)" +
                    "(select deal_SEQ.nextval, sysdate," +
                    "s.em_number, ca.car_number, cu.c_number" +
                   " from salesman s, natural join customer cu" +
                   "natural join car ca " +
                   "where cu.c_name='김순자' and ca.car_model = '그랜저'" +
                    "and s.em_name = '김철수')";

                cmd.Connection = conn;
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertDeal()", e);
            }
        }

        public void insertDeal(Deal deal)
        {
            try
            {
                string sql1 = string.Format("insert into deal (de_number, de_date, em_number, car_number, c_number) " +
                   "(select deal_seq.nextval, sysdate, " +
                   "s.em_number, ca.car_number, cu.c_number " +
                   "from salesman s natural join car ca " +
                   "natural join customer cu " +
                   "where ca.car_model='{0}' and cu.c_name='{1}'" +
                   "and s.em_name='{2}')",
                    deal.Car.Model,
                    deal.Customer.Name,
                    deal.Seller.Name);
                cmd.Connection = conn;
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertDeal()", e);
            }
        }

        public void insertDeal(Seller seller, Car car, Customer cust)
        {
            try
            {
                string sql1 = string.Format("insert into deal values (DEAL_SEQ.nextval, sysdate," +
            "(select em_number from salesman where em_name = '{0}'and em_tel = '{1}')," +
            "(select car_number from car where car_model = '{2}' and car_price = '{3}')," +
            "(select c_number from customer where c_name = '{4}'and c_tel = '{5}'))",
                    seller.Name, seller.Tel,
                    car.Model, car.Price,
                    cust.Name, cust.Tel);
                cmd.Connection = conn;
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertDeal()", e);
            }
        }

        public List<DealResult> selectDeal()
        {
            List<DealResult> dResultList = new List<DealResult>();
            try
            {
                int count = 1;
                string query = "select cu.c_name, ca.car_model, ca.car_price," +
                  "sa.em_name, d.de_date " +
                  "from deal d, car ca, customer cu, salesman sa " +
                  "where d.car_number = ca.car_number and d.c_number = cu.c_number " +
                  "and d.em_number = sa.em_number";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("번호 : " + count);
                        Console.WriteLine("고객명 : " + reader["c_name"]);
                        Console.WriteLine("모델 : " + reader["car_model"]);
                        string price = reader["car_price"].ToString();
                        double dPrice = Convert.ToDouble(price);
                        NumberFormatInfo numFormat = new CultureInfo("ko-KR", false).NumberFormat;
                        price = dPrice.ToString("c", numFormat);
                        Console.WriteLine("가격 : " + price);
                        Console.WriteLine("판매자 : " + reader["em_name"]);
                        Console.WriteLine("구매 날짜 : " + reader["de_date"]);
                        Console.WriteLine("----------------------------");
                        DealResult dResult = new DealResult(count,
                            reader["c_name"].ToString(),
                        reader["car_model"].ToString(),
                       price,
                        reader["em_name"].ToString(),
                        reader["de_date"].ToString());
                        dResultList.Add(dResult);
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }

            catch (OracleException e)
            {
                errorMsg("selectDeal()", e);
            }
            return dResultList;
        }
    }
}