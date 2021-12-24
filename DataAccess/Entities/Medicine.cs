using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Medicine
    {
        public int mId { get; set; }
        public string mName { get; set; }
        public string mCompany { get; set; }
        public string mPrice { get; set; }
        public string mExpireDate { get; set; }

    }
}