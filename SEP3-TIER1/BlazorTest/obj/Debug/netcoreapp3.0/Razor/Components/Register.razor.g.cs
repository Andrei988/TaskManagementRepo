#pragma checksum "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec7e63e81fee8866a650b0dfb49402452745f595"
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
#line 2 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Register.razor"
using BlazorTest.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Register.razor"
using BlazorTest.Networking;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(NoNavLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row justify-content-center");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-6");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<header class=\"card-header\">\r\n                    <h4 class=\"card-title mt-2\">Sign up</h4>\r\n                </header>\r\n                ");
            __builder.OpenElement(13, "article");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "form");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-row");
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col form-group");
            __builder.AddMarkupContent(23, "\r\n                                ");
            __builder.AddMarkupContent(24, "<label>First name </label>\r\n                                ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "placeholder", "");
            __builder.AddAttribute(29, "required", true);
            __builder.AddAttribute(30, "autofocus", true);
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Register.razor"
                                                          FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FirstName = __value, FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, " \r\n                            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col form-group");
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.AddMarkupContent(38, "<label>Last name</label>\r\n                                ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "placeholder", "");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Register.razor"
                                                          LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LastName = __value, LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col form-group");
            __builder.AddMarkupContent(49, "\r\n                                ");
            __builder.AddMarkupContent(50, "<label>Username</label>\r\n                                ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "text");
            __builder.AddAttribute(53, "class", "form-control");
            __builder.AddAttribute(54, "placeholder", "");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Register.razor"
                                                          Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Username = __value, Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, " \r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, " \r\n                        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "form-group");
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.OpenElement(63, "label");
            __builder.AddAttribute(64, "class", "form-check form-check-inline");
            __builder.AddMarkupContent(65, "\r\n                                ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "class", "form-check-input");
            __builder.AddAttribute(68, "type", "radio");
            __builder.AddAttribute(69, "name", "gender");
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Register.razor"
                                                                       GenderMale

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GenderMale = __value, GenderMale));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                                ");
            __builder.AddMarkupContent(73, "<span class=\"form-check-label\"> Male </span>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "label");
            __builder.AddAttribute(76, "class", "form-check form-check-inline");
            __builder.AddMarkupContent(77, "\r\n                                ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "class", "form-check-input");
            __builder.AddAttribute(80, "type", "radio");
            __builder.AddAttribute(81, "name", "gender");
            __builder.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Register.razor"
                                                                       GenderFemale

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GenderFemale = __value, GenderFemale));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                                ");
            __builder.AddMarkupContent(85, "<span class=\"form-check-label\"> Female</span>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, " \r\n\r\n                        ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "form-group");
            __builder.AddMarkupContent(90, "\r\n                            ");
            __builder.AddMarkupContent(91, "<label>Create password</label>\r\n                            ");
            __builder.OpenElement(92, "input");
            __builder.AddAttribute(93, "class", "form-control");
            __builder.AddAttribute(94, "type", "password");
            __builder.AddAttribute(95, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Register.razor"
                                                                               Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                            ");
            __builder.AddMarkupContent(98, "<label>Repeat password</label>\r\n                            ");
            __builder.OpenElement(99, "input");
            __builder.AddAttribute(100, "class", "form-control");
            __builder.AddAttribute(101, "type", "password");
            __builder.AddAttribute(102, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Register.razor"
                                                                               SecondPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SecondPassword = __value, SecondPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, " \r\n\r\n                        ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "form-group");
            __builder.AddMarkupContent(108, "\r\n                            ");
            __builder.OpenElement(109, "button");
            __builder.AddAttribute(110, "type", "submit");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Register.razor"
                                                            SignUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(112, "class", "btn btn-primary btn-block");
            __builder.AddContent(113, "Register");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                            ");
            __builder.OpenElement(115, "p");
            __builder.AddContent(116, 
#nullable restore
#line 53 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Register.razor"
                                RegisterStatus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, " \r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, " \r\n                ");
            __builder.AddMarkupContent(121, "<div class=\"border-top card-body text-center\">Already registered? <a href>Log In</a></div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, " \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, " \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, " \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "D:\VIA\SEM3\SEP3\repo\SEP3-TIER1\BlazorTest\Components\Register.razor"
       
    [Parameter]
    public string FirstName { get; set; }
    [Parameter]
    public string LastName { get; set; }
    [Parameter]
    public string Username { get; set; }
    [Parameter]
    public string Password { get; set; }
    [Parameter]
    public string SecondPassword { get; set; }
    [Parameter]
    public string GenderMale { get; set; }
    [Parameter]
    public string GenderFemale { get; set; }
    [Parameter]
    public string Gender { get; set; }
    [Parameter]
    public string RegisterStatus { get; set; }

    public async Task SignUp()
    {

        if (GenderMale == "on")
        {
            Gender = "M";
        }
        else if (GenderFemale == "on")
        {
            Gender = "F";
        }

        string Response = await controller.Register(Client, FirstName, LastName, Username, Password, SecondPassword, Gender);

        if (Response == "true")
        {
            NavigationManager.NavigateTo("");
        }
        else if (Response == "false")
        {
            RegisterStatus = "That username is already taken";
        }
        else
        {
            RegisterStatus = "Something went wrong";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AsyncClient Client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RegisterController controller { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.AppData appData { get; set; }
    }
}
#pragma warning restore 1591
