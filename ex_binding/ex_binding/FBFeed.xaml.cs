using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ex_binding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FBFeed : ContentPage
    {
        public FBFeed()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            HttpClient hc1 = new HttpClient();
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://graph.facebook.com/v3.1/me?fields=posts");
            request.Method = HttpMethod.Get;
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer"
                , ProfileView.token  );

            HttpResponseMessage response = await hc1.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();
                Feed fbPost = JsonConvert.DeserializeObject<Feed>(body);
                BindingContext = fbPost;
            }
        }
    }
}