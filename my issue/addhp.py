"""
问题：
有n个血瓶，血瓶最多m种，要恢复x量的hp
选出最合适的组合

分析：
属于 动态规划 的问题

输入：
100血量 x 7个，500血量 x 3个，1000血量 x 1个，需要恢复 750 血量

输出：
500x1 + 100x3
"""

	# if amount == 0:
	# 	return 0
	# if idxCoin < len(coins) and amount > 0:
	# 	maxVal = int(amount / coins[idxCoin])
	# 	minCost = amount + 1
	# 	print("-------------")
	# 	for x in range(0, maxVal + 1):
	# 		kk = amount - x * coins[idxCoin]
	# 		if amount >= x * coins[idxCoin]:
	# 			res = _coinChange(idxCoin + 1, coins, amount - x * coins[idxCoin])
	# 			if res != -1:
	# 				print('select > ' + str(coins[idxCoin]))
	# 				minCost = min(minCost, res + x)
	# 	return -1 if (minCost == amount + 1) else minCost
	# return -1

# return select idx num
def addhp(idx, items, nums, hp, add):
	if hp <= 0:
		return 0
	if idx < len(items) and hp > 0:
		# if nums[idx] <= 0:
		# 	return addhp(idx + 1, items, nums, hp, select)
		hv = items[idx]
		maxVal = int(hp / hv)
		maxVal = min(maxVal, nums[idx])
		minCost = hp * 2
		sx = 0
		for x in range(0, maxVal + 1):
			if idx == 0:
				print("-------------------- " + str(x))
			if hp >= x * hv:
				res = addhp(idx + 1, items, nums, hp - x * hv, x * hv)
				print("xx-- x:" + str(x) + " idx:" + str(idx + 1) + " hp:" + str(hp - x * hv) + " res:" + str(res))
				if res != -1:
					minCost = min(minCost, res + x)
		return -1 if (minCost > hp) else minCost
	return -1

# def addhp(items, nums, amount):
# 	max = amount + 1
# 	dp = [max for i in range(amount + 1)]
# 	dp[0] = 0
# 	for i in range(1, amount + 1):
# 		print("-------------------")
# 		for j in range(0, len(coins)):
# 			if coins[j] <= i:
# 				dp[i] = min(dp[i], dp[i - coins[j]] + 1)
# 				print("select > " + str(dp[i]))
# 	return -1 if dp[amount] > amount else dp[amount]

if __name__ == "__main__":
	select = []
	res = addhp(0, [100, 500, 1000], [7, 3, 1], 750, 0)
	print("result > " + str(res))