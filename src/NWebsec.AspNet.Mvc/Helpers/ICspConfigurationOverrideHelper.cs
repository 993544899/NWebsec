// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using System.Web;
using NWebsec.Core.Common.HttpHeaders.Configuration;

namespace NWebsec.Mvc.Helpers
{
    public interface ICspConfigurationOverrideHelper
    {
        ICspConfiguration GetCspConfigWithOverrides(HttpContextBase context, bool reportOnly);
    }
}