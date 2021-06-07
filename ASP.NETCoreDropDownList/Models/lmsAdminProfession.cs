using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreDropDownList.Models
{
    public class lmsAdminProfession
    {
        [Key]
        public int ID_PROFESSION { get; set; }
        public string NAME_PROFESSION { get; set; }
        [NotMapped]
        public DateTime CREATE_DATE { get; set; }
        [NotMapped]
        public DateTime UPDATE_DATE { get; set; }

    }
}
