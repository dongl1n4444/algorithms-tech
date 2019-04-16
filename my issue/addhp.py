"""
问题：
有n个血瓶，血瓶最多m种，要恢复x量的hp
选出最合适的组合

分析：
属于 动态规划 的问题

输入：
100血量 x 7个，500血量 x 3个，1000血量 x 1个

输出：
750 = 500x1 + 100x3
600 = 500x1 + 100x1
70 = 100x1
1200 = 1000x1 + 100x2
"""

import math

# return select idx num
def addhp(idx, items, nums, hp, total, select):
	if hp <= 0:
		return 0
	if idx < len(items) and hp > 0:
		# if nums[idx] <= 0:
		# 	return addhp(idx + 1, items, nums, hp, select)
		hv = items[idx]
		maxVal = math.ceil(hp / hv)
		maxVal = min(maxVal, nums[idx])
		minCost = hp * 2
		sx = -1
		maxTotal = 99999
		tmpSelect2 = {}
		for x in range(0, maxVal + 1):
			if idx == 0:
				print("-------------------- " + str(x))
			# if hp >= x * hv:
			# lastTotal += x * hv
			tmpSelect = {}
			tmpSelect[hv] = x

			res = addhp(idx + 1, items, nums, hp - x * hv, total + x * hv, tmpSelect)
			print("xx-- x:" + str(x) + " idx:" + str(idx + 1) + " hp:" + str(hp - x * hv) + " res:" + str(res))
			if res != -1 and res + x * hv >= hp and total + res + x * hv < maxTotal:
				maxTotal = total + res + x * hv
				sx = res + x * hv
				tmpSelect2 = tmpSelect
		# select = dict(select, **tmpSelect2)
		for k in tmpSelect2:
			if k not in select:
				select[k] = 0
			select[k] += tmpSelect2[k]
		return sx
		# return -1 if (minCost > hp) else minCost
	return 0

if __name__ == "__main__":
	select = {}
	res = addhp(0, [100, 500, 1000], [7, 3, 1], 750, 0, select)
	print("result > " + str(res))
	
	select = {}
	res = addhp(0, [100, 500, 1000], [0, 1, 1], 1200, 0, select)
	print("result > " + str(res))