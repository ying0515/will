using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CustSite.Models
{
    [MetadataType(typeof(客戶聯絡人Metadata))]
    public partial class 客戶聯絡人
    {
        public class 客戶聯絡人Metadata
        {
            [Key]
            public int Id { get; set; }

            [Required]
            public int 客戶Id { get; set; }

            [Required]
            [StringLength(50)]
            public string 職稱 { get; set; }

            [Required]
            [StringLength(50)]
            public string 姓名 { get; set; }

            [Required]   
            [StringLength(250)]  
            [DataType(DataType.EmailAddress)]
            [Remote("CheckUserMail", "CustContact", AdditionalFields = "客戶Id", ErrorMessage = "此客戶Email不能重複!")]
            public string Email { get; set; } 

            [StringLength(50)]
            [RegularExpression(@"\d{4}-\d{6}", ErrorMessage = "手機格式錯誤")]
            public string 手機 { get; set; }

            [StringLength(50)]
            public string 電話 { get; set; }

        }
    }
}