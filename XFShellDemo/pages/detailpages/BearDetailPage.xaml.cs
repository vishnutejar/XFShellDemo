using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFShellDemo.Date;

namespace XFShellDemo.pages.detailpages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(Name), "name")]
    public partial class BearDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                LoadAnimal(value);
            }
        }

        public BearDetailPage()
        {
            InitializeComponent();
        }

        void LoadAnimal(string name)
        {
            try
            {
                Animal animal = BearData.Bears.FirstOrDefault(a => a.Name == name);
                BindingContext = animal;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load animal.");
            }
        }
    }

}