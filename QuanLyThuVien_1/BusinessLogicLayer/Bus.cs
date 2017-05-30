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

       
       


       


       


        //phieus mượn trả

        public static DataTable GetListPhieumuontra()
        {
            return Dao.GetListPhieumuontra();
        }

        public static DataTable SearchPhieumuontra(string ten)
        {
            return Dao.SearchPhieumuontra(ten);
        }

        // chi tiết phiếu mượn trả
        public static DataTable GetListChiTietPM()
        {
            return Dao.GetListChiTietPM();
        }

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
