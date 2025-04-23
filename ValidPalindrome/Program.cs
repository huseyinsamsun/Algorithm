using System.Text;

IsPalindrome("A man, a plan, a canal: Panama");

bool IsPalindrome(string s)
{
    if (string.IsNullOrEmpty(s))
        return true;

    StringBuilder stringBuilder = new StringBuilder();
    char[] words = s.ToCharArray();

    foreach (var item in words)
    {
        if (char.IsLetterOrDigit(item))
            stringBuilder.Append(item.ToString().ToLower());
    }

    string finalWords = stringBuilder.ToString();
    words = finalWords.ToCharArray();
    Array.Reverse(words);
    string reversed = new string(words);
    if (finalWords == reversed)
        return true;

    return false;
}