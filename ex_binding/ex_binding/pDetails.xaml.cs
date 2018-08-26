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

        clsDoctor doctor, doctor1;

        public pDetails(clsDoctor d)
        {
            doctor = d;
            doctor1 = new clsDoctor()
            {
                Name = d.Name,
                Title = d.Title,
                PhoneNumber = d.PhoneNumber,
                Address = d.Address,
                ImagePath = d.ImagePath
            };
            //dùng bindingcontext của ms, gắn dữ liêu trong file xaml
            BindingContext = doctor1;

            InitializeComponent();
            Title = "Edit Doctor";

            //lblName.Text = d.Name;
            //lblTitle.Text = d.Title;
            //lblPhoneNumber.Text = d.PhoneNumber;
            //lblAddress.Text = d.Address;
            //img1.Source = new Uri(d.ImagePath);
        }

        string _mode = "";
        public pDetails(clsDoctor d, string mode)
        {
            _mode = mode;

            doctor = d;
            doctor1 = new clsDoctor()
            {
                Name = "",
                Title = "",
                PhoneNumber = "",
                Address = "",
                ImagePath = ""
            };
            //dùng bindingcontext của ms, gắn dữ liêu trong file xaml
            BindingContext = doctor1;

            InitializeComponent();
            Title = "New Doctor";
            //lblName.Text = d.Name;
            //lblTitle.Text = d.Title;
            //lblPhoneNumber.Text = d.PhoneNumber;
            //lblAddress.Text = d.Address;
            //img1.Source = new Uri(d.ImagePath);
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            if (_mode == "add")
            {
                pList.lDoctor.Add(doctor1);
                Navigation.PopAsync();//trở về trang trước

                Acr.UserDialogs.UserDialogs.Instance.Toast("Added...");
            }
            else
            {
                doctor.Name = doctor1.Name;
                doctor.Title = doctor1.Title;
                doctor.PhoneNumber = doctor1.PhoneNumber;
                doctor.Address = doctor1.Address;
                doctor.ImagePath = doctor1.ImagePath;
                Navigation.PopAsync();//trở về trang trước

                Acr.UserDialogs.UserDialogs.Instance.Toast("Updated...");
            }
            
        }
    }
}