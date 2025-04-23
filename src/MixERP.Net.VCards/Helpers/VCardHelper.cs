using System.Text.RegularExpressions;

namespace MixERP.Net.VCards.Helpers
{
    public static class VCardHelper
    {
        public static string[] SplitCards(string contents)
        {
            // Original code was not splitting properly under more modern .NET regex
            // return Regex.Split(contents, "((BEGIN:VCARD)(.*)(END:VCARD))");

            return new Regex("(BEGIN: VCARD.*? END : VCARD)", 
                             RegexOptions.Singleline | 
                             RegexOptions.IgnorePatternWhitespace)
                            .Matches(contents).Select(x => x.Value).ToArray();
        }
    }
}
