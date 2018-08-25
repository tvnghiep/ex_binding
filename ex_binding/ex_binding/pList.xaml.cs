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
	public partial class pList : ContentPage
	{
        List<clsMain> lDoctor;

		public pList ()
		{
			InitializeComponent ();

            lDoctor = new List<clsMain>()
            {
                new clsMain(){Name="Nguyen Van A", Address  ="210 NVA", Title ="Bac Si", PhoneNumber ="0123"
                , ImagePath ="https://cdn.doctailieu.com/images/2018/04/18/xem-va-tai-tranh-to-mau-bac-si-cho-be-nuoi-duong-uoc-mo-3.jpg"
                },
                new clsMain(){Name="Nguyen Van B", Address  ="211 NVA", Title ="Y Si", PhoneNumber ="012B"
                , ImagePath ="https://bacsinguyenxuanquang.files.wordpress.com/2009/03/evowa.jpg?w=640"
                },
                new clsMain(){Name="Nguyen Van C", Address  ="211 C", Title ="Nha Si", PhoneNumber ="012C"
                , ImagePath ="https://cdn.doctailieu.com/images/2018/04/18/xem-va-tai-tranh-to-mau-bac-si-cho-be-nuoi-duong-uoc-mo-1.jpg"
                }
            };

            lvList.ItemsSource = lDoctor;
		}

        private void ItemTapped(object sender, ItemTappedEventArgs e)
        {
            clsMain m = (clsMain ) e.Item;
            Navigation.PushAsync(new pDetails (m));
        }
    }
}