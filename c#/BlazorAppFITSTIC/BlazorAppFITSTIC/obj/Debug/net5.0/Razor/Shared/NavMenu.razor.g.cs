#pragma checksum "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "310bc1518588c151e32b5aa31cf836faa4d4b9eb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppFITSTIC.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-s3jllcmc5t");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-s3jllcmc5t>BlazorAppFITSTIC</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-s3jllcmc5t");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-s3jllcmc5t></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-s3jllcmc5t");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-s3jllcmc5t");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-s3jllcmc5t");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-s3jllcmc5t></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-s3jllcmc5t");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "nuovostudente");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-s3jllcmc5t></span> Nuovo studente\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item px-3");
            __builder.AddAttribute(38, "b-s3jllcmc5t");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "listastudenti");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-s3jllcmc5t></span> Studenti\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n        ");
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "nav-item px-3");
            __builder.AddAttribute(47, "b-s3jllcmc5t");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "class", "nav-link");
            __builder.AddAttribute(50, "href", "counter");
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(52, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-s3jllcmc5t></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "li");
            __builder.AddAttribute(55, "class", "nav-item px-3");
            __builder.AddAttribute(56, "b-s3jllcmc5t");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(57);
            __builder.AddAttribute(58, "class", "nav-link");
            __builder.AddAttribute(59, "href", "fetchdata");
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(61, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-s3jllcmc5t></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.OpenElement(63, "li");
            __builder.AddAttribute(64, "class", "nav-item px-3");
            __builder.AddAttribute(65, "b-s3jllcmc5t");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(66);
            __builder.AddAttribute(67, "class", "nav-link");
            __builder.AddAttribute(68, "href", "inputnumber");
            __builder.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(70, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-s3jllcmc5t></span> Inserisci numero\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591