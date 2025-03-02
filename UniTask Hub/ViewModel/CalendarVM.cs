using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniTask_Hub.Model;

namespace UniTask_Hub.ViewModel
{
    class CalendarVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public DateOnly DisplayStartDate
        {
            get { return _pageModel.StartDate; }
            set { _pageModel.StartDate = value; OnPropertyChanged(); }
        }

        public DateOnly DisplayEndDate
        {
            get { return _pageModel.EndDate; }
            set { _pageModel.EndDate = value; OnPropertyChanged(); }
        }

        public CalendarVM()
        {
            _pageModel = new PageModel();
            DisplayStartDate = DateOnly.FromDateTime(DateTime.Now);
            DisplayEndDate = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
