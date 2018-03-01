// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.Mvc.Common.Helpers;
using NWebsec.Mvc.HttpHeaders.Csp.Internals;

namespace NWebsec.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the base-uri directive for the CSP header (CSP 2). 
    /// </summary>
    public class CspBaseUriAttribute : CspDirectiveAttributeBase
    {
        protected override CspDirectives Directive
        {
            get { return CspDirectives.BaseUri; }
        }

        protected override bool ReportOnly
        {
            get { return false; }
        }
    }
}