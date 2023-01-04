using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KursWork.DataBase
{
    public class Specializations
    {
        [Key]
        public int ID { get; set; }
        public string title { get; set; }
        public int hours { get; set; }
        [Column("price_$")]
        public int price {get; set;}
    }
}