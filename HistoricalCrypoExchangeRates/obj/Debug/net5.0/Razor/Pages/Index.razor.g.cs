#pragma checksum "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b44c809052ac5671cd0c703119efc6765016c86"
// <auto-generated/>
#pragma warning disable 1591
namespace HistoricalCrypoExchangeRates.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\_Imports.razor"
using HistoricalCrypoExchangeRates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\_Imports.razor"
using HistoricalCrypoExchangeRates.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDatePicker>(0);
            __builder.AddAttribute(1, "Label", "Pick a date");
            __builder.AddAttribute(2, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 5 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\Pages\Index.razor"
                                               ExchangeRateDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ExchangeRateDate = __value, ExchangeRateDate))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n<br>\r\n");
            __builder.OpenComponent<MudBlazor.MudButton>(5);
            __builder.AddAttribute(6, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 7 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\Pages\Index.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 7 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\Pages\Index.razor"
                                           Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\Pages\Index.razor"
                                                                   GetHistoricData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(10, "Check History");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n<br>");
#nullable restore
#line 10 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\Pages\Index.razor"
 if (RatesResponse is not null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\Pages\Index.razor"
     if (RatesResponse.LoadedFromCache)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudAlert>(12);
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(14, "Loaded from cache");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudAlert>(15);
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(17, "Loaded from API");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 19 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __Blazor.HistoricalCrypoExchangeRates.Pages.Index.TypeInference.CreateMudTable_0(__builder, 18, 19, 
#nullable restore
#line 20 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\Pages\Index.razor"
                      RatesResponse.Rates

#line default
#line hidden
#nullable disable
            , 20, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(21);
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(23, "Crypto");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(25);
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(27, "Rate");
                }
                ));
                __builder2.CloseComponent();
            }
            , 28, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(29);
                __builder2.AddAttribute(30, "DataLabel", "Crypto");
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(32, 
#nullable restore
#line 26 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\Pages\Index.razor"
                                       context.Key

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(34);
                __builder2.AddAttribute(35, "DataLabel", "Rate");
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, 
#nullable restore
#line 27 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\Pages\Index.razor"
                                     context.Value

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 30 "C:\Users\FrosTea\source\repos\HistoricalCrypoExchangeRates\HistoricalCrypoExchangeRates\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.HistoricalCrypoExchangeRates.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "HeaderContent", __arg1);
        __builder.AddAttribute(__seq2, "RowTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
