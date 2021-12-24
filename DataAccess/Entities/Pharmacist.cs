using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Pharmacist
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pPhone { get; set; }
        public string pDob { get; set; }
        public string pUserName { get; set; }
        public string pPassword { get; set; }
    }
}
