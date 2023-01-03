using System.ComponentModel.DataAnnotations;

namespace KursWork.DataBase
{
    public class Organizations
    {
        [Key]
        public int ID { get; set; }
        public string title { get; set; }
        public string address { get; set; }
    }
}