public class Solution {
    public bool IsPalindrome(int x) {
        
        string result=$"{x}";
            var arr=result.ToCharArray();
            Array.Reverse(arr);
        string res2=new string(arr);
        if(res2==result){
            return true;
        }
       return false;
    }
}