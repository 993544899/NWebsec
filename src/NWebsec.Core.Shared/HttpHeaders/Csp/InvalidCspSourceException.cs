// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using System;

namespace NWebsec.AspNetCore.Core.HttpHeaders.Csp
{
    //[Serializable]
    public class InvalidCspSourceException : Exception
    {
        public InvalidCspSourceException(string s)
            : base(s)
        {
        }
    }
}