#pragma checksum "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\Components\Projects.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1208c3da48e7d6e23e5bee9b3cfcb848794d630e"
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
#line 1 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\_Imports.razor"
using BlazorTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\_Imports.razor"
using BlazorTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\Components\Projects.razor"
using BlazorTest.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\Components\Projects.razor"
using BlazorTest.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\Components\Projects.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/project")]
    public class Projects : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "D:\VIA\SEM3\SEP3\repo\slit-tier-1\BlazorTest\Components\Projects.razor"
       

    public string ProjectName { get; set; }
    public string ProjectDescription { get; set; }
    public string CreateResponse { get; set; }
    public ICollection<Project> pr { get; set; }
    Message updateMessage;
    Message createMessage;

//    protected override void OnInitialized()
//    {
//        UpdatePage();
//    }
//
//    public void UpdatePage()
//    {
//        updateMessage = JsonConvert.DeserializeObject<Message>(Client.SendReuqest(JsonConvert.SerializeObject(new Message
//        {
//            Method = "userprojects",
//            Resource = "project",
//            Fields = new Fields
//            {
//                User = new User
//                {
//                    Username = appData.Username
//                }
//            }
//        })));
//
//        pr = updateMessage.Fields.Projects as List<Project>;
//
//    }
//
    public void Create()
    {
//        createMessage = JsonConvert.DeserializeObject<Message>(ProjectController.CreateProject(Client, appData.Username, ProjectName, ProjectDescription));
//        if (createMessage.Fields.ResponseCode == 201) CreateResponse = "Project created";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectController ProjectController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.AppData appData { get; set; }
    }
}
#pragma warning restore 1591
