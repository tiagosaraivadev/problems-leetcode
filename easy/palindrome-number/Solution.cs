public class Solution {
    public bool IsPalindrome(int x) {
        string number = x.ToString();
        string invertedNumber = "";

        for (int i = number.Length - 1; i >= 0; i--) {
            invertedNumber = string.Concat(invertedNumber, number[i]);
        }

        bool result;
        result = invertedNumber.Equals(number);
        return result;
    }
}