using Workshop_C;

namespace WorkShop_CTests;

using Xunit;

public class StringOperationTests
{
    private StringOperation strOperation = new StringOperation();

    [Fact]
    public void Concatenate2Strings_test1()
    {
        var result = strOperation.concat2trings("Hello", "sigmotoa");
        Assert.Equal("Hello sigmotoa", result);
    }

    [Fact]
    public void Concatenate2Strings_test2()
    {
        var result = strOperation.concat2trings("Hello", "sigmotoa");
        Assert.NotEqual("hello sigmotoa", result);
    }

    [Fact]
    public void Concatenate2Strings_test3()
    {
        var result = strOperation.concat2trings("Awesome ", "Testing");
        Assert.Equal("Awesome  Testing", result);
    }

    [Fact]
    public void charsInString_test1()
    {
        Assert.Equal(15, strOperation.charsInString("I'm your father"));
    }

    [Fact]
    public void charsInString_test2()
    {
        Assert.NotEqual(12, strOperation.charsInString("I'm your father"));
    }

    [Fact]
    public void charsInString_test3()
    {
        Assert.Equal(11, strOperation.charsInString("Engineering"));
    }

    [Fact]
    public void charsInString_test4()
    {
        Assert.NotEqual(11, strOperation.charsInString("Bored"));
    }

    [Fact]
    public void lettersInString_test1()
    {
        Assert.Equal(13, strOperation.lettersInString("sigmotoa rulez"));
    }

    [Fact]
    public void lettersInString_test2()
    {
        Assert.Equal(14, strOperation.lettersInString("MS Visual Studio"));
    }

    [Fact]
    public void lettersInString_test3()
    {
        Assert.NotEqual(14, strOperation.lettersInString("sigmotoa rulez"));
    }

    [Fact]
    public void UpperInString_test1()
    {
        Assert.Equal(3, strOperation.upperInString("Im Iron Man"));
    }
    [Fact]
    public void UpperInString_test2()
    {
        Assert.Equal(4, strOperation.upperInString("MS Visual Studio"));
    }
    [Fact]
    public void UpperInString_test3()
    {
        Assert.NotEqual(4, strOperation.upperInString("Ms Visual Studio"));
    }

    [Fact]
    public void CharInString_test1()
    {
        Assert.Equal(2, strOperation.charInString("sigmotoa",'o'));
    }
     [Fact]
    public void CharInString_test2()
    {
        Assert.Equal(3, strOperation.charInString("Ms Visual Studio",'s'));
    }
    [Fact]
    public void CharInString_test3()
    {
        Assert.Equal(6, strOperation.charInString("anita lava la tina",'a'));
    }
     [Fact]
    public void CharInString_test4()
    {
        Assert.NotEqual(6, strOperation.charInString("anita lava la tina",'n'));
    }
    [Fact]
    public void CharInString_test5()
    {
        Assert.Equal(2, strOperation.charInString("anita lava la tina",'n'));
    }

    [Fact]
    public void ReverseString_test1()
    {
     Assert.Equal("aotomgis", strOperation.reverseString("sigmotoa"));   
    }
    
    [Fact]
    public void ReverseString_test2()
    {
     Assert.Equal("atemoc", strOperation.reverseString("cometa"));   
    }
    [Fact]
    public void ReverseString_test3()
    {
     Assert.Equal("oiduts lausiv", strOperation.reverseString("visual studio"));   
    }
    [Fact]
    public void ReverseString_test4()
    {
     Assert.Equal("anit al aval atina", strOperation.reverseString("anita lava la tina"));   
    }
    [Fact]
    public void ReverseString_test5()
    {
     Assert.NotEqual("anitalavalatina", strOperation.reverseString("anita lava la tina"));   
    }

    [Fact]
    public void IsPalindrome_test1()
    {
        Assert.True(strOperation.isPalindrome("Anita lava la tina"));
    }
    [Fact]
    public void IsPalindrome_test2()
    {
        Assert.True(strOperation.isPalindrome("In girum imus nocte et consumimur igni"));
    }
    
    [Fact]
    public void IsPalindrome_test3()
    {
        Assert.True(strOperation.isPalindrome("Atar a la rata"));
    }
    
    [Fact]
    public void IsPalindrome_test4()
    {
        Assert.False(strOperation.isPalindrome("pablito clavo un clavito"));
    }

    [Fact]
    public void Substring_test1()
    {
        Assert.Equal(2,strOperation.substring("anitalavalatina","la"));
    }
     [Fact]
    public void Substring_test2()
    {
        Assert.Equal(2,strOperation.substring("pablito clavo un clavito","cla"));
    }
     [Fact]
    public void Substring_test3()
    {
        Assert.Equal(4,strOperation.substring("atar a la rata no es mas que atar a la rata","ata"));
    }
      [Fact]
    public void Substring_test4()
    {
        Assert.NotEqual(2,strOperation.substring("atar a la rata no es mas que atar a la rata","ata"));
    }
    
}