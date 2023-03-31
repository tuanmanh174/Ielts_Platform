#pragma checksum "D:\Ielts\Ielts_Platform\Ielts_Admin\Views\Student\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f85b947994f62198c4d747ee5ab1d123de23176c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Create), @"mvc.1.0.view", @"/Views/Student/Create.cshtml")]
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
#line 1 "D:\Ielts\Ielts_Platform\Ielts_Admin\Views\_ViewImports.cshtml"
using Ielts_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ielts\Ielts_Platform\Ielts_Admin\Views\_ViewImports.cshtml"
using Ielts_Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f85b947994f62198c4d747ee5ab1d123de23176c", @"/Views/Student/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a341d81c74726240d3ee9b42924a8403ab2f37a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Ielts\Ielts_Platform\Ielts_Admin\Views\Student\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid pt-4 px-4\">\r\n    <div class=\"row g-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f85b947994f62198c4d747ee5ab1d123de23176c3532", async() => {
                WriteLiteral(@"
            <div class=""col-sm-12 col-xl-6"">
                <div class=""bg-secondary rounded h-100 p-4"">
                    <h6 class=""mb-4"">Thêm Mới Học Viên</h6>
                    <div class=""form-floating mb-3"">
                        <input type=""text"" id=""name"" class=""form-control"">
                        <label>Tên Học Viên</label>
                        <span class=""text-danger""></span>
                    </div>

                    <div class=""form-floating mb-3"">
                        <input type=""text"" id=""code"" class=""form-control"">
                        <label>Mã Học Viên</label>
                        <span class=""text-danger""></span>
                    </div>

                    <div class=""form-floating mb-3"">
                        <input type=""text"" id=""password"" class=""form-control"">
                        <label>Mật Khẩu</label>
                        <span class=""text-danger""></span>
                    </div>

                    <div class=""form-f");
                WriteLiteral(@"loating mb-3"">
                        <input type=""text"" id=""passwordagain"" class=""form-control"">
                        <label>Nhập Lại Mật Khẩu</label>
                        <span class=""text-danger""></span>
                    </div>

                    <div class=""form-floating mb-3"">
                        <input type=""text"" id=""phone"" class=""form-control"">
                        <label>Số Điện Thoại</label>
                        <span class=""text-danger""></span>
                    </div>

                    <div class=""form-floating mb-3"">
                        <input type=""text"" id=""email"" class=""form-control"">
                        <label>Email</label>
                        <span class=""text-danger""></span>
                    </div>
                    <div class=""form-floating mb-3"">
                        <input type=""text"" id=""lop"" class=""form-control"">
                        <label>Lớp</label>
                        <span class=""text-danger""></span>
      ");
                WriteLiteral(@"              </div>


                    <div class=""form-floating mb-3"">
                        <input type=""submit"" onclick=""CreateStudent()"" value=""Create"" class=""btn btn-primary"" />
                    </div>
                </div>
            </div>

        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    </div>
</div>

<script>
    function CreateStudent() {
        var studentName = $('#name').val();
        var studentCode = $('#code').val();
        var password = $('#password').val();
        var passwordagain = $('#passwordagain').val();
        var phone = $('#phone').val();
        var email = $('#email').val();
        var lop = $('#lop').val();
        if (password != passwordagain) {
            alert(""Mật khẩu không giống nhau"");
            return;
        }
        var request = {
            'UPDATED_BY': """",
            'STUDENT_NAME': studentName,
            'STUDENT_CODE': studentCode,
            'TEL': phone,
            'EMAIL': email,
            'CLASS': lop,
            'PASSWORD': password
        }
        $.ajax({
            type: 'POST',
            url: '/Student/Register',
            data: {
                request: request
            },
            dataType: ""json"",
            success: function (res) {
                console.log(res)");
            WriteLiteral("\r\n                alert(\"success!\");\r\n            },\r\n            error: function () {\r\n                alert(\'error!\');\r\n            }\r\n        });\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591