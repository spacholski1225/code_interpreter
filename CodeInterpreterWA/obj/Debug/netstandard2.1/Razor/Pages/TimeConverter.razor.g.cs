#pragma checksum "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\TimeConverter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63ddb271d09bd6d525ba9afd16332a81c6704366"
// <auto-generated/>
#pragma warning disable 1591
namespace CodeInterpreterWA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA.Models;

#line default
#line hidden
#nullable disable
    public partial class TimeConverter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<label>Hours</label>\r\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "number");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "placeholder", "Hours.....");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\TimeConverter.razor"
                                                                                      Hours

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Hours = __value, Hours, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\TimeConverter.razor"
                                                  ConvertTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "\r\n            <span class=\"oi oi-clock\"></span> Converts\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
#nullable restore
#line 12 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\TimeConverter.razor"
     if(_seconds != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row blockquote mt-5");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "span");
            __builder.AddContent(29, "In ");
            __builder.AddContent(30, 
#nullable restore
#line 15 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\TimeConverter.razor"
                      Hours

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, " hours we have ");
            __builder.AddContent(32, 
#nullable restore
#line 15 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\TimeConverter.razor"
                                           _seconds

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, " seconds.  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 17 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\TimeConverter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\TimeConverter.razor"
       
    int? _seconds = null;
    public int? Hours { get; set; }

    private void ConvertTime()
    {
        _seconds = Hours * 3600;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
