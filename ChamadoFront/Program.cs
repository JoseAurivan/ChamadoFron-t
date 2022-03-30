using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text;
using Blazored.LocalStorage;
using Blazored.Modal;
using Blazored.Modal.Services;
using ChamadoFront.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ChamadoFront
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            
            
            builder.Services.AddSingleton(
                sp =>
                {
                    var httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri(@"http://170.246.105.250:9001/api/");
                    return httpClient;
                });
                
            builder.Services.AddBlazoredModal();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuth>();
            builder.Services.AddOptions();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddAuthorizationCore();

            await builder.Build().RunAsync();
        }
    }
}