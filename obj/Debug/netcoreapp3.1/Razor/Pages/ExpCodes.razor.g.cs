#pragma checksum "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3919aee2a8edf264d0da4c64d15f744274d2b6ff"
// <auto-generated/>
#pragma warning disable 1591
namespace Softdent2OpenDentalConversion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Softdent2OpenDentalConversion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Softdent2OpenDentalConversion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
using Softdent2OpenDentalConversion.Context.Softdent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
using Softdent2OpenDentalConversion.Models.Softdent;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ExpCodes")]
    public partial class ExpCodes : SharedCode
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-lg-12 control-section");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddAttribute(4, "style", "display:flex");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col");
            __builder.AddAttribute(7, "style", "flex:30%");
            __builder.AddMarkupContent(8, "<div class=\"row\"><strong>Explosion Code:</strong></div>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfNumericTextBox<double?>>(11);
            __builder.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double?>(
#nullable restore
#line 19 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
                                                           explosionCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "Decimals", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 19 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
                                                                                    2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double?>(
#nullable restore
#line 19 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
                                                                                             0.01

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.AddMarkupContent(16, "<div class=\"row\"><strong>ADA Code</strong></div>\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "row");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfNumericTextBox<double?>>(19);
            __builder.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double?>(
#nullable restore
#line 23 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
                                                           adaCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Decimals", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 23 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
                                                                              2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double?>(
#nullable restore
#line 23 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
                                                                                       0.01

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col");
            __builder.AddAttribute(26, "style", "flex:70%");
            __Blazor.Softdent2OpenDentalConversion.Pages.ExpCodes.TypeInference.CreateSfGrid_0(__builder, 27, 28, 
#nullable restore
#line 27 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
                                 GridData

#line default
#line hidden
#nullable disable
            , 29, 
#nullable restore
#line 27 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
                                                           true

#line default
#line hidden
#nullable disable
            , 30, 
#nullable restore
#line 27 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
            , 31, "300", 32, 
#nullable restore
#line 27 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
                                                                                                                     38

#line default
#line hidden
#nullable disable
            , 33, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(34);
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(36);
                    __builder3.AddAttribute(37, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
                                       nameof(ExplosionCodes.ID)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "HeaderText", "ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(40);
                    __builder3.AddAttribute(41, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
                                       nameof(ExplosionCodes.ExplosionCode)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "HeaderText", "Explosion Code");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(44);
                    __builder3.AddAttribute(45, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
                                       nameof(ExplosionCodes.ADACode)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "HeaderText", "ADA Code");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    <hr>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
       

    private double explosionCode = 0.00;
    private double adaCode = 0.00;

    public List<Softdent2OpenDentalConversion.Models.Softdent.ExplosionCodes> GridData { get; set; }

    SoftdentContext dbSoftdentContext = new SoftdentContext();

    protected override void OnInitialized()
    {
        //ExplosionCodes explosionCodes = new ExplosionCodes();
        //explosionCodes.ExplosionCode = (decimal)100000.00;
        //explosionCodes.ADACode = 4910;
        //dbSoftdentContext.Add(explosionCodes);
        //dbSoftdentContext.SaveChanges();
        GridData = dbSoftdentContext.ExplosionCodes.ToList();
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Softdent2OpenDentalConversion.Pages.ExpCodes
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Double __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowSelection", __arg1);
        __builder.AddAttribute(__seq2, "EnableVirtualization", __arg2);
        __builder.AddAttribute(__seq3, "Height", __arg3);
        __builder.AddAttribute(__seq4, "RowHeight", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
