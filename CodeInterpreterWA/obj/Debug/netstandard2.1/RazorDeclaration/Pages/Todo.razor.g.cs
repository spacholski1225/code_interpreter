#pragma checksum "D:\C# Projects\CodeInterpreterWA\CodeInterpreterWA\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9117d2c71902362ea68f3bf89d72d969b4f3826b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
