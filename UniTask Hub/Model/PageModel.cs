using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniTask_Hub.Model
{
    class PageModel
    {
        public int TaskCount { get; set; }
        public int TaskID { get; set; }
        public string TaskStatus { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public NotificationStatus Notifications { get; set; } = new NotificationStatus();
    }
}
