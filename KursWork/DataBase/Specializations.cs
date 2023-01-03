using System.ComponentModel.DataAnnotations;

namespace KursWork.DataBase
{
    public class Specializations
    {
        [Key]
        public int ID { get; set; }
        public string title { get; set; }
        public int hours { get; set; }
        public int price {get; set;}
    }
}