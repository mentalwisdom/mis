#pragma checksum "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "798362871d828145c950d34e46b71cf704e9ac31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_List), @"mvc.1.0.view", @"/Templates/ViewGenerator/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Templates/ViewGenerator/List.cshtml", typeof(AspNetCore.Templates_ViewGenerator_List))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#line 3 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#line 4 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
using System.Linq;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"798362871d828145c950d34e46b71cf704e9ac31", @"/Templates/ViewGenerator/List.cshtml")]
    public class Templates_ViewGenerator_List : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(208, 7, true);
            WriteLiteral("@model ");
            EndContext();
            BeginContext(216, 51, false);
#line 5 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
   Write(GetEnumerableTypeExpression(Model.ViewDataTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(267, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
  
    if (Model.IsPartialView)
    {
    }
    else if (Model.IsLayoutPageSelected)
    {

#line default
#line hidden
            BeginContext(371, 8, true);
            WriteLiteral("@{\r\n    ");
            EndContext();
            BeginContext(381, 21, true);
            WriteLiteral("ViewData[\"Title\"] = \"");
            EndContext();
            BeginContext(403, 14, false);
#line 14 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
                      Write(Model.ViewName);

#line default
#line hidden
            EndContext();
            BeginContext(417, 4, true);
            WriteLiteral("\";\r\n");
            EndContext();
#line 15 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
            BeginContext(490, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(496, 10, true);
            WriteLiteral("Layout = \"");
            EndContext();
            BeginContext(507, 20, false);
#line 17 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
           Write(Model.LayoutPageFile);

#line default
#line hidden
            EndContext();
            BeginContext(527, 4, true);
            WriteLiteral("\";\r\n");
            EndContext();
#line 18 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
        }

#line default
#line hidden
            BeginContext(544, 3, true);
            WriteLiteral("}\r\n");
            EndContext();
            BeginContext(549, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(553, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(558, 14, false);
#line 21 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
 Write(Model.ViewName);

#line default
#line hidden
            EndContext();
            BeginContext(572, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(581, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
    }
    else
    {


    }

#line default
#line hidden
            BeginContext(621, 19, true);
            WriteLiteral("@{ int count =0;}\r\n");
            EndContext();
            BeginContext(642, 35, true);
            WriteLiteral("<nav aria-label=\"breadcrumb\">\r\n    ");
            EndContext();
            BeginContext(679, 50, true);
            WriteLiteral("<ol class=\"breadcrumb breadcrumb-arrow\">\r\n        ");
            EndContext();
            BeginContext(731, 55, true);
            WriteLiteral("<li class=\"breadcrumb-item active\" aria-current=\"page\">");
            EndContext();
            BeginContext(787, 49, false);
#line 32 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
                                                            Write(GetValueNoUnderScore(Model.ViewDataTypeShortName));

#line default
#line hidden
            EndContext();
            BeginContext(836, 11, true);
            WriteLiteral("</li>\r\n    ");
            EndContext();
            BeginContext(849, 7, true);
            WriteLiteral("</ol>\r\n");
            EndContext();
            BeginContext(858, 8, true);
            WriteLiteral("</nav>\r\n");
            EndContext();
            BeginContext(868, 140, true);
            WriteLiteral("<hr>    \r\n<a asp-action=\"Create\" class=\"btn button btn-outline-success\">\r\n    <i class=\"fa fa-plus\"></i>\r\n        Create\r\n</a>\r\n<br>\r\n<br>\r\n");
            EndContext();
            BeginContext(1010, 27, true);
            WriteLiteral("<table class=\"table\">\r\n    ");
            EndContext();
            BeginContext(1039, 17, true);
            WriteLiteral("<thead>\r\n        ");
            EndContext();
            BeginContext(1058, 6, true);
            WriteLiteral("<tr>\r\n");
            EndContext();
#line 45 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
        Dictionary<string, IPropertyMetadata> propertyLookup = ((IModelMetadata)Model.ModelMetadata).Properties.ToDictionary(x => x.PropertyName, x => x);
        Dictionary<string, INavigationMetadata> navigationLookup = ((IModelMetadata)Model.ModelMetadata).Navigations.ToDictionary(x => x.AssociationPropertyName, x => x);

        foreach (var item in Model.ModelMetadata.ModelType.GetProperties())
        {
            if (propertyLookup.TryGetValue(item.Name, out IPropertyMetadata property)
                && property.Scaffold && !property.IsForeignKey && !property.IsPrimaryKey)
            {

#line default
#line hidden
            BeginContext(1675, 52, true);
            WriteLiteral("            <th>\r\n                \r\n                ");
            EndContext();
            BeginContext(1728, 40, false);
#line 55 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
           Write(GetValueExpressionNoUnderScore(property));

#line default
#line hidden
            EndContext();
            BeginContext(1768, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
#line 57 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
            }
            else if (navigationLookup.TryGetValue(item.Name, out INavigationMetadata navigation))
            {

#line default
#line hidden
            BeginContext(1918, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(1953, 30, false);
#line 61 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
           Write(GetValueExpression(navigation));

#line default
#line hidden
            EndContext();
            BeginContext(1983, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
#line 63 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(2030, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2044, 19, true);
            WriteLiteral("<th></th>\r\n        ");
            EndContext();
            BeginContext(2065, 11, true);
            WriteLiteral("</tr>\r\n    ");
            EndContext();
            BeginContext(2078, 14, true);
            WriteLiteral("</thead>\r\n    ");
            EndContext();
            BeginContext(2094, 9, true);
            WriteLiteral("<tbody>\r\n");
            EndContext();
            BeginContext(2106, 40, true);
            WriteLiteral("@foreach (var item in Model) {\r\n        ");
            EndContext();
            BeginContext(2148, 6, true);
            WriteLiteral("<tr>\r\n");
            EndContext();
#line 71 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
        foreach (var item in Model.ModelMetadata.ModelType.GetProperties())
        {
            if (propertyLookup.TryGetValue(item.Name, out IPropertyMetadata property)
                && property.Scaffold && !property.IsForeignKey && !property.IsPrimaryKey)
            {

#line default
#line hidden
            BeginContext(2435, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(2470, 6, true);
            WriteLiteral("@item.");
            EndContext();
            BeginContext(2477, 28, false);
#line 77 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
                  Write(GetValueExpression(property));

#line default
#line hidden
            EndContext();
            BeginContext(2505, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 79 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
            }
            else if (navigationLookup.TryGetValue(item.Name, out INavigationMetadata navigation))
            {

#line default
#line hidden
            BeginContext(2655, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(2690, 35, true);
            WriteLiteral("@Html.DisplayFor(modelItem => item.");
            EndContext();
            BeginContext(2726, 30, false);
#line 83 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
                                               Write(GetValueExpression(navigation));

#line default
#line hidden
            EndContext();
            BeginContext(2756, 1, true);
            WriteLiteral(".");
            EndContext();
            BeginContext(2758, 30, false);
#line 83 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
                                                                               Write(navigation.DisplayPropertyName);

#line default
#line hidden
            EndContext();
            BeginContext(2788, 22, true);
            WriteLiteral(")\r\n            </td>\r\n");
            EndContext();
#line 85 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
            }
        }
        string pkName = GetPrimaryKeyName();
        if (pkName != null)
        {

#line default
#line hidden
            BeginContext(2922, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2936, 22, true);
            WriteLiteral("<td>\r\n                ");
            EndContext();
            BeginContext(2960, 35, true);
            WriteLiteral("<a asp-action=\"Edit\" asp-route-id=\"");
            EndContext();
            BeginContext(2996, 6, true);
            WriteLiteral("@item.");
            EndContext();
            BeginContext(3003, 6, false);
#line 91 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
                                                       Write(pkName);

#line default
#line hidden
            EndContext();
            BeginContext(3009, 30, true);
            WriteLiteral("\">Edit</a> |\r\n                ");
            EndContext();
            BeginContext(3041, 38, true);
            WriteLiteral("<a asp-action=\"Details\" asp-route-id=\"");
            EndContext();
            BeginContext(3080, 6, true);
            WriteLiteral("@item.");
            EndContext();
            BeginContext(3087, 6, false);
#line 92 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
                                                          Write(pkName);

#line default
#line hidden
            EndContext();
            BeginContext(3093, 33, true);
            WriteLiteral("\">Details</a> |\r\n                ");
            EndContext();
            BeginContext(3128, 37, true);
            WriteLiteral("<a asp-action=\"Delete\" asp-route-id=\"");
            EndContext();
            BeginContext(3166, 6, true);
            WriteLiteral("@item.");
            EndContext();
            BeginContext(3173, 6, false);
#line 93 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
                                                         Write(pkName);

#line default
#line hidden
            EndContext();
            BeginContext(3179, 26, true);
            WriteLiteral("\">Delete</a>\r\n            ");
            EndContext();
            BeginContext(3207, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 95 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(3250, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(3285, 86, true);
            WriteLiteral("@Html.ActionLink(\"Edit\", \"Edit\", new { /* id=item.PrimaryKey */ }) |\r\n                ");
            EndContext();
            BeginContext(3372, 92, true);
            WriteLiteral("@Html.ActionLink(\"Details\", \"Details\", new { /* id=item.PrimaryKey */ }) |\r\n                ");
            EndContext();
            BeginContext(3465, 91, true);
            WriteLiteral("@Html.ActionLink(\"Delete\", \"Delete\", new { /* id=item.PrimaryKey */ })\r\n            </td>\r\n");
            EndContext();
#line 103 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
        }

#line default
#line hidden
            BeginContext(3567, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(3577, 7, true);
            WriteLiteral("</tr>\r\n");
            EndContext();
            BeginContext(3586, 7, true);
            WriteLiteral("}\r\n    ");
            EndContext();
            BeginContext(3595, 10, true);
            WriteLiteral("</tbody>\r\n");
            EndContext();
            BeginContext(3609, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
#line 109 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
    if(!Model.IsPartialView && !Model.IsLayoutPageSelected)
    {
        //ClearIndent();

    }

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 116 "/Users/mac/Desktop/backup/soft/mis/Templates/ViewGenerator/List.cshtml"
 
    string GetPrimaryKeyName()
    {
        return (Model.ModelMetadata.PrimaryKeys != null && Model.ModelMetadata.PrimaryKeys.Length == 1)
        ? Model.ModelMetadata.PrimaryKeys[0].PropertyName
        : null;
    }

    string GetValueExpression(IPropertyMetadata property)
    {
        return property.PropertyName;
    }
    string GetValueExpressionNoUnderScore(IPropertyMetadata property)
    {
        return property.PropertyName.Replace("_"," ");
    }
    string GetValueNoUnderScore(string data)
    {
        return data.Replace("_"," ");
    }

    string GetValueExpression(INavigationMetadata navigation)
    {
        return navigation.AssociationPropertyName;
    }

    string GetEnumerableTypeExpression(string typeName)
    {
        return "IEnumerable<" + typeName + ">";
    }
    

#line default
#line hidden
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
