using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerPackerWinForms
{
    public class Package
    {
        string PackID { get; set; }
        string PackDescription { get; set; }
        double PackWeight { get; set; }
        double PackCube { get; set; }




        private string NewPackageID()
        {
            return Guid.NewGuid().ToString().Replace("-", string.Empty).Replace("=", string.Empty).Replace("+", string.Empty).Substring(0, 6);
        }
    }
}
