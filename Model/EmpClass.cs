using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RetrievingData.Model
{
    public class EmpClass
    {
        [Key]
        public int EmployeeKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
