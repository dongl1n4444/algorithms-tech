"""
Given a string, find the length of the longest substring without repeating characters.

Example 1:

Input: "abcabcbb"
Output: 3 
Explanation: The answer is "abc", with the length of 3. 
Example 2:

Input: "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3. 
						 Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
"""

# force 解法
def lengthOfLongestSubstring(s):
	if s == None or len(s) == 0:
		return 0
	
	ret = 0
	for i in range(0, len(s)):
		ll = []
		for j in range(i, len(s)):
			if s[j] in ll:
				ret = max(ret, j - i)
				break
				
			ll.append(s[j])
			ret = max(ret, j - i + 1)
				
	return ret
	

if __name__ == "__main__":
	ret = lengthOfLongestSubstring("abcabcbb")
	assert(ret == 3)

	ret = lengthOfLongestSubstring("bbbbb")
	assert(ret == 1)

	ret = lengthOfLongestSubstring("pwwkew")
	assert(ret == 3)

	ret = lengthOfLongestSubstring("aab")
	assert(ret == 2)

	ret = lengthOfLongestSubstring("dvdf")
	assert(ret == 3)

	ret = lengthOfLongestSubstring(" ")
	assert(ret == 0)