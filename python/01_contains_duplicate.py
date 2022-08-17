"""
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
"""

arr = [1,10,11,30,3,4,31,2]
def find_duplicate(nums):
    acc = set()
    for num in nums:
        if num in acc:
            return True
    else:
        acc.add(num)
    return False

print(find_duplicate(arr))