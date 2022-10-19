using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var s = "We promptly judged antique ivory buckles for the next prize";

        var expected = "pangram";

        var actual = Result.pangrams(s);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var s = "We promptly judged antique ivory buckles for the prize";

        var expected = "not pangram";

        var actual = Result.pangrams(s);

        Assert.Equal(expected, actual);
    }
}