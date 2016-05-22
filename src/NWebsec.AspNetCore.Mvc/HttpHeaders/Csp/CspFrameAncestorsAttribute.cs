﻿// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.AspNetCore.Mvc.Helpers;
using NWebsec.AspNetCore.Mvc.HttpHeaders.Csp.Internals;

namespace NWebsec.AspNetCore.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the frame-ancestors directive for the CSP header (CSP 2). 
    /// </summary>
    public class CspFrameAncestorsAttribute : CspDirectiveAttributeBase
    {
        protected override CspDirectives Directive
        {
            get { return CspDirectives.FrameAncestors; }
        }

        protected override bool ReportOnly
        {
            get { return false; }
        }
    }
}