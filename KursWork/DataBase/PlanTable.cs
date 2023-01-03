using System.ComponentModel.DataAnnotations;

namespace KursWork.DataBase
{
    public class PlanTable
    {
        [Key]
        public int ID_spc { get; set; }
        public string date_start { get; set; }
        public string date_end { get; set; }
    }
}