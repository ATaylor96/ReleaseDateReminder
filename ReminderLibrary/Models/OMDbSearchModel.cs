using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderLibrary.Models
{
    public class OMDbSearchModel
    {
        public List<SearchResult> Search { get; set; }
        public string totalResults { get; set; }
        public bool Response { get; set; }
    }
}
