using QuanLyThuVien_1.DataAccessLayer;
using QuanLyThuVien_1.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_1.BusinessLogicLayer
{
    class Bus
    {

        //thu thu 
        public static DataTable GetListThuthu()
        {
            return Dao.GetListThuthu();
        }

        public static int Insert(ThuThu1 tt)
        {
            return Dao.Insert(tt);
        }

        public static int Update(ThuThu1 tt)
        {
            return Dao.Update(tt);
        }

        public static int Delete(ThuThu1 tt)
        {
            return Dao.Delete(tt);
        }

        public static DataTable SearchTT(string ten)
        {
            return Dao.SearchTT(ten);
        }

        //sach

        public static DataTable GetListSach()
        {
            return Dao.GetListSach();
        }


        public static DataTable GetListTheloai()
        {
            return Dao.GetListTheloai();
        }

        public static int InsertSach(Sach1 sach)
        {
            return Dao.InsertSach(sach);
        }

        public static int UpdateSach(Sach1 sach)
        {
            return Dao.UpdateSach(sach);
        }

        public static int DeleteSach(Sach1 sach)
        {
            return Dao.DeleteSach(sach);
        }

        public static DataTable SearchSach(string ten)
        {
            return Dao.SearchSach(ten);
        }


        //doc gia

        


        //the loai
        public static DataTable GetListTheLoai()
        {
            return Dao.GetListTheloai();
        }

        //nhà xuất bản
        public static DataTable GetListNhaXB()
        {
            return Dao.GetListNhaXB();
        }


        //thẻ độc giả
        


        //phieus mượn trả

       

        

        // chi tiết phiếu mượn trả
        

        //admin
        public static int InsertAdmin(Admin admin)
        {
            return Dao.InsertAdmin(admin);
        }

        public static int UpdateAdmin(Admin admin)
        {
            return Dao.UpdateAdmin(admin);
        }
    }
}
