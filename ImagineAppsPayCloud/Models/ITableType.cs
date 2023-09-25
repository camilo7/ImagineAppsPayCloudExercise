using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagineAppsPayCloud.Models
{
    public interface ITableType
    {
        public string CheckNumber { get; set; }

        public string BankId { get; set; }

        public DateTime CheckDate { get; set; }
    }
}
