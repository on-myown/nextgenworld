#pragma checksum "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fe44e8fe1cb2ecd65d61d7b4b731ea3909afbe0"
// <auto-generated/>
#pragma warning disable 1591
namespace OASIS_BLAZOR.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using OASIS_BLAZOR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using OASIS_BLAZOR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Pages\Profile.razor"
using OASIS_BLAZOR.Popups;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile/{userId}")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "profile-container");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "profile-content");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.AddMarkupContent(6, "<div class=\"banner\">\r\n                <img src=\"/images/profile-bg.jpg\" asp-append-version=\"true\" width=\"100%\">\r\n            </div>\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "profile-title");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", "https://avatars2.githubusercontent.com/u/3522378?s=400&u=de47609626c15072ce611ac190034458c0031ca1&v=4");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Pages\Profile.razor"
                                () => AvtarUploadModal.Open()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "alt", "avatar");
            __builder.AddAttribute(14, "class", "profile-photo");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "margin: 25px 50px");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "h1");
            __builder.AddAttribute(20, "class", "text-name");
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.AddContent(22, 
#nullable restore
#line 15 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Pages\Profile.razor"
                         firstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, " ");
            __builder.AddContent(24, 
#nullable restore
#line 15 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Pages\Profile.razor"
                                    lastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "style", "font-size: 18px");
            __builder.AddContent(28, "@");
            __builder.AddContent(29, 
#nullable restore
#line 16 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Pages\Profile.razor"
                                                            userId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.AddMarkupContent(31, "<span>\r\n                            <img src=\"/images/badges/superhero.png\" alt=\"badge\" class=\"profile-badge\">\r\n                        </span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n                    ");
            __builder.OpenElement(33, "p");
            __builder.AddAttribute(34, "style", "color:white");
            __builder.AddContent(35, "Karma ");
            __builder.AddContent(36, 
#nullable restore
#line 23 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Pages\Profile.razor"
                                                  karmaString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n            ");
            __builder.AddMarkupContent(40, @"<div class=""profile-data"">
                <div class=""side-bar"">
                    <div style=""margin-bottom:5px"">
                        <button class=""button-main"" style=""width: 100%"">
                            <i class=""fas fa-user-friends"" aria-hidden=""true""></i>
                            &nbsp;ADD FRIEND
                        </button>
                    </div>
                    <div style=""display: flex"">
                        <button class=""button-main"" style=""width: 30%; margin-right:5px"">
                            <i class=""fas fa-heart"" aria-hidden=""true""></i>
                            &nbsp;35
                        </button>
                        <button class=""button-main"" style=""width: 70%"">
                            <i class=""fa fa-plus"" aria-hidden=""true""></i>
                            &nbsp;FOLLOW
                        </button>
                    </div>
                </div>
                <div class=""main-side"">

                </div>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n        ");
            __builder.OpenComponent<OASIS_BLAZOR.Popups.AvatarUpload>(42);
            __builder.AddComponentReferenceCapture(43, (__value) => {
#nullable restore
#line 56 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Pages\Profile.razor"
                                                AvtarUploadModal = (OASIS_BLAZOR.Popups.AvatarUpload)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n");
            __builder.AddMarkupContent(46, @"<style>
    .profile-container {
        background-image: url(/images/profile-container-bg.jpg);
        background-size: cover;
        height: 100vh;
        overflow: hidden;
    }

    .profile-content {
        max-width: 1200px;
        margin: auto;
        margin-top: 80px;
        margin-bottom: 80px;
        position: relative;
        background-color: #16213E;
        height: 800px;
        border-radius: 10px;
        overflow: hidden;
    }

    .banner {
        height: 200px;
        object-fit: contain;
        overflow: hidden;
    }

    .profile-title {
        position: absolute;
        left: 100px;
        top: 100px;
        display: flex;
    }

    .profile-photo {
        width: 200px;
        height: 200px;
        background-color: white;
        border-radius: 50%;
        border: 6px solid white;
        cursor: pointer;
    }

    .text-name {
        color: white;
        margin-bottom: 0px;
    }

    .profile-badge {
        width: 30px;
        height: 25px;
    }

    .profile-data {
        margin: 120px 100px 100px 100px;
        display: flex;
    }

    .side-bar {
        width: 200px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Pages\Profile.razor"
       
    [Parameter]
    public string userId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int karma { get; set; }

    private string karmaString;
    private OASIS_BLAZOR.Popups.AvatarUpload AvtarUploadModal { get; set; }

    protected override void OnInitialized()
    {
        userId = "dellams";
        firstName = "David";
        lastName = "Ellams";
        karma = 9999999;

        karmaString = karma.ToString("##,##0");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
