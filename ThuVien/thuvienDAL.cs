using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    class thuvienDAL
    {
        Dataconnection tc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public thuvienDAL()
        {
            tc = new Dataconnection();
        }
        public DataTable getALLsach()
        {
            //tạo lệnh sql
            string sql = "SELECT * from sach";
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

        public bool Insertsach(Tvien s)
        {
            string sql = "INSERT INTO sach(masach,tensach,theloai,mota,namxb,nhaxuatban,tacgia,soluong,capnhat) VALUES(@masach,@tensach,@theloai,@mota,@namxb,@nhaxuatban,@tacgia,@soluong,@capnhat)";
            SqlConnection con = tc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@masach", SqlDbType.Char).Value = s.masach;
                cmd.Parameters.Add("@tensach", SqlDbType.NVarChar).Value = s.tensach;
                cmd.Parameters.Add("@theloai", SqlDbType.NVarChar).Value = s.theloai;
                cmd.Parameters.Add("@mota", SqlDbType.NVarChar).Value = s.mota;
                cmd.Parameters.Add("@namxb", SqlDbType.Char).Value = s.namxb;
                cmd.Parameters.Add("@nhaxuatban", SqlDbType.NVarChar).Value = s.nhaxuatban;
                cmd.Parameters.Add("@tacgia", SqlDbType.NVarChar).Value = s.tacgia;
                cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = s.soluong;
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
        public bool Updatesach(Tvien s)
        {
            string sql = "UPDATE sach SET masach= @masach, tensach=@tensach, theloai=@theloai, mota=@mota, namxb=@namxb, nhaxuatban=@nhaxuatban, tacgia=@tacgia, soluong=@soluong, capnhat=@capnhat WHERE masach=@masach";

            SqlConnection con = tc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@masach", SqlDbType.Char).Value = s.masach;
                cmd.Parameters.Add("@tensach", SqlDbType.NVarChar).Value = s.tensach;
                cmd.Parameters.Add("@theloai", SqlDbType.NVarChar).Value = s.theloai;
                cmd.Parameters.Add("@mota", SqlDbType.NVarChar).Value = s.mota;
                cmd.Parameters.Add("@namxb", SqlDbType.Char).Value = s.namxb;
                cmd.Parameters.Add("@nhaxuatban", SqlDbType.NVarChar).Value = s.nhaxuatban;
                cmd.Parameters.Add("@tacgia", SqlDbType.NVarChar).Value = s.tacgia;
                cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = s.soluong;
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
        public bool DELETEsach(Tvien s)
        {
            String sql = "DELETE sach WHERE masach=@masach";
            SqlConnection con = tc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@masach", SqlDbType.Char).Value = s.masach;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
        public DataTable Findsach(string s)
        {
            string sql = "SELECT * FROM sach WHERE masach like '%" + s + "%' or tensach like '%" + s + "%'";
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

