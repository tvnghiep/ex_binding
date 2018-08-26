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

namespace ex_binding
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileView : ContentPage
	{

        public static string token = "EAAFifG9seioBAJJyaZB3EjcDZCAKXcq21YvSkDYvHdRnMjqMHQu3yy6Yrv8IUbR2lE5dFztP9t0lygYERrZACpVvVtBAnMFB0BEsCCdBJxQHqp2ZCv7SaqpiWdNREZBSSXEkeZBYZCFZBokigXn4dWeYQR0XQdfdqBSadbwZA5EteO7ZCZB0dv9yWZBq6mE5tqbrWPELVEjVyPwmSgZDZD";

		public ProfileView ()
		{
			InitializeComponent ();
		}

        protected override async  void OnAppearing()
        {
            base.OnAppearing();

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
        }

        private void Feed_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FBFeed());
        }
    }
}