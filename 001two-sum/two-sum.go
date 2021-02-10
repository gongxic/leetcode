package main

import fm "fmt"

func twoSum(nums []int, target int) []int {
	for i, num := range nums {
		for j := i + 1; j < len(nums); j++ {
			if num+nums[j] == target {
				return []int{i, j}
			}
		}
	}
	return nil
}

func twoSum2(nums []int, target int) []int {
	mapDic := map[int]int{}
	for i, num := range nums {
		if x, ok := mapDic[target-num]; ok {
			return []int{i, x}
		}
		mapDic[num] = i

	}
	return nil
}

func main() {
	nums := []int{1, 2, 3, 4}
	result := twoSum(nums, 3)
	fm.Println(result)
}
