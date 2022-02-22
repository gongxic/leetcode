class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        hasmap=dict()
        for i,x in enumerate(nums):
            if target-x in hasmap:
                return [i,hasmap[target-x]]
            hasmap[x]=i
        return []