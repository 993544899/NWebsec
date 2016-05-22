// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.AspNetCore.Mvc.HttpHeaders.Csp.Internals;

namespace NWebsec.AspNetCore.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the plugin-types directive for the CSP Report Only header (CSP 2). 
    /// </summary>
    public class CspPluginTypesReportOnlyAttribute : CspPluginTypesAttributeBase
    {
        protected override bool ReportOnly
        {
            get { return true; }
        }
    }
}