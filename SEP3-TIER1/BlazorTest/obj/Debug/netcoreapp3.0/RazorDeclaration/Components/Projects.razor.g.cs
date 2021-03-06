#pragma checksum "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Projects.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9f325168e05fb52ae01803565fe54ee543eafc8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTest.Components
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
#line 2 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Projects.razor"
using BlazorTest.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Projects.razor"
using BlazorTest.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Projects.razor"
using BlazorTest.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Projects.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/project")]
    public partial class Projects : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Projects.razor"
       

    public string Title { get; set; }
    public string Description { get; set; }
    public string CreateResponse { get; set; }
    public List<BlazorTest.Model.Project> pr { get; set; }
    Message updateMessage;

    public async System.Threading.Tasks.Task Create()
    {
        try
        {

            if(pr.Count == 0)
            {
                pr.Add(new Model.Project
                {
                    Title = Title,
                    Description = Description,
                    Id = 1
                });
            }
            else
            {
                pr.Add(new Model.Project
                {
                    Title = Title,
                    Description = Description,
                    Id = pr[pr.Count - 1].Id + 1
                });
            }

            await controller.CreateProject(AsyncClient, appData.Username, Title, Description);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    protected override async System.Threading.Tasks.Task OnInitializedAsync()
    {
        try
        {
            string json = await AsyncClient.SendAsync(JsonConvert.SerializeObject(new Message
            {
                Method = "userprojects",
                Resource = "project",
                Fields = new Fields
                {
                    User = new User
                    {
                        Username = appData.Username
                    }
                }
            }));

            updateMessage = JsonConvert.DeserializeObject<Message>(json);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    protected override System.Threading.Tasks.Task OnParametersSetAsync()
    {
        try
        {
            if(updateMessage != null)
            {
                pr = updateMessage.Fields.Projects as List<BlazorTest.Model.Project>;
                return base.OnParametersSetAsync();
            }
            return base.OnParametersSetAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData appData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectController controller { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Networking.AsyncClient AsyncClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
