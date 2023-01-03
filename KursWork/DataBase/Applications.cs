
using System.ComponentModel.DataAnnotations;

namespace KursWork.DataBase
{
    public class Applications
    {
        [Key]
        public int ID_spc { get; set; }
        public int ID_org { get; set; }
        public int people { get; set; }
        public string date_start { get; set; }

    }
}
