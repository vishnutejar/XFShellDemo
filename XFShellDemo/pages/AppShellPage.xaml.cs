using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFShellDemo.pages.detailpages;

namespace XFShellDemo.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShellPage : Shell
    {
        public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();
        public AppShellPage()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        void RegisterRoutes()
        {
            Routes.Add("monkeydetails", typeof(MonkeyDetailPage));
            Routes.Add("beardetails", typeof(BearDetailPage));
            Routes.Add("catdetails", typeof(CatDetailPage));
            Routes.Add("dogdetails", typeof(DogDetailPage));
            Routes.Add("elephantdetails", typeof(ElephantDetailPage));

            foreach (var item in Routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}