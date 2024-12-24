﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Microsoft.IdentityModel.TestUtils.TokenValidationExtensibility.Tests;
using Xunit;

#nullable enable
namespace Microsoft.IdentityModel.Tokens.Saml.Extensibility.Tests
{
    public partial class SamlSecurityTokenHandlerValidateTokenAsyncTests
    {
        [Theory, MemberData(
            nameof(GenerateAudienceExtensibilityTestCases),
            parameters: ["SAML", 2],
            DisableDiscoveryEnumeration = true)]
        public async Task ValidateTokenAsync_AudienceValidator_Extensibility(
            AudienceExtensibilityTheoryData theoryData)
        {
            await ExtensibilityTesting.ValidateTokenAsync_Extensibility(
                theoryData,
                this,
                nameof(ValidateTokenAsync_AudienceValidator_Extensibility));
        }

        public static TheoryData<AudienceExtensibilityTheoryData> GenerateAudienceExtensibilityTestCases(
            string tokenHandlerType,
            int extraStackFrames)
        {
            return ExtensibilityTesting.GenerateAudienceExtensibilityTestCases(
                tokenHandlerType,
                extraStackFrames,
                "SamlSecurityTokenHandler.ValidateToken.Internal.cs");
        }
    }
}
#nullable restore
