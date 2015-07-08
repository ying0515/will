using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustSite.Models
{
    [MetadataType(typeof(客戶資料Metadata))]
    public partial class 客戶資料
    {
        public class 客戶資料Metadata
        {
            [Key]
            public int Id { get; set; }
            
            [Required]
            [StringLength(50)]
            public string 客戶名稱 { get; set; }
            
            [Required]
            [StringLength(8)]
            public string 統一編號 { get; set; }
             
            [Required]
            [StringLength(50)]
            public string 電話 { get; set; }
            
            [StringLength(50)]
            public string 傳真 { get; set; }
            
            [StringLength(100)]
            public string 地址 { get; set; }
            
            [StringLength(250)]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }

        }
    }
}