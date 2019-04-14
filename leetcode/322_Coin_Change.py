# https://leetcode.com/problems/coin-change/

def _coinChange(idxCoin, coins, amount):
	if amount == 0:
		return 0
	if idxCoin < len(coins) and amount > 0:
		maxVal = int(amount / coins[idxCoin])
		minCost = amount + 1
		print("-------------")
		for x in range(0, maxVal + 1):
			kk = amount - x * coins[idxCoin]
			if amount >= x * coins[idxCoin]:
				res = _coinChange(idxCoin + 1, coins, amount - x * coins[idxCoin])
				if res != -1:
					print('select > ' + str(coins[idxCoin]))
					minCost = min(minCost, res + x)
		return -1 if (minCost == amount + 1) else minCost
	return -1

def coinChange1(coins, amount):
	return _coinChange(0, coins, amount)

def coinChange2(coins, amount):
	max = amount + 1
	dp = [max for i in range(amount + 1)]
	dp[0] = 0
	for i in range(1, amount + 1):
		for j in range(0, len(coins)):
			if coins[j] <= i:
				dp[i] = min(dp[i], dp[i - coins[j]] + 1)
	return -1 if dp[amount] > amount else dp[amount]

if __name__ == "__main__":
	res =	coinChange2([1,2,5], 11)
	print('result > ' + str(res)) 
	# assert res == 3
	res = coinChange2([2], 3)
	print('result > ' + str(res))
	# assert ret == -1