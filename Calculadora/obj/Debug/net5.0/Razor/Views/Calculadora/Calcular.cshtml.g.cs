#pragma checksum "D:\Users\lonascimento\Desktop\Calculadora\Calculadora\Calculadora\Calculadora\Views\Calculadora\Calcular.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2838e33b2370ca42cc7cbf08401ca1d36c37f6a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculadora_Calcular), @"mvc.1.0.view", @"/Views/Calculadora/Calcular.cshtml")]
namespace AspNetCore
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
#line 1 "D:\Users\lonascimento\Desktop\Calculadora\Calculadora\Calculadora\Calculadora\Views\_ViewImports.cshtml"
using Calculadora;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\lonascimento\Desktop\Calculadora\Calculadora\Calculadora\Calculadora\Views\_ViewImports.cshtml"
using Calculadora.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2838e33b2370ca42cc7cbf08401ca1d36c37f6a0", @"/Views/Calculadora/Calcular.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73bc683a9f979c652064084dbaeab0fe83a2029", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculadora_Calcular : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Calc>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 8 "D:\Users\lonascimento\Desktop\Calculadora\Calculadora\Calculadora\Calculadora\Views\Calculadora\Calcular.cshtml"
     using (Html.BeginForm(FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"no1\">No 1</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"no1\" name=\"no1\"");
            BeginWriteAttribute("value", " value=\"", 234, "\"", 254, 1);
#nullable restore
#line 13 "D:\Users\lonascimento\Desktop\Calculadora\Calculadora\Calculadora\Calculadora\Views\Calculadora\Calcular.cshtml"
WriteAttributeValue("", 242, Model.no1, 242, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"no2\">Numero 2</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"no2\"");
            BeginWriteAttribute("value", " value=\"", 405, "\"", 425, 1);
#nullable restore
#line 18 "D:\Users\lonascimento\Desktop\Calculadora\Calculadora\Calculadora\Calculadora\Views\Calculadora\Calcular.cshtml"
WriteAttributeValue("", 413, Model.no2, 413, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n    <label for=\"tot\">Resultado</label>\r\n    <input type=\"text\" class=\"form-control\" id=\"tot\" name=\"tot\"");
            BeginWriteAttribute("value", " value=\"", 578, "\"", 597, 1);
#nullable restore
#line 23 "D:\Users\lonascimento\Desktop\Calculadora\Calculadora\Calculadora\Calculadora\Views\Calculadora\Calcular.cshtml"
WriteAttributeValue(" ", 586, Model.tot, 587, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-info\" id=\"calc\" value=\"calc\" name=\"c\">+</button> \r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-danger\" id=\"dim\" value=\"dim\" name=\"c\">-</button> \r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-warning\" id=\"mult\" value=\"mult\" name=\"c\">*</button> \r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-light\" id=\"divv\" value=\"divv\" name=\"c\">/</button> \r\n");
#nullable restore
#line 33 "D:\Users\lonascimento\Desktop\Calculadora\Calculadora\Calculadora\Calculadora\Views\Calculadora\Calcular.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Calc> Html { get; private set; }
    }
}
#pragma warning restore 1591
