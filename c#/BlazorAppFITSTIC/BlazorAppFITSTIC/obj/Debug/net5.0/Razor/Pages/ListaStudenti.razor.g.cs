#pragma checksum "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\ListaStudenti.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d77c76e5a6c70fdd4aedb0ed3316f470499ae9d5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppFITSTIC.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#line 3 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\ListaStudenti.razor"
using BlazorAppFITSTIC.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listastudenti")]
    public partial class ListaStudenti : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lista studenti</h3>");
#nullable restore
#line 8 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\ListaStudenti.razor"
 if (students == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\ListaStudenti.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Nome</th>\r\n                <th>Cognome</th>\r\n                <th>Nascita</th>\r\n                <th>Iscrizione</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 25 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\ListaStudenti.razor"
             foreach (var s in students)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 28 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\ListaStudenti.razor"
                         s.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 29 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\ListaStudenti.razor"
                         s.Cognome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 30 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\ListaStudenti.razor"
                         s.Nascita.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 31 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\ListaStudenti.razor"
                         s.AnnoIscrizione

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/dettagliostudente/" + (
#nullable restore
#line 33 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\ListaStudenti.razor"
                                                     s.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "btn btn-outline-info");
            __builder.AddContent(23, "Modifica");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddMarkupContent(25, "<button class=\"btn btn-outline-danger\">Elimina</button>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\ListaStudenti.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\ListaStudenti.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\ListaStudenti.razor"
       
    private List<Student> students;

    protected override async Task OnInitializedAsync()
    {
        var res = await pls.GetAsync<List<Student>>("students");
        if (res.Success)
        {
            students = res.Value;
        }
        else
        {
            students = new List<Student>();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage.ProtectedLocalStorage pls { get; set; }
    }
}
#pragma warning restore 1591
