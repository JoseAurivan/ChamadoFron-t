#pragma checksum "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6df819b77bb321a7aec27207dc9a63e24eaad3f"
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
#line 1 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
using ChamadoFront.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
using Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class AbrirChamado : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Abrir um chamado</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Inserir as credenciais para abertura de um chamado </p>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
                  AbrirChamadoViewModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
                                                        CriarChamado

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "class", "needs-validation");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-4 mb-3");
                __builder2.AddMarkupContent(11, "<label for=\"validationCustom01\">Nome:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "id", "validationCustom01");
                __builder2.AddAttribute(16, "placeholder", "Nome");
                __builder2.AddAttribute(17, "required", true);
                __builder2.AddAttribute(18, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
                                                AbrirChamadoViewModel.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AbrirChamadoViewModel.Nome = __value, AbrirChamadoViewModel.Nome))));
                __builder2.AddAttribute(20, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AbrirChamadoViewModel.Nome));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "col-md-4 mb-3");
                __builder2.AddMarkupContent(24, "<label for=\"validationCustom02\">Email:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "type", "email");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "id", "validationCustom02");
                __builder2.AddAttribute(29, "placeholder", "Email");
                __builder2.AddAttribute(30, "required", true);
                __builder2.AddAttribute(31, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
                                                 AbrirChamadoViewModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AbrirChamadoViewModel.Email = __value, AbrirChamadoViewModel.Email))));
                __builder2.AddAttribute(33, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AbrirChamadoViewModel.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-md-4 mb-3");
                __builder2.AddMarkupContent(37, "<label for=\"validationCustomUsername\">CPF:</label>\r\n            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "input-group");
                __builder2.AddMarkupContent(40, "<div class=\"input-group-prepend\"><span class=\"input-group-text\" id=\"inputGroupPrepend\">CPF:</span></div>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "type", "text");
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "id", "validationCustomUsername");
                __builder2.AddAttribute(45, "placeholder", "CPF");
                __builder2.AddAttribute(46, "aria-describedby", "inputGroupPrepend");
                __builder2.AddAttribute(47, "required", true);
                __builder2.AddAttribute(48, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
                                                    AbrirChamadoViewModel.Cpf

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AbrirChamadoViewModel.Cpf = __value, AbrirChamadoViewModel.Cpf))));
                __builder2.AddAttribute(50, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AbrirChamadoViewModel.Cpf));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-row");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(56, "<label for=\"validationCustom03\">Setor</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(57);
                __builder2.AddAttribute(58, "type", "text");
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "id", "validationCustom03");
                __builder2.AddAttribute(61, "placeholder", "Setor");
                __builder2.AddAttribute(62, "required", true);
                __builder2.AddAttribute(63, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
                                    AbrirChamadoViewModel.Setor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AbrirChamadoViewModel.Setor = __value, AbrirChamadoViewModel.Setor))));
                __builder2.AddAttribute(65, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AbrirChamadoViewModel.Setor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "col-md-3 mb-3");
                __builder2.AddMarkupContent(69, "<label for=\"validationCustom04\">Celular</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(70);
                __builder2.AddAttribute(71, "type", "text");
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddAttribute(73, "id", "validationCustom04");
                __builder2.AddAttribute(74, "placeholder", "Celular");
                __builder2.AddAttribute(75, "required", true);
                __builder2.AddAttribute(76, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
                                    AbrirChamadoViewModel.Celular

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AbrirChamadoViewModel.Celular = __value, AbrirChamadoViewModel.Celular))));
                __builder2.AddAttribute(78, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AbrirChamadoViewModel.Celular));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n    ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "card");
                __builder2.AddAttribute(82, "style", "width: 25rem; margin-bottom: 15px;");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "card-body");
                __builder2.AddMarkupContent(85, "<h6 class=\"card-title\">Sobre o Chamado</h6>\r\n            ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-row");
                __builder2.AddMarkupContent(88, "<label for=\"validationCustom01\">Descricao:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(89);
                __builder2.AddAttribute(90, "class", "form-control");
                __builder2.AddAttribute(91, "id", "exampleFormControlTextarea1");
                __builder2.AddAttribute(92, "rows", "3");
                __builder2.AddAttribute(93, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
                                            AbrirChamadoViewModel.Descricao

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AbrirChamadoViewModel.Descricao = __value, AbrirChamadoViewModel.Descricao))));
                __builder2.AddAttribute(95, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AbrirChamadoViewModel.Descricao));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-row");
                __builder2.AddMarkupContent(99, "<label for=\"validationCustom03\">Setor Destino:</label>\r\n                ");
                __Blazor.ChamadoFront.Pages.AbrirChamado.TypeInference.CreateInputSelect_0(__builder2, 100, 101, 
#nullable restore
#line 51 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
                                          AbrirChamadoViewModel.SetorDestino

#line default
#line hidden
#nullable disable
                , 102, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AbrirChamadoViewModel.SetorDestino = __value, AbrirChamadoViewModel.SetorDestino)), 103, () => AbrirChamadoViewModel.SetorDestino, 104, (__builder3) => {
#nullable restore
#line 52 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
                     foreach (var setores in Enum.GetValues(typeof(Setor)))
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(105, "option");
                    __builder3.AddAttribute(106, "value", 
#nullable restore
#line 54 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
                                        setores

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 54 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
__builder3.AddContent(107, setores);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 55 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n    ");
                __builder2.AddMarkupContent(109, "<button class=\"btn btn-success\" type=\"submit\">Abrir Chamado</button>\r\n    ");
                __builder2.AddMarkupContent(110, "<button class=\"btn btn-outline-info\" type=\"reset\">Limpar</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\José\RiderProjects\ChamadoFront\ChamadoFront\Pages\AbrirChamado.razor"
       
    AbrirChamadoViewModel AbrirChamadoViewModel { get; set; } = new AbrirChamadoViewModel();


    protected async Task CriarChamado()
    {
        var _clientApi = "cliente/";
        var _chamadoApi = "chamado/";

        var chamado = AbrirChamadoViewModel.ToModelChamado(AbrirChamadoViewModel.Descricao, AbrirChamadoViewModel.SetorDestino);

        var cliente = AbrirChamadoViewModel.ToModelCliente(
            AbrirChamadoViewModel.Nome,
            AbrirChamadoViewModel.Cpf,
            AbrirChamadoViewModel.Email,
            AbrirChamadoViewModel.Setor,
            AbrirChamadoViewModel.Celular);

        var response = await _httpClient.PostAsJsonAsync(_clientApi, cliente);
        var responseText = await response.Content.ReadAsStringAsync();
        _chamadoApi += responseText;
        var textresponse = await _httpClient.PostAsJsonAsync(_chamadoApi, chamado);
        var text = await textresponse.Content.ReadAsStringAsync();
        await _jsRuntime.InvokeAsync<object>("alert", "Seu número de protocolo é: "+text);

        
        AbrirChamadoViewModel = new AbrirChamadoViewModel();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
    }
}
namespace __Blazor.ChamadoFront.Pages.AbrirChamado
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
