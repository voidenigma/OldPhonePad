using Xunit;
using OldPhonePadApp;

namespace OldPhonePadTests;

public class ProgramTest
{
    [Theory]
    // Checks the basic consecutive pressing functionality of the OldPhonePad method
    // Pressing '3' once should give 'D', twice 'E', and three times 'F' which in this case expected output should be "E"
    [InlineData("33#", "E")]
    // Checks the method when the input contains invalid character, outputs "?????" to indicate error
    [InlineData("227*#", "?????")]
    // Checks when the input contains an empty space marking the end and signaling a new character sequence
    [InlineData("4433555 555666#", "HELLO")]
    // Checks the method when the input contains an invalid character in the middle
    [InlineData("8 88777444666*664#", "?????")]
    // Pressing the same key multiple times will cycle through the letters associated with that key
    // Checks if the program can handle multiple consecutive key presses correctly
    [InlineData("66666555555333333#", "NLF")]
    // Assume the prefix "#" for sending is not included in the input somehow
    // Returns "?????" as the input does not follow valid syntax
    [InlineData("01", "?????")]

    public void TestOldPhonePad(string input, string expected)
    {
        string result = Program.OldPhonePad(input);
        Assert.Equal(expected, result);
    }
}