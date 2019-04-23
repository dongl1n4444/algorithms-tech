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

def lengthOfLongestSubstring(s):
	if s == None or len(s) == 0:
		return 0
	
	ll = []
	max = 0
	count = 0
	for i in range(0, len(s)):
		if s[i] in ll:
			if count > max:
				max = count
			ll = []
			count = 0

		count += 1
		ll.append(s[i])
		if count > max:
			max = count
				
	return max
	

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