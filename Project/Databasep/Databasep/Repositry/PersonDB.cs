using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Databasep.Repositry;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace Databasep.Repositry
{
    class PersonDB
    {
        OleDbConnection connection = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=system;password=ali;Unicode=True");
        public void register(Person obj) {

            var cmd = "insert into HR.register(STUDENTNO,ROOMNO,STUDENTNM,DT,STUDYIN,FLOOR,B_DT,B_GRP,INST_NM,GUARDIAN,GRELATION,OCCUPATION,PHONE,MOBILE,EMAIL,GPHONE,GADDRESS,ADDRESS) values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
            using (connection)
            {
                using (OleDbCommand command = new OleDbCommand(cmd, connection))
                {

                    command.Parameters.Add("STUDENTNO", OleDbType.Numeric, 3).Value = obj.SNo;
                    command.Parameters.Add("ROOMNO", OleDbType.LongVarChar, 8).Value = obj.RmNo;
                    command.Parameters.Add("STUDENTNM", OleDbType.LongVarChar, 20).Value = obj.Sname;
                    command.Parameters.Add("DT", OleDbType.LongVarChar, 15).Value = obj.date;
                    command.Parameters.Add("STUDYIN", OleDbType.LongVarChar, 20).Value = obj.Dept;
                    command.Parameters.Add("FLOOR", OleDbType.LongVarChar, 6).Value = obj.floor;
                    command.Parameters.Add("B_DT", OleDbType.LongVarChar, 50).Value = obj.B_dt;
                    command.Parameters.Add("B_GRP", OleDbType.LongVarChar, 4).Value = obj.B_group;
                    command.Parameters.Add("INST_NM", OleDbType.LongVarChar, 20).Value = obj.Institute;
                    command.Parameters.Add("GUARDIAN", OleDbType.LongVarChar, 20).Value = obj.GName;
                    command.Parameters.Add("GRELATION", OleDbType.LongVarChar, 10).Value = obj.GRelation;
                    command.Parameters.Add("OCCUPATION", OleDbType.LongVarChar, 10).Value = obj.GOccup;
                    command.Parameters.Add("PHONE", OleDbType.Numeric).Value = obj.Ph;
                    command.Parameters.Add("MOBILE", OleDbType.Numeric, 11).Value = obj.mobile;
                    command.Parameters.Add("EMAIL", OleDbType.LongVarChar, 40).Value = obj.email;
                    command.Parameters.Add("GPHONE", OleDbType.Numeric, 3).Value = obj.Gphone;
                    command.Parameters.Add("GADDRESS", OleDbType.LongVarChar, 50).Value = obj.GAdd;
                    command.Parameters.Add("ADDRESS", OleDbType.LongVarChar, 50).Value = obj.address;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void addUser(Person obj) {

            var cmd = "insert into HR.login(user_id,password,hint)values(?,?,?)";
            using (connection) {
                using (OleDbCommand command = new OleDbCommand(cmd, connection)) {
                    command.Parameters.Add("user_id", OleDbType.VarChar).Value = obj.adduser_id;
                    command.Parameters.Add("password", OleDbType.VarChar).Value = obj.addPass;
                    command.Parameters.Add("hint", OleDbType.VarChar).Value = obj.addhint;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }

        }

        public void addvisitor(Person obj)
        {
            var cmd = "insert into HR.Visitor_info(ROOMNO,DT,STUDENTNM,VISNAME,SEX,RELATION,TIMEIN,TIMEOUT,ADDRESS,CITY,PHONE)values(?,?,?,?,?,?,?,?,?,?,?)";
            using (connection)
            {
                using (OleDbCommand command = new OleDbCommand(cmd, connection))
                {
                    command.Parameters.Add("ROOMNO", OleDbType.VarChar).Value = obj.vis_rm;
                    command.Parameters.Add("DT", OleDbType.VarChar).Value = obj.vis_date;
                    command.Parameters.Add("STUDENTNM", OleDbType.VarChar).Value = obj.vis_stdnt;
                    command.Parameters.Add("VISNAME", OleDbType.VarChar).Value = obj.vis_name;
                    command.Parameters.Add("SEX", OleDbType.VarChar).Value = obj.vis_sex;
                    command.Parameters.Add("RELATION", OleDbType.VarChar).Value = obj.vis_relation;
                    command.Parameters.Add("TIMEIN", OleDbType.VarChar).Value = obj.vis_timein;
                    command.Parameters.Add("TIMEOUT", OleDbType.VarChar).Value = obj.vis_timeout;
                    command.Parameters.Add("ADDRESS", OleDbType.VarChar).Value = obj.vis_add;
                    command.Parameters.Add("CITY", OleDbType.VarChar).Value = obj.vis_city;
                    command.Parameters.Add("PHONE", OleDbType.Numeric).Value = obj.vis_ph;
                    


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }
        public void addemploy(Person obj) {
            var cmd = "insert into HR.hemployee_info(EMPNO,EMPNM,SEX,B_DT,QUALIFICATION,ADDRESS,CITY,DESIGNATION,JOINDATE,SALARY,PHONE)values(?,?,?,?,?,?,?,?,?,?,?)";
            using (connection) {
                using (OleDbCommand command = new OleDbCommand(cmd, connection))
                {
                    command.Parameters.Add("EMPNO", OleDbType.VarChar).Value = obj.emp_no;
                    command.Parameters.Add("EMPNM", OleDbType.VarChar).Value = obj.emp_nam;
                    command.Parameters.Add("SEX", OleDbType.VarChar).Value = obj.emp_sex;
                    command.Parameters.Add("B_DT", OleDbType.VarChar).Value = obj.emp_dob;
                    command.Parameters.Add("QUALIFICATION", OleDbType.VarChar).Value = obj.emp_qua;
                    command.Parameters.Add("ADDRESS", OleDbType.VarChar).Value = obj.emp_add;
                    command.Parameters.Add("CITY", OleDbType.VarChar).Value = obj.emp_cit;
                    command.Parameters.Add("DESIGNATION", OleDbType.VarChar).Value = obj.emp_des;
                    command.Parameters.Add("JOINDATE", OleDbType.VarChar).Value = obj.emp_joi;
                    command.Parameters.Add("SALARY", OleDbType.Numeric).Value = obj.emp_sal;
                    command.Parameters.Add("PHONE", OleDbType.Numeric).Value = obj.emp_ph;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                }

        }
        public void addfee(Person obj) {
            var cmd = "insert into HR.Fees(RECEIPTNO,STUDENTNO,DT,FOOD_BILL,TOT_DED,TOTAL_FEES,PAID_FEES,RECEIVED_BY)values(?,?,?,?,?,?,?,?)";
            using (connection)
            {
                using (OleDbCommand command = new OleDbCommand(cmd, connection))
                {
                    command.Parameters.Add("RECEIPTNO", OleDbType.Numeric).Value = obj.f_receipt;
                    command.Parameters.Add("STUDENTNO", OleDbType.Numeric).Value = obj.f_stdno;
                    command.Parameters.Add("DT", OleDbType.VarChar).Value = obj.f_date;
                    command.Parameters.Add("FOOD_BILL", OleDbType.VarChar).Value = obj.f_type;
                    command.Parameters.Add("TOT_DED", OleDbType.Numeric).Value = obj.f_ded;
                    command.Parameters.Add("TOTAL_FEES", OleDbType.Numeric).Value = obj.f_total;
                    command.Parameters.Add("PAID_FEES", OleDbType.Numeric).Value = obj.f_paid;
                    command.Parameters.Add("RECEIVED_BY", OleDbType.VarChar).Value = obj.f_received;
                    
                    

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }

        }
        public void addstatus(Person obj) {
            var cmd = "insert into HR.status1(ROOMNO,STUDENTNM,STATUS,DESCRIPTION,TIMEIN,TIMEOUT,LEAVE_TYPE,DT_FROM,DT_TO,STUDENTNUMBER)values(?,?,?,?,?,?,?,?,?,?)";
            using (connection)
            {
                using (OleDbCommand command = new OleDbCommand(cmd, connection))
                {
                    command.Parameters.Add("ROOMNO", OleDbType.VarChar).Value = obj.s_rmno;
                    command.Parameters.Add("STUDENTNM", OleDbType.VarChar).Value = obj.s_stdname;
                    command.Parameters.Add("STATUS", OleDbType.VarChar).Value = obj.s_status;
                    command.Parameters.Add("DESCRIPTION", OleDbType.VarChar).Value = obj.s_desc;
                    command.Parameters.Add("TIMEIN", OleDbType.VarChar).Value = obj.s_in;
                    command.Parameters.Add("TIMEOUT", OleDbType.VarChar).Value = obj.s_out;
                    command.Parameters.Add("LEAVE_TYPE", OleDbType.VarChar).Value = obj.s_leavetype;
                    command.Parameters.Add("DT_FROM", OleDbType.VarChar).Value = obj.s_from;
                    command.Parameters.Add("DT_TO", OleDbType.VarChar).Value = obj.s_to;
                    command.Parameters.Add("STUDENTNUMBER", OleDbType.Numeric).Value = obj.s_stdno;



                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }
    }
}
