#pragma checksum "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\DettaglioStudente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "926fd7bb24c445eb0790a9f7961a039258dcaa79"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppFITSTIC.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\_Imports.razor"
using BlazorAppFITSTIC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\_Imports.razor"
using BlazorAppFITSTIC.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\DettaglioStudente.razor"
using BlazorAppFITSTIC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\DettaglioStudente.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dettagliostudente/{Id:int}")]
    public partial class DettaglioStudente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DettaglioStudente</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert" + " alert-danger" + " " + (
#nullable restore
#line 9 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\DettaglioStudente.razor"
                                 showError ? "d-block" : "d-none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "<p>\r\n        Errore: studente non trovato.\r\n    </p>");
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\DettaglioStudente.razor"
 if (s != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<label>Nome</label>\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\DettaglioStudente.razor"
                                    s.Nome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => s.Nome = __value, s.Nome));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "<label>Cognome</label>\r\n    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\DettaglioStudente.razor"
                                    s.Cognome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => s.Cognome = __value, s.Cognome));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "<label>Data di nascita</label>\r\n    ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "date");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\DettaglioStudente.razor"
                                    s.Nascita

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => s.Nascita = __value, s.Nascita, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "<label>Anno iscrizione</label>\r\n    ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "number");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\DettaglioStudente.razor"
                                      s.AnnoIscrizione

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => s.AnnoIscrizione = __value, s.AnnoIscrizione, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-outline-primary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\DettaglioStudente.razor"
                                                      SaveStudent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Salva");
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\DettaglioStudente.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\DettaglioStudente.razor"
       
    [Parameter]
    public int Id { get; set; }

    bool showError = false;
    private Student s;

    protected override async Task OnInitializedAsync()
    {
        var res = await pls.GetAsync<List<Student>>("students");
        if (res.Success)
        {
            List<Student> ls = res.Value;
            s = ls.FirstOrDefault(st => st.Id == Id);
            if (s == null)
            {
                showError = true;
            }
            else
            {

            }
        }
    }

    async Task SaveStudent()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage.ProtectedLocalStorage pls { get; set; }
    }
}
#pragma warning restore 1591