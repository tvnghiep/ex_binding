using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Acr.UserDialogs;

namespace ex_binding
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileView : ContentPage
	{

        public static string token = "EAAFifG9seioBADExvZAH2O9N4FrDrNwbvHZBgp83mXpgWsIRDT8ozKS4KvoqaFZBFHwuZB4prt38bYN6Rz1Np5kGC93crtSCdMvgpvHu48oihBmZBQXDmELpwIlpHAlGZBOtbbJEc5ZBDCkRKlCilBcTpC9YjHlULUjSZBGoDOwXBtD4vAwZCPbRyGyOcVLqIMfRiC7ecKBuXsQZDZD";

		public ProfileView ()
		{
			InitializeComponent ();
		}

        protected override async  void OnAppearing()
        {
            base.OnAppearing();

            UserDialogs.Instance.ShowLoading();


            HttpClient hc1 = new HttpClient();
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://graph.facebook.com/v3.1/me?fields=id,name,birthday,friendlists");
            request.Method = HttpMethod.Get;
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer"
                , token );

            HttpResponseMessage response=  await hc1.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync() ;
                clsFB fb= JsonConvert.DeserializeObject<clsFB>(body);
                BindingContext = fb;
            }

            UserDialogs.Instance.HideLoading();
        }

        private void Feed_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FBFeed());
        }
    }
}