#pragma checksum "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c78a58f72de3fc6043ed8f75f61e8562c52d395"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
using BlazorTest.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
using BlazorTest.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
using BlazorTest.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/project/{Id:int}")]
    public partial class Project : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card text-center");
            __builder.AddAttribute(2, "id", "projectCard");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.AddAttribute(6, "id", "projectCardHeader");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "nav nav-tabs card-header-tabs");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<li>\r\n\r\n            </li>\r\n            ");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "class", "nav-item");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
                                                  e => ShowUsers()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "class", "btn btn-purple");
            __builder.AddContent(19, "Users");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "class", "nav-item");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
                                                  e => ShowChannels()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-purple");
            __builder.AddContent(29, "Channels");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "nav-item");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "type", "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
                                                  e => ShowTasks()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "class", "btn btn-purple");
            __builder.AddContent(39, "Tasks");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "card-body");
            __builder.AddMarkupContent(46, "\r\n\r\n");
#nullable restore
#line 31 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
         if (PageState == State.Users)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "            ");
            __builder.OpenComponent<BlazorTest.Components.ProjectUsers>(48);
            __builder.AddAttribute(49, "ThisProject", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTest.Model.Project>(
#nullable restore
#line 33 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
                                        ThisProject

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 34 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
        }
        else if (PageState == State.Tasks)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                ");
            __builder.OpenComponent<BlazorTest.Components.Tasks>(52);
            __builder.AddAttribute(53, "ProjectId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 37 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
                                   Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "Admin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
                                               ThisProject.OwnerUsername

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 38 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
        }
        else if (PageState == State.Channels)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "            ");
            __builder.OpenComponent<BlazorTest.Components.Channels>(57);
            __builder.AddAttribute(58, "ProjectId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
                                  ThisProject.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "Admin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
                                                          ThisProject.OwnerUsername

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 42 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
        }
        else if (PageState == State.None)
        {
            if (ThisProject != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "                ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "container");
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "card text-center ");
            __builder.AddAttribute(67, "id", "pp");
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.AddMarkupContent(69, "<div class=\"card-header\">\r\n                        Project\r\n                    </div>\r\n                    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "card-body");
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.OpenElement(73, "h5");
            __builder.AddAttribute(74, "class", "card-title");
            __builder.AddContent(75, 
#nullable restore
#line 53 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
                                                ThisProject.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                        ");
            __builder.OpenElement(77, "p");
            __builder.AddAttribute(78, "class", "card-text");
            __builder.AddContent(79, 
#nullable restore
#line 54 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
                                              ThisProject.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.AddMarkupContent(82, "<div class=\"card-footer text-muted\">\r\n                        Slit Framework\r\n                    </div>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 61 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Project.razor"
       

    [Parameter]
    public int Id { get; set; }

    public Model.Project ThisProject { get; set; }
    public string ProjectJson { get; set; }

    public enum State
    {
        Users,
        Tasks,
        Channels,
        None
    }

    public State PageState { get; set; } = State.Users;

    public string NavLinkStatus { get; set; }

    public void SetNavLinkStatus(string status)
    {
        NavLinkStatus = status;
    }

    public void ShowChannels()
    {
        try
        {
            PageState = State.Channels;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void ShowTasks()
    {
        try
        {
            PageState = State.Tasks;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void ShowUsers()
    {
        try
        {
            PageState = State.Users;
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
            PageState = State.None;
            ProjectJson = await controller.GetProjectInfo(AsyncClient, Id);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    protected override async System.Threading.Tasks.Task OnParametersSetAsync()
    {
        {
            try
            {
                Message x = JsonConvert.DeserializeObject<Message>(ProjectJson);
                var y = x.Fields.Projects as List<Model.Project>;
                ThisProject = y[0];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            await base.OnParametersSetAsync();

        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData appData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectController controller { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Networking.AsyncClient AsyncClient { get; set; }
    }
}
#pragma warning restore 1591
