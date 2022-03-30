using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;

namespace ChamadoFront.Auth
{
    public class CustomAuth : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorageService;

        public CustomAuth(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var state = new AuthenticationState(new ClaimsPrincipal());
            string username = await _localStorageService.GetItemAsStringAsync("cpf");
            if (!string.IsNullOrEmpty(username))
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, username)
                }, "test authentication type");
                
                state = new AuthenticationState(new ClaimsPrincipal(identity));
            }
            
            NotifyAuthenticationStateChanged(Task.FromResult(state));
            return state;
        }
    }
}