"""
Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
"""

# 最简单版本
# T: O(n^2)
# S: O(1)
def twoSum1(nums, target):
	for i in range(0, len(nums)):
		for j in range(i + 1, len(nums)):
			if (nums[i] + nums[j] == target):
				return [i, j]

# 缓存
# T: O(n)
# S: O(n)
def twoSum2(nums, target):
	maps = {}
	for i in range(0, len(nums)):
		diff = target - nums[i]
		if diff in maps:
			return [maps[diff], i]
		maps[nums[i]] = i

if __name__ == "__main__":
	nums = twoSum1([2, 7, 11, 15], 9)
	assert(nums[0] == 0 and nums[1] == 1)
	nums = twoSum2([2, 7, 11, 15], 9)
	assert(nums[0] == 0 and nums[1] == 1)