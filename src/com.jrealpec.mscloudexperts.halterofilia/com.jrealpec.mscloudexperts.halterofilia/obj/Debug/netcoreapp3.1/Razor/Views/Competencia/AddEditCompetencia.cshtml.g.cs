#pragma checksum "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19f2b38e9cf03efef0a3e299414ef8d3beb3639b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(com.jrealpec.mscloudexperts.halterofilia.Views.Competencia.Views_Competencia_AddEditCompetencia), @"mvc.1.0.view", @"/Views/Competencia/AddEditCompetencia.cshtml")]
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
#line 3 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\_ViewImports.cshtml"
using com.jrealpec.mscloudexperts.halterofilia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
using com.jrealpec.mscloudexperts.halterofilia.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19f2b38e9cf03efef0a3e299414ef8d3beb3639b", @"/Views/Competencia/AddEditCompetencia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c198fd22c3cd5a63b412b3b5175538a9a27c7e6c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Competencia_AddEditCompetencia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<com.jrealpec.mscloudexperts.halterofilia.Models.Competencia>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 15px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
  
   ViewData["Title"] = "AddUpdateCompetencia";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n\r\n<div class=\"card-header\" style=\"font-size: large;margin-top: 9px;\">\r\n    <i class=\"fa fa-align-justify\"></i>\r\n");
#nullable restore
#line 10 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
     if (Model.CodCompetencia > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>Update Competencia</span>\r\n");
#nullable restore
#line 13 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>Add Competencia</span>\r\n");
#nullable restore
#line 17 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 19 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
 using (Html.BeginForm("AddEditCompetencia", "Competencia", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 24 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 25 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
   Write(Html.HiddenFor(Model => Model.CodCompetencia, new { @id = "CodCompetencia" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
       Write(Html.LabelFor(model => model.Etapa, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-4\">\r\n                Etapa 1:\r\n                ");
#nullable restore
#line 30 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
           Write(Html.RadioButtonFor(m => m.Etapa, 1, new { @id = "Etapa", htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Etapa 2:\r\n                ");
#nullable restore
#line 32 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
           Write(Html.RadioButtonFor(m => m.Etapa, 2, new { @id = "Etapa", htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Etapa 3:\r\n                ");
#nullable restore
#line 34 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
           Write(Html.RadioButtonFor(m => m.Etapa, 3, new { @id = "Etapa", htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19f2b38e9cf03efef0a3e299414ef8d3beb3639b9916", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 38 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Etapa);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n         <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Pais: </label>\r\n            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 43 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
           Write(Html.DropDownListFor(m => m.CodPais, ViewBag.PaisList as SelectList,"--Seleccione Pais--",
             new { @id = "CodPais", @class = "form-control", @placeholder = "Select Pais" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 45 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
           Write(Html.ValidationMessageFor(m => m.CodPais, null, new { @class = "text-danger error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Modalidad: </label>\r\n            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 51 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
           Write(Html.DropDownListFor(m => m.CodModalidad, ViewBag.ModalidadList as SelectList,"--Seleccione Modalidad--",
             new { @id = "CodModalidad", @class = "form-control", @placeholder = "Select Modalidad" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 53 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
           Write(Html.ValidationMessageFor(m => m.CodModalidad, null, new { @class = "text-danger error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n         <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Deportista: </label>\r\n            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 59 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
           Write(Html.DropDownListFor(m => m.CodDeportista, ViewBag.DeportistaList as SelectList,"--Seleccione Deportista--",
             new { @id = "CodDeportista", @class = "form-control", @placeholder = "Select Deportista" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 61 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
           Write(Html.ValidationMessageFor(m => m.CodDeportista, null, new { @class = "text-danger error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 65 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
       Write(Html.LabelFor(model => model.Cantidad, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 67 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
           Write(Html.EditorFor(model => model.Cantidad, new { @id = "Cantidad", htmlAttributes = new { @class = "form-control", @placeholder = "Cantidad" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 68 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
           Write(Html.ValidationMessageFor(model => model.Cantidad, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <div class=\"col-md-4\">\r\n");
#nullable restore
#line 75 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
             if (Model.CodCompetencia == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" value=\"Save\" class=\"btn btn-success btn-default\">\r\n");
#nullable restore
#line 78 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" value=\"Update\" class=\"btn btn-success btn-default\" id=\"submit\">\r\n");
#nullable restore
#line 82 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 84 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
       Write(Html.ActionLink("Back", "Index", "Competencia", null, new { @class = "btn btn-default" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 88 "F:\PRGINST\jrealpec\otros\Downloads\wscloudExperts\repos\src\com.jrealpec.mscloudexperts.halterofilia\com.jrealpec.mscloudexperts.halterofilia\Views\Competencia\AddEditCompetencia.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"">
    <script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
    <script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>
    <script>
        $(function () {
            $(""#datepicker"").datepicker();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<com.jrealpec.mscloudexperts.halterofilia.Models.Competencia> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
