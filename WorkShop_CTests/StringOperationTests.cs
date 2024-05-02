using Workshop_C;

namespace WorkShop_CTests;
using Xunit;

public class StringOperationTests
{
    [Fact]
    public void Concatenar2Strings()
    {
        var strOperation = new StringOperation();
        var result = strOperation.concat2trings("Hello", "sigmotoa");
        Assert.Equal("Hello sigmotoa", result);
    }
}