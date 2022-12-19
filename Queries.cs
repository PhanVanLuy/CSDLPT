using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT
{
    class Queries
    {
        // ĐĂNG NHẬP
        public static string LAY_THONG_TIN_SV_DANG_NHAP = "EXEC [dbo].[SP_LayThongTinSV_DangNhap] '{0}' , '{1}' ";
        public static string LAY_THONG_TIN_GV_DANG_NHAP = "EXEC [dbo].[SP_Lay_Thong_Tin_GV_Tu_Login] '{0}' ";
        public static string DANG_NHAP = "SELECT * FROM [DBO].[Get_Subscribes]";
        public static string TAO_LOGIN = " EXEC @return_value = [dbo].[SP_TAOLOGIN] @LGNAME = N'{0}', @PASS = N'{1}',  @USERNAME = N'{2}', @ROLE = N'{3}' ";
        

        // THI
        public static string LAY_THONG_TIN_CHI_TIET_LAN_THI = "EXEC sp_chitietlanthi N'{0}', N'{1}', {2}";
        public static string KT_LAN_THI = "exec sp_ktlanthi '{0}', '{1}', {2}";
        public static string GHI_DIEM_SV = "UPDATE dbo.BANGDIEM SET DIEM = {0} WHERE MASV = '{1}' AND MAMH = '{2}' AND LAN = {3}" ;
        public static string GHI_BAI_THI_SV = "UPDATE dbo.BAITHI SET DACHON = '{0}' WHERE CAUHOI = {1}  ";
        public static string SV_THI = "exec SP_BAITHI '{0}','{1}','{2}', {3}";
        public static string GV_THI_THU = "exec SP_BAITHI '{0}','{1}',{2}";
        
        // XỬ LÝ THÔNG TIN KHÁC
        public static string XOA_GIANG_VIEN = "DELETE from dbo.GIAOVIEN WHERE MAGV = '{0}'";


        //SINH VIÊN
        public static string LAY_THONG_TIN_SV_THI = "SELECT LOP.MALOP, TENLOP FROM dbo.LOP JOIN dbo.SINHVIEN ON SINHVIEN.MALOP = LOP.MALOP WHERE MASV = '{0}'";
        public static string CHECK_TRUNG_GV = "DECLARE @return_value INT " +

                            " EXEC @return_value = [dbo].[SP_CHECKID] " +

                            " @Code = N'{0}',  " +

                            " @Type = N'MAGV' " +

                            " SELECT  'Return Value' = @return_value ";


    }
}
