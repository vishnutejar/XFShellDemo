using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFShellDemo.Date;

namespace XFShellDemo.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BearsPage : ContentPage
    {
        public BearsPage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string bearName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;
            // The following route works because route names are unique in this application.
            await Shell.Current.GoToAsync($"beardetails?name={bearName}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/domestic/cats/catdetails?name={catName}");
        }
    }
}