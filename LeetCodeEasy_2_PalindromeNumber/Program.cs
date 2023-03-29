Console.WriteLine($" 123 palindrome? {IsPalindrome(123)}");
Console.WriteLine($" 454 palindrome? {IsPalindrome(454)}");
Console.WriteLine($" 765 palindrome? {IsPalindrome(765)}");

bool IsPalindrome(int x)
{
    string numAsString = x.ToString();
    char[] Characters = numAsString.ToCharArray();
    Array.Reverse(Characters);
    string revNumAsString = String.Join("", Characters);
    return (numAsString == revNumAsString);
}


