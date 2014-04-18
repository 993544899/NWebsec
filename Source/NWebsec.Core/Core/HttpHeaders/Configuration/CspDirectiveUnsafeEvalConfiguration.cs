// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

namespace NWebsec.Core.HttpHeaders.Configuration
{
    public class CspDirectiveUnsafeEvalConfiguration : CspDirectiveUnsafeInlineConfiguration, ICspDirectiveUnsafeEvalConfiguration
    {
        public CspDirectiveUnsafeEvalConfiguration()
        {
            Enabled = true;
        }

        public bool UnsafeEvalSrc { get; set; }
    }
}