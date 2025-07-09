/* Longest Substring Without Repeating Characters 

Given a string s, find the length of the longest substring without duplicate characters.

 

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

Constraints:

0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces. /*

/* SOLUTION */

public class Solution {
    public int LengthOfLongestSubstring(string s) {

        HashSet<char> inchar = new HashSet<char>();
        int left = 0, right = 0, maxLength = 0;

        while (right < s.Length) {
            if (!inchar.Contains(s[right])) {
                inchar.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            } else {
                inchar.Remove(s[left]);
                left++;
            }
        }

        return maxLength;
    }
        
    
}