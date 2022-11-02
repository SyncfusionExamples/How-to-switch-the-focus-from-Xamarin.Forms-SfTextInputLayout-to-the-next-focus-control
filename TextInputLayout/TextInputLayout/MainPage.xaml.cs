using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace TextInputLayout
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);
        }
        void Handle_Completed(object sender, System.EventArgs e)
        {
            var tabs = Layout.GetTabIndexesOnParentPage(out int count);
            var visual = sender as Xamarin.Forms.VisualElement;
            var currentIndex = visual.TabIndex;
            var nextFocus = Layout.FindNextElement(true, tabs, ref currentIndex);
            (nextFocus as Xamarin.Forms.VisualElement)?.Focus();
        }

    }
}
