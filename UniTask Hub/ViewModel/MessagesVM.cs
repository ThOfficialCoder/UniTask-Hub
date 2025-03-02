using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniTask_Hub.Model;

namespace UniTask_Hub.ViewModel
{
    class MessagesVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public NotificationStatus Notifications
        {
            get { return _pageModel.Notifications; }
            set { _pageModel.Notifications = value; OnPropertyChanged(); }
        }

        public MessagesVM()
        {
            _pageModel = new PageModel();
            _pageModel.Notifications = NotificationStatus.NotificationAlways;
        }
    }
}
