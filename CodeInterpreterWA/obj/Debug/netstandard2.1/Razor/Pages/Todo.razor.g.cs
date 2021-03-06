#pragma checksum "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9117d2c71902362ea68f3bf89d72d969b4f3826b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Todo</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-md-4 mb-3");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "placeholder", "Todo item");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\Todo.razor"
                                                               _todo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _todo = __value, _todo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary mt-1");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\Todo.razor"
                                                   Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "ADD");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n\r\n");
            __builder.OpenElement(16, "ul");
            __builder.AddAttribute(17, "class", "list-group");
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 12 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\Todo.razor"
     foreach (var todo in todos)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "list-group-item");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.AddContent(23, 
#nullable restore
#line 15 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\Todo.razor"
             todo.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "float-right custom-control custom-checkbox");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "checkbox");
            __builder.AddAttribute(30, "class", "form-control-input");
            __builder.AddAttribute(31, "id", "doneCheckbox");
            __builder.AddAttribute(32, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\Todo.razor"
                                                                                           todo.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.IsDone = __value, todo.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.AddMarkupContent(35, "<label class=\"form-check-label\" for=\"doneCheckbox\">Done</label>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 21 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\Todo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\Todo.razor"
       
    private IList<TodoItemModel> todos = new List<TodoItemModel>
    {
        new TodoItemModel
        {
           Title = "Nauczyc sie blazor",
           IsDone = false
        },
        new TodoItemModel
        {
           Title = "napisac przelicznik z $ na zl",
           IsDone = false
        }
};
    string _todo;
    private void Add()
    {
        todos.Add(new TodoItemModel { Title = _todo });
        _todo = string.Empty;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
