// This file was auto-generated based on version 1.2.0 of the canonical data.

using Xunit;

public class TwoFerTest
{
    [Fact]
    public void No_name_given()
    {
        Assert.Equal("One for you, one for me.", TwoFer.Name());
    }

    [Fact]
    public void A_name_given()
    {
        Assert.Equal("One for Alice, one for me.", TwoFer.Name("Alice"));
    }

    [Fact]
    public void Another_name_given()
    {
        Assert.Equal("One for Bob, one for me.", TwoFer.Name("Bob"));
    }

    [Fact]
    public void Give_spaces_as_an_input()
    {
        Assert.Equal("One for you, one for me.", TwoFer.Name("   "));
    }

    [Fact]
    public void Give_empty_string_as_an_input()
    {
        Assert.Equal("One for you, one for me.", TwoFer.Name(""));
    }
}