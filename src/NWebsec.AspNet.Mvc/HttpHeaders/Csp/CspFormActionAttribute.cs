// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.Mvc.Common.Helpers;
using NWebsec.Mvc.HttpHeaders.Csp.Internals;

namespace NWebsec.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the form-action directive for the CSP header (CSP 2). 
    /// </summary>
    public class CspFormActionAttribute : CspDirectiveAttributeBase
    {
        protected override CspDirectives Directive => CspDirectives.FormAction;

        protected override bool ReportOnly => false;
    }
}