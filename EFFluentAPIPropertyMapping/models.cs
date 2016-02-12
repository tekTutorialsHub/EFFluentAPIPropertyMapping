using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;


namespace EFFluentAPIPropertyMapping
{
    public class Employee
    {
        
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Remark { get; set; }

        public byte[] RowID { get; set; }
    }

    public class Department
    {
        
        public int DepartmentID { get; set; }
        public string Name { get; set; }

        public string Manager { get; set; }
    }


    public class Project
    {
        public int ProjectID { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public bool Active { get; set; }

        public decimal Budget { get; set; }

        public int NoOfEmployee { get; set; }
    }



}
