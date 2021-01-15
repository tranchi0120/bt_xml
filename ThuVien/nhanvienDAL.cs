using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    class nhanvienDAL
    {
        Dataconnection tc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public nhanvienDAL()
        {
            tc = new Dataconnection();
        }
        public DataTable getALLnhanvien()
        {
            //tạo lệnh sql
            string sql = "SELECT * from nhanvien";
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

        public bool Insertnhanvien(Nhanvien s)
        {
            string sql = "INSERT INTO nhanvien(manv,tennv,gioitinh,diachi,cmnd,email,dienthoai,capnhat) VALUES(@manv,@tennv,@gioitinh,@diachi,@cmnd,@email,@dienthoai,@capnhat)";
            SqlConnection con = tc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@manv", SqlDbType.Char).Value = s.manv;
                cmd.Parameters.Add("@tennv", SqlDbType.NVarChar).Value = s.tennv;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = s.gioitinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = s.diachi;
                cmd.Parameters.Add("@cmnd", SqlDbType.Char).Value = s.cmnd;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = s.email;
                cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar).Value = s.dienthoai;
                cmd.Parameters.Add("@capnhat", SqlDbType.NChar).Value = s.capnhat;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool Updatenhanvien(Nhanvien s)
        {
            string sql = "UPDATE nhanvien SET manv= @manv, tennv=@tennv, gioitinh=@gioitinh, diachi=@diachi,email=@email, cmnd=@cmnd, dienthoai=@dienthoai, capnhat=@capnhat WHERE manv=@manv";

            SqlConnection con = tc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@manv", SqlDbType.Char).Value = s.manv;
                cmd.Parameters.Add("@tennv", SqlDbType.NVarChar).Value = s.tennv;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = s.gioitinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = s.diachi;
                cmd.Parameters.Add("@cmnd", SqlDbType.Char).Value = s.cmnd;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = s.email;
                cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar).Value = s.dienthoai;
                cmd.Parameters.Add("@capnhat", SqlDbType.NChar).Value = s.capnhat;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool DELETEnhanvien(Nhanvien s)
        {
            String sql = "DELETE nhanvien WHERE manv=@manv";
            SqlConnection con = tc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@manv", SqlDbType.Char).Value = s.manv;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
        public DataTable Findnhanvien(string s)
        {
            string sql = "SELECT * FROM nhanvien WHERE manv like '%" + s + "%' or tennv like '%" + s + "%'";
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
