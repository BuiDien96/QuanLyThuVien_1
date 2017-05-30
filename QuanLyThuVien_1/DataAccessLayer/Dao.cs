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
        

        



        //phiếu mượn trả
        public static DataTable GetListPhieumuontra()
        {
            return DataProvider.GetData("select * from phieumuontra ");
        }


        public static DataTable SearchPhieumuontra(string ten)
        {
            return DataProvider.GetData("select * from phieumuontra " + ten);
        }


        //chi tiết  phiếu mượn trả
        public static DataTable GetListChiTietPM()
        {
            return DataProvider.GetData("select * from chitietphieumuon ");
        }


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
