using System;
using Xunit;

namespace PricingApi.IntegrationTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Given
        int a = 10, b = 20;

        // when

        var answer = a + b;

        // 
        Assert.Equal(30, answer);
    }

    [Theory]
    [InlineData(2,2,4)]
    [InlineData(3,3,6)] 
    [InlineData(4,4,8)]
    public void CanAddAnyTwoIntegers(int a, int b, int expected)
    {
        var answer = a + b;
        Assert.Equal(expected, answer);
    }
}
