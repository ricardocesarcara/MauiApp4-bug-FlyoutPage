using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4
{
    public class InitialPageViewModel : ObservableObject
    {

        public InitialPageViewModel()
        {           
        }


        public async Task SetInitialPageAsync()
        {
          //  Define aqui qual será a primeira pagina

            var page = new NavigationPage((Page)Activator.CreateInstance(typeof(ContactsPage)));

            var currentPage = Application.Current.MainPage;

            if (!(currentPage is FlyoutPage masterDetailPage))
            {
                throw new Exception($"Current MainPage is not a {typeof(FlyoutPage)}!");
            }

            masterDetailPage.Detail = page;

        }



    }
}
