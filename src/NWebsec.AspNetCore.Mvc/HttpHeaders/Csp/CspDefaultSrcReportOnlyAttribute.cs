// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

namespace NWebsec.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the default-src directive for the CSP Report Only header (CSP 1.0). 
    /// </summary>
    public class CspDefaultSrcReportOnlyAttribute : CspDefaultSrcAttribute
    {
        protected override bool ReportOnly
        {
            get { return true; }
        }
    }
}