using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Rocket.WatchOrganizer.Core.ViewModels.Home;
using Rocket.WatchOrganizer.Core.ViewModels.Watched;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rocket.WatchOrganizer.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = false)]
    public partial class WatchedStep1Page : MvxContentPage<WatchedStep1ViewModel>
    {
        public WatchedStep1Page()
        {
            InitializeComponent();
        }
    }
}
