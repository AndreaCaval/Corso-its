#pragma checksum "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\NuovoStudente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54839f350da25e3dfb858c02d6b2aa9cb8967646"
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
#line 2 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\NuovoStudente.razor"
using BlazorAppFITSTIC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\NuovoStudente.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/nuovostudente")]
    public partial class NuovoStudente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Nuovo studente</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert" + " alert-danger" + " " + (
#nullable restore
#line 8 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\NuovoStudente.razor"
                                 showError ? "d-block" : "d-none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "<p>\r\n        Errore: controlla i dati in pagina.\r\n    </p>");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.AddMarkupContent(5, "<label>Nome</label>\r\n");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\NuovoStudente.razor"
                                nome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nome = __value, nome));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.AddMarkupContent(12, "<label>Cognome</label>\r\n");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\NuovoStudente.razor"
                                cognome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cognome = __value, cognome));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.AddMarkupContent(19, "<label>Data di nascita</label>\r\n");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "date");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\NuovoStudente.razor"
                                dtNascita

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dtNascita = __value, dtNascita, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.AddMarkupContent(26, "<label>Anno iscrizione</label>\r\n");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "text");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\NuovoStudente.razor"
                                annoIscr

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => annoIscr = __value, annoIscr));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-outline-primary");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\NuovoStudente.razor"
                                                  SaveStudent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Salva");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\NuovoStudente.razor"
       
    bool showError = false;
    string nome, cognome, annoIscr = DateTime.Now.Year.ToString();
    DateTime dtNascita = DateTime.Now;

    async Task SaveStudent()
    {
        int anno;
        int.TryParse(annoIscr, out anno);
        try
        {
            Student s = new Student(nome, cognome, dtNascita, anno);

            List<Student> ls;
            var res = await pls.GetAsync<List<Student>>("students");
            if (res.Success)
            {
                ls = res.Value;
            }
            else
            {
                ls = new List<Student>();
            }

            if (ls.Count > 0)
            {
                int maxId = ls.Max(st => st.Id);
                s.Id = maxId + 1;
            }
            else
            {
                s.Id = 1;
            }

            ls.Add(s);

            await pls.SetAsync("students", ls);
        }
        catch (ArgumentException ex)
        {
            showError = true;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage.ProtectedLocalStorage pls { get; set; }
    }
}
#pragma warning restore 1591
