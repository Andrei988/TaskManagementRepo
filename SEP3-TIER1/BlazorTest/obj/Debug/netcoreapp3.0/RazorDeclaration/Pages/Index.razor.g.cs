#pragma checksum "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1660d90d1e1c33935d7d79090f3dba7e84d2b94"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\_Imports.razor"
using BlazorTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\_Imports.razor"
using BlazorTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Pages\Index.razor"
using BlazorTest.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Pages\Index.razor"
using BlazorTest.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Pages\Index.razor"
using BlazorTest.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Pages\Index.razor"
using Task = System.Threading.Tasks.Task;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(NoNavLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Pages\Index.razor"
       
    [Parameter]
    public string Username { get; set; }

    [Parameter]
    public string Password { get; set; }

    public async Task Login()
    {
        appData.Username = Username;

        try
        {
            string message = await controller.onSignIn(AsyncClient, Username, Password);

            if (message == "true")
            {
                NavigationManager.NavigateTo("account");
            }
            else
            {
                NavigationManager.NavigateTo("error");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void Register()
    {
        NavigationManager.NavigateTo("/register");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData appData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginController controller { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Networking.AsyncClient AsyncClient { get; set; }
    }
}
#pragma warning restore 1591