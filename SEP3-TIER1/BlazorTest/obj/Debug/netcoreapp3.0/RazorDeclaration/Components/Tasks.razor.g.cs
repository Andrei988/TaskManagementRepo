#pragma checksum "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "812f4851512ad9d3ac85d9834c84604f64582745"
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
#line 2 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
using BlazorTest.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
using BlazorTest.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
using BlazorTest.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
using Task = System.Threading.Tasks.Task;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tasks")]
    public partial class Tasks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 153 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
 

    [Parameter]
    public int ProjectId { get; set; }

    [Parameter]
    public string Admin { get; set; }

    public List<Model.Task> TaskList { get; set; }

    public string InitMessage { get; set; }

    public string AssignTaskUsername { get; set; }

    public string TaskDescription { get; set; }

    public DateTime TaskDeadline { get; set; }

    public string ColorLabel { get; set; }

    public bool SubTaskView { get; set; }

    public int TaskId { get; set; }

    public void SetColorLabel(string color)
    {
        ColorLabel = color;
    }

    public void ViewSubTasks(int id)
    {
        TaskId = id;
        SubTaskView = true;
    }

    public async Task CreateTask(string Username, string Description, DateTime Deadline, string ColorLabel)
    {

        int TaskId = 0;

        if (TaskList.Count == 0)
        {
            TaskId = 1;
        }
        else
        {
            TaskId = TaskList[TaskList.Count - 1].Id + 1;
        }

        Model.Task task = new Model.Task
        {
            Id = TaskId,
            Username = Username,
            ProjectId = ProjectId,
            Description = Description,
            StartTime = DateTime.Now,
            EndTime = Deadline,
            ColorLabel = ColorLabel
        };

        TaskList.Add(task);

        await controller.CreateTask(AsyncClient, task);
    }

    public async Task DeleteTask(int id)
    {
        try
        {
            foreach (var task in TaskList)
            {
                if (task.Id == id)
                {
                    TaskList.Remove(task);
                    await controller.DeleteTask(AsyncClient, task);
                    break;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    protected override async Task OnInitializedAsync()
    {
        InitMessage = await controller.GetAllTasks(AsyncClient, ProjectId);
    }

    protected override Task OnParametersSetAsync()
    {
        Message m = JsonConvert.DeserializeObject<Message>(InitMessage);
        TaskList = m.Fields.Tasks as List<Model.Task>;
        return base.OnParametersSetAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData appData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TasksController controller { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Networking.AsyncClient AsyncClient { get; set; }
    }
}
#pragma warning restore 1591
