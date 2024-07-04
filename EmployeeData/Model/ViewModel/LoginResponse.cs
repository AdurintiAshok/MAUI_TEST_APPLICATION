using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData.Model.ViewModel
{
    internal class LoginResponse
    {

            public string IdSession { get; set; }
            public DateTime SessionValidDate { get; set; }
            public int IdUser { get; set; }
            public bool Result { get; set; }


    }
}
