using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniTask_Hub.Model;

namespace UniTask_Hub.ViewModel
{
    class Tasks : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public int TaskID
        {
            get { return _pageModel.TaskID; }
            set { _pageModel.TaskID = value; onPropertyChanged(); }
        }

        public string TaskStatus
        {
            get { return _pageModel.TaskStatus; }
            set { _pageModel.TaskStatus = value; onPropertyChanged(); }
        }

        public Tasks()
        {
            _pageModel = new PageModel();
            TaskID = 1254568;
            TaskStatus = "In Progress";
            
        }
    }
}
