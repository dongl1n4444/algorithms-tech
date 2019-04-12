# https://leetcode.com/problems/coin-change/

def coinChange(coins, amount):
	return 0

if __name__ == "__main__":
	ret =	coinChange([1,2,5], 11)
	assert ret == 3
	ret = coinChange([2], 3)
	assert ret == -1