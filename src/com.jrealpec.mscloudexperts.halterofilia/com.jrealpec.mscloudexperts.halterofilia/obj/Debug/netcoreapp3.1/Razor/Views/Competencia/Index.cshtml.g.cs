#pragma checksum "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "302a723a947749801446bc725ba702689c779507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(com.jrealpec.mscloudexperts.halterofilia.Views.Competencia.Views_Competencia_Index), @"mvc.1.0.view", @"/Views/Competencia/Index.cshtml")]
namespace com.jrealpec.mscloudexperts.halterofilia.Views.Competencia
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
#line 1 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\_ViewImports.cshtml"
using com.jrealpec.mscloudexperts.halterofilia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\_ViewImports.cshtml"
using com.jrealpec.mscloudexperts.halterofilia.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\_ViewImports.cshtml"
using com.jrealpec.mscloudexperts.halterofilia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"302a723a947749801446bc725ba702689c779507", @"/Views/Competencia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c198fd22c3cd5a63b412b3b5175538a9a27c7e6c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Competencia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<com.jrealpec.mscloudexperts.halterofilia.Models.Competencia>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\Index.cshtml"
  
    ViewData["Title"] = @ViewBag._SiteName;

#line default
#line hidden
#nullable disable
            WriteLiteral("<ol class=\"breadcrumb\">\r\n    <li class=\"active\"><i class=\"fas fa-home fa-fw\"></i>");
#nullable restore
#line 6 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\Index.cshtml"
                                                   Write(Convert.ToString(string.Format("{0:MMMM dd, yyyy}", DateTime.Now.ToUniversalTime().AddHours(-5))));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ol>\r\n<div class=\"col-sm-12\">\r\n    <div class=\"well\">\r\n        <h3>\r\n            Welcome to <strong>");
#nullable restore
#line 11 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\Index.cshtml"
                          Write(ViewBag._SiteName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        </h3>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <h2>\r\n         Listado de Competencia <small>msCloudExperts-Hareltofia</small>\r\n        </h2>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        ");
#nullable restore
#line 22 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\Index.cshtml"
   Write(Html.ActionLink("Add New", "AddEditCompetencia", "Competencia", null, new { @class = "btn btn-primary buttonAdd" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>
 <div class=""row"">
    <div class=""col-sm-12"">
        <div class=""col-sm-9"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <div>
                        <table id=""tblCompetenciaList"" class=""display table table-bordered dataTable table-hover"" cellspacing=""0"">
                            <thead>
                                <tr>
                                    <th>Pais</th>
                                    <th>Deportista</th>
                                    <th>Modalidad</th>
                                    <th>Cantidad</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 42 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 45 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\Index.cshtml"
                                                            Write(item.Nom_Pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 46 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\Index.cshtml"
                                                            Write(item.Nom_Deportista);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 47 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\Index.cshtml"
                                                            Write(item.Nom_Modalidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 48 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\Index.cshtml"
                                                            Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 50 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\Index.cshtml"
                                       Write(Html.ActionLink("Edit", "AddUpdateCompetencia", new { Id = @item.CodCompetencia }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 51 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\Index.cshtml"
                                       Write(Html.ActionLink("Delete", "DeleteCompetencia", new { Id = @item.CodCompetencia }, new { @class = "btn btn-danger", onclick = "return confirm('Are you sure you wish to delete this registry?');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 54 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                <div>
            </div>
        </div>
    </div>
    </div>
</div>
</div>

<style>
    .imageStyle {
        width: 100px;
        height: 100px;
    }

    .buttonAdd {
        float: right;
        margin-top: 20px;
    }
</style>
<link href=""https://cdn.datatables.net/1.10.21/css/jquery.dataTables.min.css"" rel=""stylesheet"" />
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>
    <script>
        $(document).ready(function () {
            $(function () {
                $('#tblCompetenciaList').DataTable({
                    ""paging"": true,
                    ""lengthChange"": true,
                    ""searching"": true,
                    ""ordering"": true,
                    ""info"": true,
                    ""autoWidth"": true,
                });
            });

        });
    </script>
 ");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<com.jrealpec.mscloudexperts.halterofilia.Models.Competencia>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591