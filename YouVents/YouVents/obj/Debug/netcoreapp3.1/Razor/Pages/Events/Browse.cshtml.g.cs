#pragma checksum "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c94c5f7cebdaae1cf8a1979268bc56685f3b09d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(YouVents.Pages.Events.Pages_Events_Browse), @"mvc.1.0.razor-page", @"/Pages/Events/Browse.cshtml")]
namespace YouVents.Pages.Events
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
#line 1 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\_ViewImports.cshtml"
using YouVents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c94c5f7cebdaae1cf8a1979268bc56685f3b09d", @"/Pages/Events/Browse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d3c815e3f3834fa666ff55c3c6fa3aeb617689", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Events_Browse : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("CitySearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("City"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/event.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Events/View", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
  
    ViewData["Title"] = "Browse";
    var Culture = new System.Globalization.CultureInfo("en-US");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>

<div class=""container"" style=""min-height: 55vh; border-style: solid; border-color: grey; border-width: 1px; border-radius: 5px;"">
    <div class=""row"">
        <div class=""col-12 text-center"">
            <h2 class=""my-3"">Upcoming Events:</h2>


            <!-- testing filtering-->
            <div class=""container row"">
                <div class=""col-1""></div>
                <div class=""col-10 row"">
                    <div class=""col-12"">
                        <input class=""form-control"" id=""EventSearch"" type=""text"" placeholder=""Search events..."" />
                        <div class=""row text-left my-3"">
                            <div class=""col-2"" style=""font-size:1.5em;"">Filter By:</div>

                            <div class=""col-3"">
                                <input id=""DateSearch"" type=""date"" placeholder=""date"" class=""form-control"" />
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c94c5f7cebdaae1cf8a1979268bc56685f3b09d7353", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 26 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.Date);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>

                            <div class=""col-2"">
                                <div class=""input-group w-100"">
                                    <div class=""input-group-prepend"">
                                        <span class=""input-group-text"">$</span>
                                    </div>
                                    <input id=""PriceSearch"" type=""text"" placeholder=""Price"" class=""form-control"">
                                </div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c94c5f7cebdaae1cf8a1979268bc56685f3b09d9592", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 36 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.Price);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"col-3\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c94c5f7cebdaae1cf8a1979268bc56685f3b09d11409", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 40 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.City);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c94c5f7cebdaae1cf8a1979268bc56685f3b09d13429", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 41 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.City);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>

                            <div>
                                <button class=""btn btn-success"" id=""FilterBtn"" type=""submit"">Apply Filter</button>
                            </div>

                        </div>
                    </div>
");
            WriteLiteral("                </div>\r\n                <div class=\"col-1\"></div>\r\n            </div>\r\n\r\n            <!--end of filtering-->\r\n\r\n            <div id=\"EventList\" class=\"mt-4\">\r\n                <!-- Loop through all of the events and display them -->\r\n");
#nullable restore
#line 63 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
                 foreach (var E in Model.Events) {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c94c5f7cebdaae1cf8a1979268bc56685f3b09d16076", async() => {
                WriteLiteral("\r\n                        \r\n                        <div class=\"row\">\r\n \r\n                            <!-- if (document.getElementByID(\"CitySearch\").value == ");
#nullable restore
#line 69 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
                                                                               Write(E.City);

#line default
#line hidden
#nullable disable
                WriteLiteral("){        Not sure how to get this to work yet--> \r\n\r\n                            <div class=\"col text-right\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c94c5f7cebdaae1cf8a1979268bc56685f3b09d17038", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col text-left\">\r\n                                <p class=\"m-0\"><strong>");
#nullable restore
#line 75 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
                                                  Write(E.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></p>\r\n                                <p class=\"text-black-50 m-0\" id=\"Date\">Date: ");
#nullable restore
#line 76 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
                                                                        Write(Convert.ToDateTime(E.Date).ToString("ddd, dd MMM yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"text-black-50 m-0\" id=\"Time\">Time: ");
#nullable restore
#line 77 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
                                                                        Write(Convert.ToDateTime(E.Time).ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"text-black-50 m-0\" id=\"Price\">Price: ");
#nullable restore
#line 78 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
                                                                          Write(E.Price.ToString("C", Culture));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"text-black-50 m-0\" id=\"Location\">Location: ");
#nullable restore
#line 79 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
                                                                                Write(E.City);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 79 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
                                                                                         Write(E.State);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
                                                 WriteLiteral(E.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 83 "D:\Lessons\Kutztown\OneDrive - Kutztown University\0This Semester\CSC355_Software_Engineeting_II\YouVents-main\GitYouVents\YouVents\YouVents\YouVents\Pages\Events\Browse.cshtml"
                          
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <!-- Testing EventsQuery-->\r\n\r\n            \r\n\r\n            <!-- end of EventsQuery Testing-->\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YouVents.Pages.Events.BrowseModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<YouVents.Pages.Events.BrowseModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<YouVents.Pages.Events.BrowseModel>)PageContext?.ViewData;
        public YouVents.Pages.Events.BrowseModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
