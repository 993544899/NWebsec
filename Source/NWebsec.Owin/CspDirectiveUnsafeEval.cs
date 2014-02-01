// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.Core.HttpHeaders.Configuration;

namespace NWebsec.Owin
{
    public class CspDirectiveUnsafeEval : CspDirectiveUnsafeInline, ICspDirectiveUnsafeEval
    {
        public bool UnsafeEvalSrc { get; set; }

    }
}