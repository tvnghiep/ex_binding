using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ex_binding
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class pLogIn : ContentPage
	{
		public pLogIn ()
		{
			InitializeComponent ();
		}

        private void OnClicked(object sender, EventArgs e)
        {
            if (txtUser.Text == "sa")
            {
                App.Current.MainPage = new NavigationPage( new pList());
            }
            else
            {
                DisplayAlert("Lỗi", "Không tìm thấy User: " + txtUser.Text, "OK");
                txtUser.Focus();

                
            }
        }
    }
}