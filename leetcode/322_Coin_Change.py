# https://leetcode.com/problems/coin-change/

def _coinChange(idxCoin, coins, amount):
	if amount == 0:
		return 0
	if idxCoin < len(coins) and amount > 0:
		maxVal = int(amount / coins[idxCoin])
		minCost = amount + 1
		for x in range(0, maxVal + 1):
			kk = x * coins[idxCoin]
			if amount >= x * coins[idxCoin]:
				res = _coinChange(idxCoin + 1, coins, amount - x * coins[idxCoin])
				if res != -1:
					minCost = min(minCost, res + x)
		return -1 if (minCost == amount + 1) else minCost
	return -1

def coinChange(coins, amount):
	return _coinChange(0, coins, amount)

if __name__ == "__main__":
	res =	coinChange([1,2,5], 11)
	print('result > ' + str(res)) 
	# assert res == 3
	res = coinChange([2], 3)
	print('result > ' + str(res))
	# assert ret == -1