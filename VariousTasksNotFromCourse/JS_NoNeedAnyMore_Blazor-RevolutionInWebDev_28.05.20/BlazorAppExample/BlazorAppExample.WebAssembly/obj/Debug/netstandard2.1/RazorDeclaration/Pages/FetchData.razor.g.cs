#pragma checksum "D:\CBS_Pract\VariousTasksNotFromCourse\JS_NoNeedAnyMore_Blazor-RevolutionInWebDev_28.05.20\BlazorAppExample\BlazorAppExample.WebAssembly\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d21b87bc8a2e8f0317d1e6f682a62bad19fe749"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppExample.WebAssembly.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CBS_Pract\VariousTasksNotFromCourse\JS_NoNeedAnyMore_Blazor-RevolutionInWebDev_28.05.20\BlazorAppExample\BlazorAppExample.WebAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CBS_Pract\VariousTasksNotFromCourse\JS_NoNeedAnyMore_Blazor-RevolutionInWebDev_28.05.20\BlazorAppExample\BlazorAppExample.WebAssembly\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CBS_Pract\VariousTasksNotFromCourse\JS_NoNeedAnyMore_Blazor-RevolutionInWebDev_28.05.20\BlazorAppExample\BlazorAppExample.WebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CBS_Pract\VariousTasksNotFromCourse\JS_NoNeedAnyMore_Blazor-RevolutionInWebDev_28.05.20\BlazorAppExample\BlazorAppExample.WebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CBS_Pract\VariousTasksNotFromCourse\JS_NoNeedAnyMore_Blazor-RevolutionInWebDev_28.05.20\BlazorAppExample\BlazorAppExample.WebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CBS_Pract\VariousTasksNotFromCourse\JS_NoNeedAnyMore_Blazor-RevolutionInWebDev_28.05.20\BlazorAppExample\BlazorAppExample.WebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CBS_Pract\VariousTasksNotFromCourse\JS_NoNeedAnyMore_Blazor-RevolutionInWebDev_28.05.20\BlazorAppExample\BlazorAppExample.WebAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CBS_Pract\VariousTasksNotFromCourse\JS_NoNeedAnyMore_Blazor-RevolutionInWebDev_28.05.20\BlazorAppExample\BlazorAppExample.WebAssembly\_Imports.razor"
using BlazorAppExample.WebAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CBS_Pract\VariousTasksNotFromCourse\JS_NoNeedAnyMore_Blazor-RevolutionInWebDev_28.05.20\BlazorAppExample\BlazorAppExample.WebAssembly\_Imports.razor"
using BlazorAppExample.WebAssembly.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\CBS_Pract\VariousTasksNotFromCourse\JS_NoNeedAnyMore_Blazor-RevolutionInWebDev_28.05.20\BlazorAppExample\BlazorAppExample.WebAssembly\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
