using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniTask_Hub.Model
{
    public class PageModel
    {
        public string title { get; set; }
        public string description { get; set; }
        public string deadline { get; set; }
        public int status { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public int TaskCount { get; set; }
        public int task_id { get; set; }
        public string TaskStatus { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public NotificationStatus Notifications { get; set; } = new NotificationStatus();
    }
}
