using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using AcademicsLibrary.DataModel;
using AcademicsLibrary.Managers;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Template10TestApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Profile : Page
    {
        public RefreshModel prof;
        public Profile()
        {
            this.InitializeComponent();
            //var img = new BitmapImage(new Uri("http://vtop.vit.ac.in/student/view_photo_2.asp?rgno=15BCE0815"));
            //this.Ppic.Source = img;
            prof = DataManager.Refresh;
            RegNo.Text = prof.reg_no;
            UserName.Text = prof.name;
        }
    }
}
