#pragma checksum "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\User\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c88fe3a1052ba131944521b1cd20f1d3834b55f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserList), @"mvc.1.0.view", @"/Views/User/UserList.cshtml")]
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
#line 1 "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\_ViewImports.cshtml"
using UMSS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\User\UserList.cshtml"
using UMSS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\User\UserList.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c88fe3a1052ba131944521b1cd20f1d3834b55f", @"/Views/User/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb7760867aca84622965c165bf7020a9a88ab11c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UMSS.Models.UserRolesViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\User\UserList.cshtml"
  
    ViewData["Title"] = "UserList";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>UserList</h1>

<table class=""table table-striped card-columns"">
    <thead>
        <tr>
            <th>
                Profile Picture
            </th>
            <th>User Name</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>EMployeeId</th>
            <th>Phone Number</th>
            <th>Delete User</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\User\UserList.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n\r\n                    <img style=\"width:40px;height:40px; object-fit:cover; border-radius:30px\"");
            BeginWriteAttribute("src", " src=\"", 838, "\"", 910, 2);
            WriteAttributeValue("", 844, "data:image/*;base64,", 844, 20, true);
#nullable restore
#line 32 "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\User\UserList.cshtml"
WriteAttributeValue("", 864, Convert.ToBase64String(user.ProfilePicture), 864, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\User\UserList.cshtml"
               Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\User\UserList.cshtml"
               Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\User\UserList.cshtml"
               Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\User\UserList.cshtml"
               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\User\UserList.cshtml"
               Write(user.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\User\UserList.cshtml"
               Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             \r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Brook\Source\Repos\User-Managment-System-\UMSS\Views\User\UserList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<UMSS.Areas.Identity.Data.UMSSUser> UserManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UMSS.Models.UserRolesViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591