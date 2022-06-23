// Question1
// A string is a palindrome if it reads the same forward and backward. 

// Given a string s, return true if it is a palindrome, or false otherwise.

// Example 1:

// Input: s = "amanaplanacanalpanama"
// Output: true
// Explanation: "amanaplanacanalpanama" is a palindrome.
// Example 2:

// Input: s = "raceacar"
// Output: false
// Explanation: "raceacar" is not a palindrome.

bool isPalindrome=false;

bool IsPalindrome(string s){
for(int i=0;i<s.size/2;i++)
{
  isPalindrome=(s[i]==s[s.size-i-1]);
  if(s[i]!=s[s.size-i-1])
  {
    break;
  }
 
}
  return isPalindrome;
}


// Question 2
// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// You can return the answer in any order.

 

// Example 1:

// Input: nums = [2,3,7,11,15], target = 9
// Output: [0,2]
// Explanation: Because nums[0] + nums[2] == 9, we return [0, 2].
// Example 2:

// Input: nums = [3,2,4], target = 7
// Output: [0,2]
// Example 3:

// Input: nums = [3,3], target = 6
// Output: [0,1]

int nums[5]= {2,3,7,11,15};
int target = 9;

public int[] FindTwoSum(List<int> nums, int target)
{
  for(int i=0;i<nums.count;i++)
  {
    for(int j=0;j<nums.count;j++){
      if(i!=j){
      if(target-nums[i]-nums[j]==0){
        int index[2]={i,j};
        return index;
      }
      }
    }
  }
}

public int[] FindTwoSum(List<int> nums, int target)
{
  for(int i=0;i<nums.count;i++)
  {
    for(int j=0;j<nums.count;j++){
      if(i!=j){
      if(target-nums[i]-nums[j]==0){
        int index[2]={i,j};
        return index;
      }
      }
    }
  }
}
