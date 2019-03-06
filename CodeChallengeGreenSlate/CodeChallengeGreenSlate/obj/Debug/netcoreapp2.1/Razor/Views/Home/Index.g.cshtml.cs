#pragma checksum "C:\Projectos\CodeChallengeGreenSlate\CodeChallengeGreenSlate\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ac8b1fc0fd922a5ed4f49bd3cea1ecc36b09ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ac8b1fc0fd922a5ed4f49bd3cea1ecc36b09ba", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CodeChallengeGreenSlate.Models.Home.Users>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projectos\CodeChallengeGreenSlate\CodeChallengeGreenSlate\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(79, 31, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(110, 723, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86fedbb37ef5469eab5501ac4caebac5", async() => {
                BeginContext(116, 710, true);
                WriteLiteral(@"
    <style>


        .form-control {
            color: #fff;
            font-size: 20px;
            padding: 5px 10px;
            border-radius: 5px;
            background-color: #cc2a41;
            font-weight: bold;
        }


        table {
            border-collapse: collapse;
            width: 100%;
        }

        th, td {
            text-align: left;
            padding: 8px;
        }

        tr:nth-child(even) {
            background-color: #f2f2f2
        }

        th {
            background-color: #4CAF50;
            color: white;
        }
    </style>
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Index</title>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(833, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(835, 1803, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcfdaddaa1c74d59baf83c5438ba1b33", async() => {
                BeginContext(841, 86, true);
                WriteLiteral("\r\n\r\n\r\n    <h2>CodeChallenge - GreenSlate</h2>\r\n    <br /><br />\r\n    <div>\r\n\r\n        ");
                EndContext();
                BeginContext(928, 131, false);
#line 54 "C:\Projectos\CodeChallengeGreenSlate\CodeChallengeGreenSlate\Views\Home\Index.cshtml"
   Write(Html.DropDownListFor(m => m.SelectedUserId, Model.UserList, "--", new { @class = "form-control", @onchange = "GetUserProjects()" }));

#line default
#line hidden
                EndContext();
                BeginContext(1059, 1572, true);
                WriteLiteral(@"
    </div>

    <div>
        <table class=""table table-bordered table-responsive table-hover"" id=""tblProjects"">

            <thead>
                <tr>
                    <th>Project Id </th>
                    <th>Start Date </th>
                    <th>Time To Start </th>
                    <th>End Date</th>
                    <th>Credits</th>
                    <th>Status</th>
                </tr>
            </thead>
            <tbody>
                
            </tbody>
        </table>
    </div>

    <script type=""text/javascript"">

        function GetUserProjects() {

            $(""#tblProjects > tbody"").empty();

            $.getJSON('/Home/GetUserProjects', { userId: $(""#SelectedUserId"").val() }, function (data) {

                var tblProjects = $(""#tblProjects"");
                $.each(data, function (index, item) {
                    var tr = $(""<tr></tr>"");
                    tr.html((""<td>"" + item.projectID + ""</td>"")
                      ");
                WriteLiteral(@"  + "" "" + (""<td>"" + item.startDate + ""</td>"")
                        + "" "" + (""<td>"" + item.timeToStart + ""</td>"")
                        + "" "" + (""<td>"" + item.endDate + ""</td>"")
                        + "" "" + (""<td>"" + item.credits + ""</td>"")
                        + "" "" + (""<td>"" + item.status + ""</td>""));
                    tblProjects.append(tr);
                });

            });
        }
    </script>


    <script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.3.1.js"" type=""text/javascript""></script>



");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2638, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CodeChallengeGreenSlate.Models.Home.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591