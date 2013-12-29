﻿// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.HttpHeaders;

namespace NWebsec.Core.HttpHeaders.Configuration
{
    public interface IXXssProtectionConfiguration
    {
        XXssProtectionPolicy Policy { get; set; }

        bool BlockMode { get; set; }
    }
}