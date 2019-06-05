"""
问题：
有n个血瓶，血瓶最多m种，要恢复x量的hp
选出最合适的组合

分析：
属于 背包问题，使用 动态规划 优化时间

输入：
100血量 x 7个，500血量 x 3个，1000血量 x 1个

输出：
750 = 500x1 + 100x3
600 = 500x1 + 100x1
70 = 100x1
1200 = 1000x1 + 100x2
"""

import math
import sys

# return idx offer value
def addhp(idx, items, nums, hp, total, select):
	if hp <= 0 or idx >= len(items):
		return 0
	if idx in select and hp in select[idx]:
		return select[idx][hp][0] # return offerVal

	hv = items[idx]
	maxVal = math.ceil(hp / hv)
	maxVal = min(maxVal, nums[idx])
	offerVal = -1
	maxOfferTotal = sys.maxsize

	for x in range(0, maxVal + 1):
		# if idx == 0:
		# 	print("-------------------- " + str(x))
		curCost = x * hv
		if total + curCost >= maxOfferTotal:
			continue 

		res = addhp(idx + 1, items, nums, hp - curCost, total + x * hv, select)
		print("xx-- x:" + str(x) + " idx:" + str(idx + 1) + " hp:" + str(hp - x * hv) + " res:" + str(res))
		if res != -1 and res + x * hv >= hp and total + res + x * hv < maxOfferTotal:
			maxOfferTotal = total + res + x * hv
			offerVal = res + x * hv
			select[idx] = {
				hp: [offerVal, x]
			}
			
	return offerVal

if __name__ == "__main__":
	select = {}
	res = addhp(0, [100, 500, 1000], [7, 3, 1], 750, 0, select)
	print("result > " + str(res))
	
	select = {}
	res = addhp(0, [100, 500, 1000], [0, 1, 1], 1200, 0, select)
	print("result > " + str(res))