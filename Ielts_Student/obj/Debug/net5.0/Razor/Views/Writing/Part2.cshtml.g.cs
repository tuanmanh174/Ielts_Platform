#pragma checksum "D:\Ielts\Ielts_Platform\Ielts_Student\Views\Writing\Part2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1569c85efb4fb8a884697833a9d0e6af988fd4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writing_Part2), @"mvc.1.0.view", @"/Views/Writing/Part2.cshtml")]
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
#line 1 "D:\Ielts\Ielts_Platform\Ielts_Student\Views\_ViewImports.cshtml"
using Ielts_Student;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ielts\Ielts_Platform\Ielts_Student\Views\_ViewImports.cshtml"
using Ielts_Student.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1569c85efb4fb8a884697833a9d0e6af988fd4a", @"/Views/Writing/Part2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0146f1f19139a028a43401233ac23484bc9eee94", @"/Views/_ViewImports.cshtml")]
    public class Views_Writing_Part2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataModel.AnswerWriting.AnswerWritingGetDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right: 50px; margin-left:50px; margin-bottom:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right: 50px; margin-left:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Ielts\Ielts_Platform\Ielts_Student\Views\Writing\Part2.cshtml"
  
    ViewData["Title"] = "Part2";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1569c85efb4fb8a884697833a9d0e6af988fd4a4222", async() => {
                WriteLiteral("\r\n    <button onclick=\"rP1()\">Part 1</button>\r\n    <button onclick=\"rP2()\">Part 2</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "D:\Ielts\Ielts_Platform\Ielts_Student\Views\Writing\Part2.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1569c85efb4fb8a884697833a9d0e6af988fd4a5843", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label for=\"exampleFormControlInput1\">Thí sinh</label>\r\n            <input disabled=\"disabled\" type=\"email\" class=\"form-control\" id=\"exampleFormControlInput1\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 601, "\"", 628, 1);
#nullable restore
#line 17 "D:\Ielts\Ielts_Platform\Ielts_Student\Views\Writing\Part2.cshtml"
WriteAttributeValue("", 615, ViewBag.Name, 615, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        </div>

        <div class=""form-group"">
            <label for=""exampleFormControlTextarea1"">Đề bài</label>
            <textarea disabled=""disabled"" class=""form-control"" rows=""3""></textarea>
        </div>
        <div class=""form-group"">
            <label for=""exampleFormControlTextarea1"">Bài làm</label>
            <textarea class=""form-control"" id=""answer1""");
                BeginWriteAttribute("value", " value=\"", 1013, "\"", 1035, 1);
#nullable restore
#line 26 "D:\Ielts\Ielts_Platform\Ielts_Student\Views\Writing\Part2.cshtml"
WriteAttributeValue("", 1021, Model.Answer1, 1021, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rows=\"3\"></textarea>\r\n        </div>\r\n        <button>Edit</button>\r\n        <button onclick=\"Create()\">Save</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "D:\Ielts\Ielts_Platform\Ielts_Student\Views\Writing\Part2.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1569c85efb4fb8a884697833a9d0e6af988fd4a8844", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label for=\"exampleFormControlInput1\">Thí sinh</label>\r\n            <input disabled=\"disabled\" type=\"email\" class=\"form-control\" id=\"exampleFormControlInput1\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1442, "\"", 1469, 1);
#nullable restore
#line 37 "D:\Ielts\Ielts_Platform\Ielts_Student\Views\Writing\Part2.cshtml"
WriteAttributeValue("", 1456, ViewBag.Name, 1456, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        </div>

        <div class=""form-group"">
            <label for=""exampleFormControlTextarea1"">Đề bài</label>
            <textarea disabled=""disabled"" class=""form-control"" rows=""3""></textarea>
        </div>
        <div class=""form-group"">
            <label for=""exampleFormControlTextarea1"">Bài làm</label>
            <textarea class=""form-control"" id=""answer1"" rows=""3""></textarea>
        </div>
        <button>Edit</button>
        <button onclick=""Create()"">Save</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 51 "D:\Ielts\Ielts_Platform\Ielts_Student\Views\Writing\Part2.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script>\r\n    var myJsVariable = \'");
#nullable restore
#line 55 "D:\Ielts\Ielts_Platform\Ielts_Student\Views\Writing\Part2.cshtml"
                   Write(ViewBag.code);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    function rP1() {
        location.href = ""/writing/Part1"" + ""/"" + myJsVariable;
    }

    function rP2() {
        location.href = ""/writing/Part2"" + ""/"" + myJsVariable;
    }


    function Create() {
        var answer2 = $('#answer2').val();
        var request = {
            'Answer2': answer2
        }
        $.ajax({
            type: 'POST',
            url: '/Writing/Create',
            data: {
                request: request
            },
            dataType: ""json"",
            success: function (res) {
                console.log(res)
                alert(""success!"");
            },
            error: function () {
                alert('error!');
            }
        });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataModel.AnswerWriting.AnswerWritingGetDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
