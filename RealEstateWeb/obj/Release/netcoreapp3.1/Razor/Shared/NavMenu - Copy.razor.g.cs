#pragma checksum "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\Shared\NavMenu - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef5dd7a1803cf618907ee69bf16320ddaabb8b85"
// <auto-generated/>
#pragma warning disable 1591
namespace RealEstateWeb.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\_Imports.razor"
using RealEstateWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\_Imports.razor"
using RealEstateWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>Ben\'s Properties</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\Shared\NavMenu - Copy.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\Shared\NavMenu - Copy.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\Shared\NavMenu - Copy.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\Shared\NavMenu - Copy.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "span");
                __builder2.AddAttribute(27, "aria-hidden", "true");
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenComponent<MatBlazor.MatIcon>(29);
                __builder2.AddAttribute(30, "Icon", "home");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, " Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n        ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "nav-item px-3");
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", "nav-link");
            __builder.AddAttribute(40, "href", "listings");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.OpenElement(43, "span");
                __builder2.AddAttribute(44, "aria-hidden", "true");
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.OpenComponent<MatBlazor.MatIcon>(46);
                __builder2.AddAttribute(47, "Icon", "store");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, " Listings\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "li");
            __builder.AddAttribute(53, "class", "nav-item px-3");
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(55);
            __builder.AddAttribute(56, "class", "nav-link");
            __builder.AddAttribute(57, "href", "testimonials");
            __builder.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(59, "\r\n                ");
                __builder2.OpenElement(60, "span");
                __builder2.AddAttribute(61, "aria-hidden", "true");
                __builder2.AddMarkupContent(62, "\r\n                    ");
                __builder2.OpenComponent<MatBlazor.MatIcon>(63);
                __builder2.AddAttribute(64, "Icon", "favorite");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, " Testimonials\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.OpenElement(69, "li");
            __builder.AddAttribute(70, "class", "nav-item px-3");
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(72);
            __builder.AddAttribute(73, "class", "nav-link");
            __builder.AddAttribute(74, "href", "contactus");
            __builder.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(76, "\r\n                ");
                __builder2.OpenElement(77, "span");
                __builder2.AddAttribute(78, "aria-hidden", "true");
                __builder2.AddMarkupContent(79, "\r\n                    ");
                __builder2.OpenComponent<MatBlazor.MatIcon>(80);
                __builder2.AddAttribute(81, "Icon", "contacts");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, " Contact Us\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\nirjhar.vermani\source\repos\RealEstateWeb\RealEstateWeb\Shared\NavMenu - Copy.razor"
       
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
