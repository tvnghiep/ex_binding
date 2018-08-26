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
	public partial class pDetails_Manual : ContentPage
	{
		public pDetails_Manual()
		{
			InitializeComponent ();
		}

        public pDetails_Manual(clsDoctor d)
        {
            //BindingContext = d;

            InitializeComponent();
            //khai báo từng đối tượng và gắn dữ liệu vào từng đối tượng

            lblName.Text = d.Name;
            lblTitle.Text = d.Title;
            lblPhoneNumber.Text = d.PhoneNumber;
            lblAddress.Text = d.Address;
            img1.Source = new Uri(d.ImagePath);
        }
    }
}