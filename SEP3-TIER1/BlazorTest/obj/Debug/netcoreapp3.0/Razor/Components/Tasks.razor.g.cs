#pragma checksum "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "812f4851512ad9d3ac85d9834c84604f64582745"
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
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Admin: ");
            __builder.AddContent(2, 
#nullable restore
#line 11 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
            Admin

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
#nullable restore
#line 13 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
 if (Admin == appData.Username && SubTaskView == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-6");
            __builder.AddAttribute(7, "id", "createTask");
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "form");
            __builder.AddAttribute(10, "class", "text-center");
            __builder.AddAttribute(11, "action", "#!");
            __builder.AddMarkupContent(12, "\r\n\r\n        ");
            __builder.AddMarkupContent(13, "<p class=\"h4 mb-4\">Create task</p>\r\n\r\n        ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "id", "defaultContactFormName");
            __builder.AddAttribute(17, "class", "form-control mb-4");
            __builder.AddAttribute(18, "placeholder", "Descripton");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                                                                 TaskDescription

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TaskDescription = __value, TaskDescription));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n        ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "id", "defaultContactFormName");
            __builder.AddAttribute(25, "class", "form-control mb-4");
            __builder.AddAttribute(26, "placeholder", "Username");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                                                               AssignTaskUsername

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AssignTaskUsername = __value, AssignTaskUsername));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            \r\n        ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "date");
            __builder.AddAttribute(32, "id", "defaultContactFormName");
            __builder.AddAttribute(33, "class", "form-control mb-4");
            __builder.AddAttribute(34, "placeholder", "Deadline");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                                                               TaskDeadline

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TaskDeadline = __value, TaskDeadline, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "btn-group");
            __builder.AddAttribute(40, "role", "group");
            __builder.AddAttribute(41, "aria-label", "Basic example");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "type", "button");
            __builder.AddAttribute(45, "class", "btn btn-secondary");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                        e => SetColorLabel("secondary")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "Grey");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "btn btn-primary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                      e => SetColorLabel("primary")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(53, "Blue");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "type", "button");
            __builder.AddAttribute(57, "class", "btn btn-success");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                      e => SetColorLabel("success")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(59, "Green");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "type", "button");
            __builder.AddAttribute(63, "class", "btn btn-info");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                   e => SetColorLabel("info")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(65, "Light blue");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "type", "button");
            __builder.AddAttribute(69, "class", "btn btn-warning");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                      e => SetColorLabel("warning")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(71, "Yellow");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "type", "button");
            __builder.AddAttribute(75, "class", "btn btn-danger");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                     e => SetColorLabel("danger")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(77, "Red");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n            ");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "type", "button");
            __builder.AddAttribute(82, "class", "btn btn-info");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                   e => CreateTask(AssignTaskUsername, TaskDescription, TaskDeadline, ColorLabel)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(84, "Create task");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 40 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 42 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
 if (Admin == appData.Username && TaskList != null && TaskList.Count != 0 && SubTaskView == false)
{
    

    


#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "    ");
            __builder.OpenElement(90, "table");
            __builder.AddAttribute(91, "class", "table");
            __builder.AddMarkupContent(92, "\r\n\r\n        ");
            __builder.AddMarkupContent(93, @"<thead class=""thead-dark"">
            <tr>
                <th scope=""col"">#Id</th>
                <th scope=""col"">Assigned to</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Start date</th>
                <th scope=""col"">Deadline</th>
                <th scope=""col"">Color label</th>
                <th scope=""col"">Progress</th>
                <th scope=""col"">Delete</th>
            </tr>
        </thead>

        ");
            __builder.OpenElement(94, "tbody");
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 64 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
             foreach (var task in TaskList)
            {
                if (!task.IsComplete)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "                    ");
            __builder.OpenElement(97, "tr");
            __builder.AddAttribute(98, "class", "table-primary");
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.OpenElement(100, "td");
            __builder.AddContent(101, 
#nullable restore
#line 69 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.OpenElement(103, "td");
            __builder.AddContent(104, 
#nullable restore
#line 70 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                        ");
            __builder.OpenElement(106, "td");
            __builder.AddContent(107, 
#nullable restore
#line 71 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                        ");
            __builder.OpenElement(109, "td");
            __builder.AddContent(110, 
#nullable restore
#line 72 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.StartTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                        ");
            __builder.OpenElement(112, "td");
            __builder.AddContent(113, 
#nullable restore
#line 73 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.EndTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                        ");
            __builder.OpenElement(115, "td");
            __builder.AddContent(116, " ");
            __builder.OpenElement(117, "button");
            __builder.AddAttribute(118, "type", "button");
            __builder.AddAttribute(119, "class", "btn" + " btn-" + (
#nullable restore
#line 74 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                   task.ColorLabel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "disabled", true);
            __builder.AddContent(121, "Label");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                        ");
            __builder.OpenElement(123, "td");
            __builder.OpenElement(124, "button");
            __builder.AddAttribute(125, "type", "button");
            __builder.AddAttribute(126, "class", "btn btn-danger");
            __builder.AddAttribute(127, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                                     e => ViewSubTasks(task.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(128, "View progress");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                        ");
            __builder.OpenElement(130, "td");
            __builder.OpenElement(131, "button");
            __builder.AddAttribute(132, "type", "button");
            __builder.AddAttribute(133, "class", "btn btn-danger");
            __builder.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                                     e => DeleteTask(task.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(135, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n");
#nullable restore
#line 78 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"

                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(138, "                    ");
            __builder.OpenElement(139, "tr");
            __builder.AddAttribute(140, "class", "table-success");
            __builder.AddMarkupContent(141, "\r\n                        ");
            __builder.OpenElement(142, "td");
            __builder.AddContent(143, 
#nullable restore
#line 83 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                        ");
            __builder.OpenElement(145, "td");
            __builder.AddContent(146, 
#nullable restore
#line 84 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                        ");
            __builder.OpenElement(148, "td");
            __builder.AddContent(149, 
#nullable restore
#line 85 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                        ");
            __builder.OpenElement(151, "td");
            __builder.AddContent(152, 
#nullable restore
#line 86 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.StartTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                        ");
            __builder.OpenElement(154, "td");
            __builder.AddContent(155, 
#nullable restore
#line 87 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.EndTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n                        ");
            __builder.OpenElement(157, "td");
            __builder.AddContent(158, " ");
            __builder.OpenElement(159, "button");
            __builder.AddAttribute(160, "type", "button");
            __builder.AddAttribute(161, "class", "btn" + " btn-" + (
#nullable restore
#line 88 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                   task.ColorLabel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(162, "disabled", true);
            __builder.AddContent(163, "Label");
            __builder.CloseElement();
            __builder.AddContent(164, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                        ");
            __builder.AddMarkupContent(166, "<td> <button type=\"button\" class=\"btn btn-success\" disabled>Done</button> </td>\r\n                        ");
            __builder.OpenElement(167, "td");
            __builder.AddContent(168, " ");
            __builder.OpenElement(169, "button");
            __builder.AddAttribute(170, "type", "button");
            __builder.AddAttribute(171, "class", "btn btn-danger");
            __builder.AddAttribute(172, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                                      e => DeleteTask(task.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(173, " Delete ");
            __builder.CloseElement();
            __builder.AddContent(174, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n");
#nullable restore
#line 92 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(177, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n");
#nullable restore
#line 96 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"

} 
else if (TaskList != null && TaskList.Count != 0 && SubTaskView == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(180, "    ");
            __builder.OpenElement(181, "table");
            __builder.AddAttribute(182, "class", "table");
            __builder.AddMarkupContent(183, "\r\n\r\n        ");
            __builder.AddMarkupContent(184, @"<thead class=""thead-dark"">
            <tr>
                <th scope=""col"">#Id</th>
                <th scope=""col"">Assigned to</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Start date</th>
                <th scope=""col"">Deadline</th>
                <th scope=""col"">Color label</th>
                <th scope=""col"">Progress</th>
            </tr>
        </thead>

        ");
            __builder.OpenElement(185, "tbody");
            __builder.AddMarkupContent(186, "\r\n");
#nullable restore
#line 115 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
             foreach (var task in TaskList)
            {
                if (!task.IsComplete)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(187, "                    ");
            __builder.OpenElement(188, "tr");
            __builder.AddAttribute(189, "class", "table-primary");
            __builder.AddMarkupContent(190, "\r\n                        ");
            __builder.OpenElement(191, "td");
            __builder.AddContent(192, 
#nullable restore
#line 120 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n                        ");
            __builder.OpenElement(194, "td");
            __builder.AddContent(195, 
#nullable restore
#line 121 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n                        ");
            __builder.OpenElement(197, "td");
            __builder.AddContent(198, 
#nullable restore
#line 122 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n                        ");
            __builder.OpenElement(200, "td");
            __builder.AddContent(201, 
#nullable restore
#line 123 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.StartTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n                        ");
            __builder.OpenElement(203, "td");
            __builder.AddContent(204, 
#nullable restore
#line 124 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.EndTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n                        ");
            __builder.OpenElement(206, "td");
            __builder.AddContent(207, " ");
            __builder.OpenElement(208, "button");
            __builder.AddAttribute(209, "type", "button");
            __builder.AddAttribute(210, "class", "btn" + " btn-" + (
#nullable restore
#line 125 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                   task.ColorLabel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(211, "disabled", true);
            __builder.AddContent(212, "Label");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(213, "\r\n                        ");
            __builder.OpenElement(214, "td");
            __builder.OpenElement(215, "button");
            __builder.AddAttribute(216, "type", "button");
            __builder.AddAttribute(217, "class", "btn btn-danger");
            __builder.AddAttribute(218, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 126 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                                     e => ViewSubTasks(task.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(219, "View progress");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(221, "\r\n");
#nullable restore
#line 128 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"

                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(222, "                    ");
            __builder.OpenElement(223, "tr");
            __builder.AddAttribute(224, "class", "table-success");
            __builder.AddMarkupContent(225, "\r\n                        ");
            __builder.OpenElement(226, "td");
            __builder.AddContent(227, 
#nullable restore
#line 133 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(228, "\r\n                        ");
            __builder.OpenElement(229, "td");
            __builder.AddContent(230, 
#nullable restore
#line 134 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(231, "\r\n                        ");
            __builder.OpenElement(232, "td");
            __builder.AddContent(233, 
#nullable restore
#line 135 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(234, "\r\n                        ");
            __builder.OpenElement(235, "td");
            __builder.AddContent(236, 
#nullable restore
#line 136 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.StartTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(237, "\r\n                        ");
            __builder.OpenElement(238, "td");
            __builder.AddContent(239, 
#nullable restore
#line 137 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                             task.EndTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(240, "\r\n                        ");
            __builder.OpenElement(241, "td");
            __builder.AddContent(242, " ");
            __builder.OpenElement(243, "button");
            __builder.AddAttribute(244, "type", "button");
            __builder.AddAttribute(245, "class", "btn" + " btn-" + (
#nullable restore
#line 138 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                                                   task.ColorLabel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(246, "disabled", true);
            __builder.AddContent(247, "Label");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(248, "\r\n                        ");
            __builder.AddMarkupContent(249, "<td> <button type=\"button\" class=\"btn btn-success\" disabled>done</button></td>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(250, "\r\n");
#nullable restore
#line 141 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(251, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(252, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(253, "\r\n");
#nullable restore
#line 145 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
} 
else if(SubTaskView)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(254, "    ");
            __builder.OpenComponent<BlazorTest.Components.SubTasks>(255);
            __builder.AddAttribute(256, "Admin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 148 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                      Admin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(257, "TaskId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 148 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
                                      TaskId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(258, "\r\n");
#nullable restore
#line 149 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Tasks.razor"
}

#line default
#line hidden
#nullable disable
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