namespace ParameterRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 69;
            PlayWitRef(ref y);  //ref ko cho khai báo inline
            //Chơi với ref không chắc kèo có giá trị trả về khi gọi hàm ref.
            //Do đó trước khi gọi, phòng hờ biến ref = 1 giá trị mặc định.
            //Nếu hàm không trả về, biến = mặc định.
            //Nếu hàm có trả về, biến = trả về.
            Console.WriteLine("y after calling ref function: " + y);
        }

        //out: hứa sẽ có giá trị trả về trong hàm, chắc kèo có lệnh gán giá trị!!!
        //     khi gọi hàm không cần đưa value vào, vì bản chất là dùng hứng giá trị trả về

        //ref: ko hứa sẽ có trả về, ko ép phải có trả về, thích làm thì làm, ko thích thì thôi

        public static void PlayWitRef(ref int x)
        {
            //x = 70;
        }
    }
}
//OUT, REF: GIỐNG NHAU Ở: BÊN TRONG HÀM THAY ĐỔI; BÊN NGOÀI HÀM ĐỔI THEO
//          OUT: HỨA CÓ TRẢ VỀ, KO CẦN ĐƯA ĐẦU VÀO, XÀI INLINE LUÔN
//          REF: KO HỨA CÓ TRẢ VỀ, NÊN CẦN CÓ DEFAULT TRƯỚC KHI GỌI REF
//TRUYỀN THAM CHIẾU: TRONG HÀM THAY ĐỔI, BÊN NGOÀI ĐỔI THEO - PASS BY REFERENCE

/*
 * HỌC ĐƯỢC CÚ PHÁP NGÔN NGỮ CỦA C# NÓ RÂT GIỐNG VỚI JAVA
 * STRING THÌ HOA THƯỜNG ĐỀU ĐƯỢC NHƯ NHAU
 * GHÉP CHUỖI: 
 * + CONCATINATION 
 * + PLACEHOLDER: {0}
 * + INTERPOLATION: ${value}
 * + Verbatim: @
 * ĐÓNG GÓI 1 CÁI PROJECT THÀNH DLL 
 * VÀ ADD REFERENCE
 * - HỌC CÁCH LÀM DOCUMENT THÔNG QUA: ///summary CHO 1 CÁI THƯ VIỆN, API MÌNH TỰ XÂY DỰNG RA
 * - HỌC OUT, REF
 * - NAMESPACE PACKAGE
 * - CÁC CLASS NẰM TRONG CÙNG PACKEAGE: PHẢI NẰM TRONG CÁC NAMESPACE KHÁC NHAU
 * - CLASS CÓ THỂ VIẾT TRONG CÙNG TẬP TIN VẬT LÝ ĐỘC LẬP || CLASS NÊN TÁCH THÀNH CÁC TẬP TIN RIÊNG ĐỂ NHÌN CẤU TRÚC THƯ MỤC DỄ QUẢN LÝ
 * - .NET SDK, LỊCH SỬ .NET
 */