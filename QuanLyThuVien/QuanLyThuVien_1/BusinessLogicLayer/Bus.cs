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

        

       


        //doc gia

        public static DataTable GetListDocGia()
        {
            return Dao.GetListDocGia();
        }

        public static int Update(DocGia1 dg)
        {
            return Dao.UpdateDG(dg);
        }

        public static int InsertDG(DocGia1 dg)
        {
            return Dao.InsertDG(dg);
        }

        public static int DeleteDG(DocGia1 dg)
        {
            return Dao.DeleteDG(dg);
        }

        public static DataTable SearchDG(string ten)
        {
            return Dao.SearchDG(ten);
        }


        


        //thẻ độc giả
        public static DataTable GetListThedg()
        {
            return Dao.GetListThedg();
        }

        public static DataTable SearchThedg(string ten)
        {
            return Dao.SearchThedg(ten);
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
