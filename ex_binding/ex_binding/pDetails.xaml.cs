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
	public partial class pDetails : ContentPage
	{
		public pDetails ()
		{
			InitializeComponent ();
		}

        public pDetails(clsMain d)
        {
            InitializeComponent();

            lblName.Text = d.Name;
            lblTitle.Text = d.Title;
            lblPhoneNumber.Text = d.PhoneNumber;
            lblAddress.Text = d.Address;
            img1.Source = new Uri(d.ImagePath);
        }
    }
}