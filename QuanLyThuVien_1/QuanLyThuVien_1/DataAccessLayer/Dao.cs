using QuanLyThuVien_1.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_1.DataAccessLayer
{
    class Dao
    {
        //thu thu

        public static DataTable GetListThuthu()
        {
            return DataProvider.GetData("select * from thuthu");
        }

        public static int Insert(ThuThu1 tt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matt", tt.matt),
                new SqlParameter("@tentt", tt.tentt),
                new SqlParameter("@ngaysinh", tt.ngaysinh),
                new SqlParameter("@diachi", tt.diachi),
                new SqlParameter("@sdt", tt.sdt),

            };
            return DataProvider.ExecuteNonQuery("themthuthu", para);
        }

        public static int Update(ThuThu1 tt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matt", tt.matt),
                new SqlParameter("@tentt", tt.tentt),
                new SqlParameter("@ngaysinh", tt.ngaysinh),
                new SqlParameter("@diachi", tt.diachi),
                new SqlParameter("@sdt", tt.sdt),
            };
            return DataProvider.ExecuteNonQuery("suathuthu", para);
        }

        public static int Delete(ThuThu1 tt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matt", tt.matt)

            };
            return DataProvider.ExecuteNonQuery("xoathuthu", para);
        }

        public static DataTable SearchTT(string ten)
        {
            return DataProvider.GetData("select * from thuthu " + ten);
        }


        //sách

        public static DataTable GetListSach()
        {
            return DataProvider.GetData("select * from sach ");
        }


        public static DataTable GetListTheloai()
        {
            return DataProvider.GetData("select * from theloai ");
        }

        public static int InsertSach(Sach1 sach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach", sach.masach),
                new SqlParameter("@tensach", sach.tensach),
                new SqlParameter("@tinhtrang", sach.tinhtrang),
                new SqlParameter("@matt", sach.matt),
                new SqlParameter("@manxb ", sach.manxb),
                new SqlParameter("@matl", sach.matl)
            };
            return DataProvider.ExecuteNonQuery("themsach", para);
        }

        public static int UpdateSach(Sach1 sach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach", sach.masach),
                new SqlParameter("@tensach", sach.tensach),
                new SqlParameter("@tinhtrang", sach.tinhtrang),
                new SqlParameter("@matt", sach.matt),
                new SqlParameter("@manxb ", sach.manxb),
                new SqlParameter("@matl", sach.matl)
            };
            return DataProvider.ExecuteNonQuery("susach", para);
        }

        public static int DeleteSach(Sach1 sach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach", sach.masach)

            };
            return DataProvider.ExecuteNonQuery("xoasach", para);
        }

        public static DataTable SearchSach(string ten)
        {
            return DataProvider.GetData("select * from sach " + ten);
        }


        //độc giả

       



        //thể loại 
        public static DataTable GetListTheLoai()
        {
            return DataProvider.GetData("select * from theloai ");
        }


        //nhà xuất bản
        public static DataTable GetListNhaXB()
        {
            return DataProvider.GetData("select * from nhaxuatban");
        }

        //thẻ độc giả
        

        //phiếu mượn trả
        


        //chi tiết  phiếu mượn trả
        


        //admin
        public static int InsertAdmin(Admin admin)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@name", admin.name),
                new SqlParameter("@pass", admin.pass),
                new SqlParameter("@diachi", admin.diachi),
                new SqlParameter("@ngaysinh", admin.ngaysinh),
                new SqlParameter("@email", admin.email),
                new SqlParameter("@sdt", admin.sdt)
            };
            return DataProvider.ExecuteNonQuery("themadmin", para);
        }

        public static int UpdateAdmin(Admin admin)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@name", admin.name),
                new SqlParameter("@pass", admin.pass),

            };
            return DataProvider.ExecuteNonQuery("suaAdmin1", para);
        }
    }
}
