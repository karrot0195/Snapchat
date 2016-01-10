using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SnapChat.PlugIns
{
    class QL
    {

        //Danh sách chứa thể hiện của các nhận vật
        public static List<ChucNang> DsChucNang = new List<ChucNang>();
        public static void clear()
        {
            DsChucNang = new List<ChucNang>();
        }
        /// <summary>
        /// Lấy các thể hiện của nhận vật từ các file Dll phù hợp
        /// </summary>
        /// <param name="Duong_dan">Đường dẫn chứa PlugIn</param>
        public static void Lay_Chuc_Nang(string Duong_dan)
        {
            //Duyệt qua tất cả các tập tin trong thư mục
            foreach (string Tap_tin in Directory.GetFiles(Duong_dan))
            {
                //Tạo biến giữ thông tin file
                FileInfo file = new FileInfo(Tap_tin);
                //Nếu file có đuôi là dll thì ok
                if (file.Extension.Equals(".dll"))
                {
                    //Thêm nhân vật vào danh sách NV
                    DsChucNang.Add(The_hien_Chuc_Nang(Tap_tin));
                }
            }
        }

        //Chuyển một file Dll phù hợp thành một thể hiện nhân vật
        public static ChucNang The_hien_Chuc_Nang(string Tap_tin)
        {
            ChucNang cn = new ChucNang();

            //Nạp thông tin của một file Dll vào
            //Do đã kiểm tra phần mở rộng là Dll
            //Muốn tìm hiểu về Assembly->MSDN
            Assembly asm = Assembly.LoadFile(Tap_tin);

            //Một asm sẽ chứa nhiều kiểu(Type) khác nhau
            //Duyệt qua từng kiểu(Type) trong tập hợp kiểu(asm.GetTypes())
            foreach (Type Loai in asm.GetTypes())
            {
                //Chọn kiểu mà có chứa giao diện Interface mà chúng ta đã cài đặt trước
                //Điều này rất quan trọng nếu bạn ko kiểm tra sẽ xảy ra lỗi
                Type Loai_Interface = Loai.GetInterface("IChucNang.IChucNang", true);
                if (Loai_Interface != null)//Có Interface phù hợp
                {
                    //Phần quan trọng nhất là ở đây
                    //asm.GetType(Loai_nhan_vat.ToString()) : Lấy kiểu từ một chuỗi
                    //Activator.CreateInstance : Tạo thể hiện từ một kiểu chi định
                    //Vì đã kiểm tra Loai_Interface nên ta có thể ép kiểu ở đây
                    cn.Chucnang = (IChucNang.IChucNang)Activator.CreateInstance(asm.GetType(Loai.ToString()));
                }
            }

            return cn;
        }
    }
}
