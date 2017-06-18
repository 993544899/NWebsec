// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

namespace NWebsec.Core.Common.HttpHeaders
{
    public enum ReferrerPolicy
    {
        Disabled,
        NoReferrer,
        NoReferrerWhenDowngrade,
        SameOrigin,
        Origin,
        StrictOrigin,
        OriginWhenCrossOrigin,
        StrictOriginWhenCrossOrigin,
        UnsafeUrl
    }
}