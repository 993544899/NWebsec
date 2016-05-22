// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.AspNetCore.Mvc.Helpers;
using NWebsec.AspNetCore.Mvc.HttpHeaders.Csp.Internals;

namespace NWebsec.AspNetCore.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the child-src directive for the CSP header (CSP 2). 
    /// </summary>
    public class CspChildSrcAttribute : CspDirectiveAttributeBase
    {
        protected override CspDirectives Directive
        {
            get { return CspDirectives.ChildSrc; }
        }

        protected override bool ReportOnly
        {
            get { return false; }
        }
    }
}