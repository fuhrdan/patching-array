//*********************************************************
//**330. Leetcode Patching Array                         **
//** My original approach was to use a hash table, but   **
//** then I went with a simple index count.  This worked **
//** tbut it worked slowly.  -- Dan                      **
//*********************************************************

int minPatches(int* nums, int numsSize, int n) {
    long sum = 1;
    int result = 0;
    int index = 0;
    while(sum <= n)
    {
        if (index < numsSize && nums[index] <= sum)
        {
            sum += nums[index++];
        }
        else
        {
            result++;
            sum <<= 1;
        }
    }
    return result;
}