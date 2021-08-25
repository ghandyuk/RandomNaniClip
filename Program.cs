using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

namespace RandomNaniClip
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            ConfigureClients(builder.Services);

            builder.Services
                .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) })
                .AddBlazorise(options =>
                 {
                     options.ChangeTextOnKeyPress = true;
                 })
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();

            await builder.Build().RunAsync();
        }

        private static void ConfigureClients(IServiceCollection services)
        {
            // services.AddHttpClient<RandomMovieClient>((provider, httpClient) =>
            // {
            //     var config = provider.GetService<IConfiguration>();
            //     httpClient.BaseAddress = new Uri(config["ApiClients:MovieQuote:BaseAddressUrl"]);
            //     httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //     // options.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("GitHubPagesDemoClient", "0.1"));
            // });
        }
    }
}
