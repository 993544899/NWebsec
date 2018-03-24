// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

namespace NWebsec.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the worker-src directive for the CSP Report Only header (CSP 3). 
    /// </summary>
    public class CspWorkerSrcReportOnlyAttribute : CspWorkerSrcAttribute
    {
        protected override bool ReportOnly => true;
    }
}