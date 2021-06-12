using MobileHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace MobileHelper.ViewModels
{

    public class AboutVM
    {
        public ObservableCollection<AboutM> AboutList { get; set; }
        public AboutVM()
        {
            AboutList = new ObservableCollection<AboutM>
            {
                new AboutM
                {
                    Name = "Полное наименование организации:",
                    Detail = "Открытое акционерное общество \"Бобруйский завод тракторных деталей и агрегатов\""
                },
                new AboutM
                {
                    Name = "Страна:",
                    Detail = "Беларусь"
                },
                new AboutM
                {
                    Name = "Адрес:",
                    Detail = "г. Бобруйск, ул. Бахарова 225"
                },
                new AboutM
                {
                    Name = "Сайт:",
                    Detail = "bztda.com"
                },
                new AboutM
                {
                    Name = "Время работы:",
                    Detail = "ПН-ПТ: 8:00-18:00"
                },
            };
        }
    }
}
