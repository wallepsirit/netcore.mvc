using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace mvclab5.Models
{
    public class account
    {
        [Key]
        public string id { get; set; }
        
        public string fullname { get; set; }
        public string email {  get; set; }
        public string phone { get; set; }
        [DisplayName(nhap sdt)]
        [Required(ErrorMessage ="khong dc de trong sdt")]
        
        public string adress {  get; set; }
        [DisplayName("nhap dia chi thuong tru"),Required(ErrorMessage ="khong duoc de trong dia chi"),MaxLength(100,ErrorMessage ="khong dc nhap qua 100 ky tu")]
        public string avtar {  get; set; }
        public DateTime birthday { get; set; }
        [Di[splayName("nhap ngay thang nam sinh"),Required(ErrorMessage ="khong dc de trong ngay thang nam sinh")]
        public string password {  get; set; }
        [DisplayName("nhap mat khau"),Required(ErrorMessage ="khong duoc de trong mat khau")]
        public string confirmpassword {  get; set; }
        [Compare("password"), DisplayName(XmlAttributeCollection nhan mat khau),Required]
        public string facebook {  get; set; }
        [DisplayName("link facebook"),Required(ErrorMessage ="khong de trong link fb")]

    }
}
