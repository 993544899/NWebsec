#region License
/*
Copyright (c) 2012, Andr� N. Klingsheim
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this
  list of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright notice,
  this list of conditions and the following disclaimer in the documentation
  and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE
OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
OF THE POSSIBILITY OF SUCH DAMAGE.
*/
#endregion

namespace NWebsec.HttpHeaders
{
    public class HttpHeadersConstants
    {
        public enum XFrameOptions { Disabled, Deny, SameOrigin }
        public enum XXssProtection { Disabled, FilterDisabled, FilterEnabled }

        public static readonly string[] CspSourceList = {    "'none'",
                                                   "'self'",
                                                   "'unsafe-inline'",
                                                   "'unsafe-eval'"
                                               };

        public static readonly string[] CspDirectives = {   "default-src",
                                                   "script-src",
                                                   "object-src",
                                                   "style-src", 
                                                   "img-src",
                                                   "media-src", 
                                                   "frame-src", 
                                                   "font-src", 
                                                   "connect-src", 
                                                   "report-uri" 
                                               };

        public static readonly string[] CspSchemes = {   "data:",
                                                "https:",
                                                "http:" 
                                            };

        public static readonly string[] VersionHeaders = { "X-AspNet-Version", "X-AspNetMvc-Version" };
    }
}
