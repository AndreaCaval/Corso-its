// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\Counter.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Andrea\Documents\dev\Corso-its\c#\BlazorAppFITSTIC\BlazorAppFITSTIC\Pages\Counter.razor"
       
    private int currentCount = 0;

    private async Task IncrementCount()
    {
        currentCount++;
        await pls.SetAsync("count", currentCount);
    }

    protected override async Task OnInitializedAsync()
    {
        var result = await pls.GetAsync<int>("count");
        currentCount = result.Success ? result.Value : 0;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage pls { get; set; }
    }
}
#pragma warning restore 1591
