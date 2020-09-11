using DemoCode;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace DemoTest
{
    public class ExpoTest
    {
        [Theory]
        [InlineData(10, 3)]
        [InlineData(2, 16)]
        [InlineData(1234, 2)]
        public void TestPositivCore(int baseValue, int expo)
        {
            Assert.Equal(Math.Pow(baseValue, expo), Expo.GetExpo(baseValue, expo));
        }

    }
}
