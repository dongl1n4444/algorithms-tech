"""
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.
"""

class ListNode:
	def __init__(self, x):
		self.val = x
		self.next = None

def addTwoNumbers(l1, l2):
	p1 = l1
	p2 = l2
	carry = 0
	l3p = None
	l3f = None
	while p1 != None or p2 != None:
		p1v = p1.val if p1 else 0
		p2v = p2.val if p2 else 0

		val = p1v + p2v + carry
		carry = 0

		n0 = val % 10
		carry = val // 10
		l3 = ListNode(n0)

		if l3p != None:
			l3p.next = l3
		if l3f is None:
			l3f = l3
		l3p = l3

		p1 = p1.next if p1 else None
		p2 = p2.next if p2 else None
	
	if carry != 0:
		l3 = ListNode(carry)
		l3p.next = l3
	
	return l3f

if __name__ == "__main__":
	l10 = ListNode(2)
	l11 = ListNode(4)
	l12 = ListNode(3)
	l10.next = l11
	l11.next = l12

	l20 = ListNode(5)
	l21 = ListNode(6)
	l22 = ListNode(4)
	l20.next = l21
	l21.next = l22

	nums = addTwoNumbers(l10, l20)

	l10 = ListNode(1)
	l11 = ListNode(8)
	l10.next = l11

	l20 = ListNode(0)
	nums = addTwoNumbers(l10, l20)

	l10 = ListNode(5)
	l20 = ListNode(5)
	nums = addTwoNumbers(l10, l20)