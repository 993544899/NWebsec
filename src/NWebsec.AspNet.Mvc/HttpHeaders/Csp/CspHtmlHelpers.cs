﻿// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

using System.Web;
using System.Web.Mvc;
using NWebsec.Core.Common.HttpHeaders.Configuration.Validation;
using NWebsec.Csp;
using NWebsec.Mvc.Common.Csp;
using NWebsec.Mvc.Common.Helpers;
using HttpContextWrapper = NWebsec.Core.Web.HttpContextWrapper;

namespace NWebsec.Mvc.HttpHeaders.Csp
{
    public static class CspHtmlHelpers
    {
        /// <summary>
        /// Generates a CSP nonce HTML attribute. The 120-bit random nonce will be included in the CSP script-src directive.
        /// </summary>
        /// <param name="helper"></param>
        public static IHtmlString CspScriptNonce(this HtmlHelper helper)
        {
            var context = new HttpContextWrapper(helper.ViewContext.HttpContext);
            var cspConfigurationOverrideHelper = new CspConfigurationOverrideHelper();
            var headerOverrideHelper = new HeaderOverrideHelper(new CspReportHelper());

            var nonce = cspConfigurationOverrideHelper.GetCspScriptNonce(context);

            if (context.GetItem<string>("NWebsecScriptNonceSet") == null)
            {
                context.SetItem("NWebsecScriptNonceSet", "set");
                headerOverrideHelper.SetCspHeaders(context, false);
                headerOverrideHelper.SetCspHeaders(context, true);
            }

            return CreateNonceAttribute(helper, nonce);
        }

        /// <summary>
        /// Generates a CSP nonce HTML attribute. The 120-bit random nonce will be included in the CSP style-src directive.
        /// </summary>
        /// <param name="helper"></param>
        public static IHtmlString CspStyleNonce(this HtmlHelper helper)
        {
            var context = new HttpContextWrapper(helper.ViewContext.HttpContext);
            var cspConfigurationOverrideHelper = new CspConfigurationOverrideHelper();
            var headerOverrideHelper = new HeaderOverrideHelper(new CspReportHelper());

            var nonce = cspConfigurationOverrideHelper.GetCspStyleNonce(context);

            if (context.GetItem<string>("NWebsecStyleNonceSet") == null)
            {
                context.SetItem("NWebsecStyleNonceSet", "set");
                headerOverrideHelper.SetCspHeaders(context, false);
                headerOverrideHelper.SetCspHeaders(context, true);
            }

            return CreateNonceAttribute(helper, nonce);
        }

        /// <summary>
        /// Generates a media type attribute suitable for an &lt;object&gt; or &lt;embed&gt; tag. The media type will be included in the CSP plugin-types directive.
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="mediaType">The media type.</param>
        public static IHtmlString CspMediaType(this HtmlHelper helper, string mediaType)
        {
            new Rfc2045MediaTypeValidator().Validate(mediaType);

            var context = new HttpContextWrapper(helper.ViewContext.HttpContext);
            var cspConfigurationOverrideHelper = new CspConfigurationOverrideHelper();
            var headerOverrideHelper = new HeaderOverrideHelper(new CspReportHelper());

            var configOverride = new CspPluginTypesOverride() { Enabled = true, InheritMediaTypes = true, MediaTypes = new[] { mediaType } };
            cspConfigurationOverrideHelper.SetCspPluginTypesOverride(context, configOverride, false);
            cspConfigurationOverrideHelper.SetCspPluginTypesOverride(context, configOverride, true);

            headerOverrideHelper.SetCspHeaders(context, false);
            headerOverrideHelper.SetCspHeaders(context, true);
            var attribute = $"type=\"{helper.AttributeEncode(mediaType)}\"";
            return new HtmlString(attribute);
        }

        private static HtmlString CreateNonceAttribute(HtmlHelper helper, string nonce)
        {
            var sb = "nonce=\"" + helper.AttributeEncode(nonce) + "\"";
            return new HtmlString(sb);
        }
    }
}