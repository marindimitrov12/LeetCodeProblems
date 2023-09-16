public class Solution {
    public int RemoveElement(int[] nums, int val) {
        List<int>newnums=new List<int>();
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=val){
                newnums.Add(nums[i]);
            }
        }
        for(int i=0;i<newnums.Count;i++){
            nums[i]=newnums[i];
        }
        return newnums.Count;
    }
}