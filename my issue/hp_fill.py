"""
问题：
有n个血瓶，血瓶最多m种，要恢复x量的hp
选出最合适的组合

分析：


输入：
100血量 x 7个，500血量 x 3个，1000血量 x 1个，需要恢复 750 血量

输出：
500x1 + 100x3
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

def slat(idx, items, nums, hp, select):
	if hp <= 0:
		return 0
	if idx < len(items) and hp > 0:
		hv = items[idx]
		#if items[hv] <= 0:
		#	return -1
		maxVal = int(hp / hv)
		minCost = hp * 2
		for x in range(0, maxVal + 1):
			if hp >= x * hv:
				res = slat(idx + 1, items, nums, hp - x * hv, select)
				if res != -1:
					minCost = min(minCost, res + x)
		return -1 if (minCost > hp) else minCost
	return -1

if __name__ == "__main__":
	select = []
	res = slat(0, [500, 100, 1000], [3, 7, 1], 700, select)
	print("result > " + str(res))