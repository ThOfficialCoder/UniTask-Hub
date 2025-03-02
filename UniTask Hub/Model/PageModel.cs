using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniTask_Hub.Model
{
    class PageModel
    {
        public int TaskCount { get; set; }
        public string TaskStatus { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}
