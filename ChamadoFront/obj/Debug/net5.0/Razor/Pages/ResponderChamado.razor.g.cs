#pragma checksum "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98343af9e879f0e21c7ac96e056112b616121557"
// <auto-generated/>
#pragma warning disable 1591
namespace ChamadoFront.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using Newtonsoft;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using ChamadoFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
using ChamadoFront.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
using ChamadoFront.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
using Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ResponderChamado/{id}")]
    public partial class ResponderChamado : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<a href=\"counter\" class=\"btn btn-primary\" style=\"margin-bottom: 15px\">Voltar A lista</a>");
#nullable restore
#line 12 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
         if (Chamado is not null)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "card");
                __builder2.AddAttribute(5, "style", "margin-bottom: 15px;");
                __builder2.AddMarkupContent(6, "<div class=\"card-header\">\r\n                    Dados do Chamado\r\n                </div>\r\n                ");
                __builder2.OpenElement(7, "ul");
                __builder2.AddAttribute(8, "class", "list-group list-group-flush");
                __builder2.OpenElement(9, "li");
                __builder2.AddAttribute(10, "class", "list-group-item");
                __builder2.AddMarkupContent(11, "\r\n                        Nome: ");
#nullable restore
#line 20 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
__builder2.AddContent(12, Chamado.Cliente?.Nome);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n                    ");
                __builder2.OpenElement(14, "li");
                __builder2.AddAttribute(15, "class", "list-group-item");
                __builder2.AddMarkupContent(16, "\r\n                        Descricao: ");
#nullable restore
#line 23 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
__builder2.AddContent(17, Chamado.Descricao);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "li");
                __builder2.AddAttribute(20, "class", "list-group-item");
                __builder2.AddMarkupContent(21, "\r\n                        Setor Destino: ");
#nullable restore
#line 26 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
__builder2.AddContent(22, Chamado.SetorDestimno);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenElement(24, "li");
                __builder2.AddAttribute(25, "class", "list-group-item");
                __builder2.AddMarkupContent(26, "\r\n                        Setor: ");
#nullable restore
#line 29 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
__builder2.AddContent(27, Chamado.Cliente?.Setor);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "li");
                __builder2.AddAttribute(30, "class", "list-group-item");
                __builder2.AddMarkupContent(31, "\r\n                        Celular:");
#nullable restore
#line 32 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
__builder2.AddContent(32, Chamado.Cliente?.Celular);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 36 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(34);
            __builder.AddAttribute(35, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 39 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
                              ResponderChamadoViewModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 39 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
                                                                        GerarRespostaChamado

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(37, "class", "needs-validation");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-row");
                __builder2.AddMarkupContent(41, "<label for=\"validationCustom03\">Resposta do Chamado:</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(42);
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "id", "exampleFormControlTextarea1");
                __builder2.AddAttribute(45, "rows", "3");
                __builder2.AddAttribute(46, "required", true);
                __builder2.AddAttribute(47, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
                                                ResponderChamadoViewModel.Resposta

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ResponderChamadoViewModel.Resposta = __value, ResponderChamadoViewModel.Resposta))));
                __builder2.AddAttribute(49, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ResponderChamadoViewModel.Resposta));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-row");
                __builder2.AddAttribute(53, "style", "margin-bottom: 15px");
                __builder2.AddMarkupContent(54, "<label for=\"validationCustom03\">Status do Chamado:</label>\r\n                    ");
                __Blazor.ChamadoFront.Pages.ResponderChamado.TypeInference.CreateInputSelect_0(__builder2, 55, 56, 
#nullable restore
#line 46 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
                                              ResponderChamadoViewModel.StatusChamado

#line default
#line hidden
#nullable disable
                , 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ResponderChamadoViewModel.StatusChamado = __value, ResponderChamadoViewModel.StatusChamado)), 58, () => ResponderChamadoViewModel.StatusChamado, 59, (__builder3) => {
#nullable restore
#line 47 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
                         foreach (var status in Enum.GetValues(typeof(StatusChamado)))
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(60, "option");
                    __builder3.AddAttribute(61, "value", 
#nullable restore
#line 49 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
                                            status

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 49 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
__builder3.AddContent(62, status);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 50 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                ");
                __builder2.AddMarkupContent(64, "<button class=\"btn btn-success\" type=\"submit\">Enviar resposta</button>\r\n                ");
                __builder2.AddMarkupContent(65, "<button class=\"btn btn-outline-info\" type=\"reset\">Limpar</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\ResponderChamado.razor"
       

    [Parameter]
    public string Id { get; set; }

    private string _api = "chamado/";

    public ResponderChamadoViewModel ResponderChamadoViewModel { get; set; } = new ResponderChamadoViewModel();

    public Chamado Chamado { get; set; } = new Chamado();

    protected override async Task OnInitializedAsync()
    {
        Chamado = await _httpClient.GetFromJsonAsync<Chamado>(_api + Id);
    }

    public async Task GerarRespostaChamado()
    {
        Chamado.Resposta = ResponderChamadoViewModel.Resposta;
        Chamado.StatusChamado = ResponderChamadoViewModel.StatusChamado;
        Chamado.Id = Int32.Parse(Id);

        await _httpClient.PutAsJsonAsync(_api, Chamado);
        _navigationManager.NavigateTo("/counter");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
    }
}
namespace __Blazor.ChamadoFront.Pages.ResponderChamado
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
