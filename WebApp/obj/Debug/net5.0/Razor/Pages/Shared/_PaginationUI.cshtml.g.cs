#pragma checksum "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a68a9543e3d1c28f6b3b4483b6f48930164b29d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Shared.Pages_Shared__PaginationUI), @"mvc.1.0.view", @"/Pages/Shared/_PaginationUI.cshtml")]
namespace WebApp.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a68a9543e3d1c28f6b3b4483b6f48930164b29d8", @"/Pages/Shared/_PaginationUI.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54a580a236bf4511f2b8e02a6219a9844921dafb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__PaginationUI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.UIPaginationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"float-left\">\r\n");
#nullable restore
#line 6 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
     if (Model.GetTotalItems > 0)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral(" Mostrando registros del ");
#nullable restore
#line 8 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
                                   Write(Model.GetStartIndex + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" al ");
#nullable restore
#line 8 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
                                                                 Write(Model.GetEndIndex + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" de un total de ");
#nullable restore
#line 8 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
                                                                                                        Write(Model.GetTotalItems);

#line default
#line hidden
#nullable disable
            WriteLiteral(" registros ");
#nullable restore
#line 8 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
                                                                                                                                                   
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral(" Mostrando registros del 0 al 0 de un total de 0 registros");
#nullable restore
#line 12 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
                                                                               
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<ul class=\"pagination pagination-md m-0 float-right\">\r\n");
#nullable restore
#line 16 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
     if (Model.GetTotalItems > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
         if (Model.GetPreviousPage > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link\" data-page=\"");
#nullable restore
#line 20 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
                                                             Write(Model.GetPreviousPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fas fa-angle-double-left\"></i></a></li>\r\n");
#nullable restore
#line 21 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
         foreach (var item in Model.GetPages)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
             if (item == Model.GetCurrentPage)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\"><a class=\"page-link\" data-page=\"");
#nullable restore
#line 27 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
                                                                        Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 27 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
                                                                               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 28 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\" data-page=\"");
#nullable restore
#line 31 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
                                                                 Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 31 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
                                                                        Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 32 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
             

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
         if (Model.GetNextPage <= Model.GetTotalPages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link\" data-page=\"");
#nullable restore
#line 38 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
                                                             Write(Model.GetNextPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fas fa-angle-double-right\"></i></a></li>\r\n");
#nullable restore
#line 39 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Gerson Arlindo\Desktop\Proyecto_Veterinaria_PDWA\CleanArchitectureTemplate\WebApp\Pages\Shared\_PaginationUI.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.UIPaginationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
