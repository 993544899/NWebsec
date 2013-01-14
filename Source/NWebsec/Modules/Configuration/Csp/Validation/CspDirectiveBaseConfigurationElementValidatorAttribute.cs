// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using System.Configuration;

namespace NWebsec.Modules.Configuration.Csp.Validation
{
    public class CspDirectiveBaseConfigurationElementValidatorAttribute :
        ConfigurationValidatorAttribute
    {
        public override ConfigurationValidatorBase ValidatorInstance
        {
            get
            {
                return new CspDirectiveBaseConfigurationElementValidator();
            }
        }
    }
}