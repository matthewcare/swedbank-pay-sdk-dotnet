﻿namespace SwedbankPay.Sdk.Tests.UnitTests
{
    using System;

    using Xunit;

    public class LanguageTests
    {
        [Theory]
        [InlineData("SV-se")]
        [InlineData("NO-nb")]
        [InlineData("US-en")]

        public void ThrowsArgumentException_WhenGivenInvalidLanguageCode(string languageCode)
        {
            //ASSERT
            Assert.Throws<ArgumentException>(nameof(languageCode), () => new Language(languageCode));
        }

        [Fact]
        public void ThrowsArgumentNullException_WhenGivenEmptyLanguageCode()
        {
            //ASSERT
            Assert.Throws<ArgumentNullException>("languageCode", () => new Language(""));
        }
        
        [Theory]
        [InlineData("sv-SE")]
        [InlineData("nb-NO")]
        [InlineData("en-US")]
        public void CreateNewLanguageCode_DoesNotThrow_WhenGivenValidLanguageCode(string languageCode)
        {
            //ACT
            var ex = Record.Exception(() => new Language(languageCode));

            //ASSERT
            Assert.Null(ex);
        }
    }
}