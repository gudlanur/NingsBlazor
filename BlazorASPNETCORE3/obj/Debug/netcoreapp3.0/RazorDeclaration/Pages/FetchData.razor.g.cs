#pragma checksum "C:\Users\N.Y.Gudlanur\source\repos\BlazorASPNETCORE3\BlazorASPNETCORE3\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c554b1efb1d3b7c5eec19b7382d238f54872958"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorASPNETCORE3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\N.Y.Gudlanur\source\repos\BlazorASPNETCORE3\BlazorASPNETCORE3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\N.Y.Gudlanur\source\repos\BlazorASPNETCORE3\BlazorASPNETCORE3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\N.Y.Gudlanur\source\repos\BlazorASPNETCORE3\BlazorASPNETCORE3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\N.Y.Gudlanur\source\repos\BlazorASPNETCORE3\BlazorASPNETCORE3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\N.Y.Gudlanur\source\repos\BlazorASPNETCORE3\BlazorASPNETCORE3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\N.Y.Gudlanur\source\repos\BlazorASPNETCORE3\BlazorASPNETCORE3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\N.Y.Gudlanur\source\repos\BlazorASPNETCORE3\BlazorASPNETCORE3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\N.Y.Gudlanur\source\repos\BlazorASPNETCORE3\BlazorASPNETCORE3\_Imports.razor"
using BlazorASPNETCORE3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\N.Y.Gudlanur\source\repos\BlazorASPNETCORE3\BlazorASPNETCORE3\_Imports.razor"
using BlazorASPNETCORE3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\N.Y.Gudlanur\source\repos\BlazorASPNETCORE3\BlazorASPNETCORE3\Pages\FetchData.razor"
using BlazorASPNETCORE3.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\N.Y.Gudlanur\source\repos\BlazorASPNETCORE3\BlazorASPNETCORE3\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
