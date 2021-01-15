using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    class docgiaDAL
    {
        Dataconnection tc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public docgiaDAL()
        {
            tc = new Dataconnection();
        }
        public DataTable getALLdocgia()
        {
            //tạo lệnh sql
            string sql = "SELECT * from docgia";
            //kết nối sql
            SqlConnection con = tc.getconnect();
            //khơi tạo đói tượng lớp sqldata
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

      

       

        public bool Insertdocgia(Docgia a)
        {
            string sql = "INSERT INTO docgia(madg,tendg,ngaysinh,gioitinh,cmnd,diachi,sdt,capnhat) VALUES(@madg,@tendg,@ngaysinh,@gioitinh,@cmnd,@diachi,@sdt,@capnhat)";
            SqlConnection con = tc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@madg", SqlDbType.Char).Value = a.madg;
                cmd.Parameters.Add("@tendg", SqlDbType.NVarChar).Value = a.tendg;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = a.ngaysinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = a.gioitinh;
                cmd.Parameters.Add("@cmnd", SqlDbType.Char).Value = a.cmnd;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = a.diachi;
                cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = a.sdt;
                cmd.Parameters.Add("@capnhat", SqlDbType.NChar).Value = a.capnhat;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool Updatedocgia(Docgia a)
        {
            string sql = "UPDATE docgia SET madg=@madg,tendg=@tendg,ngaysinh=@ngaysinh,gioitinh=@gioitinh,cmnd=@cmnd,diachi=@diachi,sdt=@sdt,capnhat=@capnhat WHERE madg = @madg";
            SqlConnection con = tc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@madg", SqlDbType.Char).Value = a.madg;
                cmd.Parameters.Add("@tendg", SqlDbType.NVarChar).Value = a.tendg;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = a.ngaysinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = a.gioitinh;
                cmd.Parameters.Add("@cmnd", SqlDbType.Char).Value = a.cmnd;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = a.diachi;
                cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = a.sdt;
                cmd.Parameters.Add("@capnhat", SqlDbType.NChar).Value = a.capnhat;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;



       
        }
        public bool DELETEdocgia(Docgia a)
        {
            String sql = "DELETE docgia WHERE madg=@madg";
            SqlConnection con = tc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@madg", SqlDbType.Char).Value = a.madg;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
        public DataTable Finddocgia(string s)
        {
            string sql = "SELECT * FROM docgia WHERE madg like '%" + s + "%' or tendg like '%" + s + "%'";
            //kết nối sql
            SqlConnection con = tc.getconnect();
            //khơi tạo đói tượng lớp sqldata
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
