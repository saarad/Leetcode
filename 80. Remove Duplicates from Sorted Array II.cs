//https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
/*
Given an integer array nums sorted in non-decreasing order, remove some duplicates in-place such that each unique element appears at most twice. The relative order of the elements should be kept the same.
Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.

Return k after placing the final result in the first k slots of nums.

Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
*/
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 1)
            return 1;

        var threshold = 2;

        var deleted = 0;
        var prevSeen = nums[0];
        var duplicateSeen = 1;
        var pointer = 0;
        for(int right = 1; right<nums.Length; right++){
            if(nums[right] == prevSeen){
                duplicateSeen++;
            }
            else{
                duplicateSeen = 1;
            }

            if(duplicateSeen > threshold){ //make pointer a walker if there are duplicates to let next element take its place
                duplicateSeen--;
                deleted++;
            }
            else{
                prevSeen = nums[right];
                pointer++;
            }

            nums[pointer] = nums[right];
        }

        return nums.Length-deleted;
    }


}
