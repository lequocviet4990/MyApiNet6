using Microsoft.EntityFrameworkCore;

namespace MyAPI6.Models
{
    public class MovieContext: DbContext
    {


        //  DbContext là lớp chính chịu trách nhiệm tương tác với cơ sở dữ liệu.Nó chịu trách nhiệm cho các hoạt động sau:

        //Truy vấn: Chuyển đổi các truy vấn LINQ-to-Entities thành truy vấn SQL và gửi chúng đến cơ sở dữ liệu.
        //Theo dõi thay đổi: Theo dõi các thay đổi xảy ra trên các thực thể sau khi truy vấn từ cơ sở dữ liệu.
        //Dữ liệu bền vững: Thực hiện các thao tác insert, update và delete vào cơ sở dữ liệu, dựa trên các trạng thái của thực thể.
        //Bộ nhớ đệm: Cung cấp bộ nhớ đệm cấp đầu tiên theo mặc định.Nó lưu trữ các thực thể đã được truy xuất trong suốt thời gian tồn tại của một lớp Context.
        //Quản lý mối quan hệ: Quản lý các mối quan hệ bằng cách sử dụng CSDL, MSL và SSDL trong cách tiếp cận Database First hoặc Model First và sử dụng các cấu hình Fluent API trong cách tiếp cận Code First.
        //Ánh xạ đối tượng: Chuyển đổi dữ liệu thô từ cơ sở dữ liệu thành các đối tượng thực thể.
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {
            // config option
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor>  Actors { get; set; }
    }
}
