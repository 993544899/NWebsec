﻿// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

namespace NWebsec.Core.Common.HttpHeaders.Configuration
{
    public interface ICspConfiguration
    {
        bool Enabled { get; set; }
        ICspDirectiveConfiguration DefaultSrcDirective { get; set; }
        ICspDirectiveConfiguration ScriptSrcDirective { get; set; }
        ICspDirectiveConfiguration ObjectSrcDirective { get; set; }
        ICspDirectiveConfiguration StyleSrcDirective { get; set; }
        ICspDirectiveConfiguration ImgSrcDirective { get; set; }
        ICspDirectiveConfiguration MediaSrcDirective { get; set; }
        ICspDirectiveConfiguration FrameSrcDirective { get; set; }
        ICspDirectiveConfiguration FontSrcDirective { get; set; }
        ICspDirectiveConfiguration ConnectSrcDirective { get; set; }
        ICspReportUriDirectiveConfiguration ReportUriDirective { get; set; }

        //CSP 2
        ICspDirectiveConfiguration BaseUriDirective { get; set; }
        ICspDirectiveConfiguration ChildSrcDirective { get; set; }
        ICspDirectiveConfiguration FormActionDirective { get; set; }
        ICspDirectiveConfiguration FrameAncestorsDirective { get; set; }
        ICspPluginTypesDirectiveConfiguration PluginTypesDirective { get; set; }
        ICspSandboxDirectiveConfiguration SandboxDirective { get; set; }

        //CSP 3
        ICspDirectiveConfiguration ManifestSrcDirective { get; set; }
        ICspDirectiveConfiguration WorkerSrcDirective { get; set; }

        //Upgrade insecure requests
        ICspUpgradeDirectiveConfiguration UpgradeInsecureRequestsDirective { get; set; }

        //Mixed Content
        ICspMixedContentDirectiveConfiguration MixedContentDirective { get; set; }
    }
}