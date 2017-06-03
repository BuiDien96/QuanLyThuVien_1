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
       

        //độc giả

        public static DataTable GetListDocGia()
        {
            return DataProvider.GetData("select * from docgia");
        }

        public static int InsertDG(DocGia1 dg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madg", dg.madg),
                new SqlParameter("@tendg", dg.tendg),
                new SqlParameter("@ngaysinh", dg.ngaysinh),
                new SqlParameter("@gioitinh", dg.gioitinh),
                new SqlParameter("@diachi", dg.diachi)
            };
            return DataProvider.ExecuteNonQuery("themdocgia", para);
        }

        public static int UpdateDG(DocGia1 dg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madg", dg.madg),
                new SqlParameter("@tendg", dg.tendg),
                new SqlParameter("@ngaysinh", dg.ngaysinh),
                new SqlParameter("@gioitinh", dg.gioitinh),
                new SqlParameter("@diachi", dg.diachi)
            };
            return DataProvider.ExecuteNonQuery("suadocgia", para);
        }

        public static int DeleteDG(DocGia1 dg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madg", dg.madg)

            };
            return DataProvider.ExecuteNonQuery("xoadocgia", para);
        }

        public static DataTable SearchDG(string ten)
        {
            return DataProvider.GetData("select * from docgia " + ten);
        }



        

        //thẻ độc giả
        public static DataTable GetListThedg()
        {
            return DataProvider.GetData(" select * from thedocgia ");
        }

        public static DataTable SearchThedg(string ten)
        {
            return DataProvider.GetData("select * from thedocgia " + ten);
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
