public class Solution {
    public bool ValidMountainArray(int[] arr) {
        int i = 0;
        int n = arr.Length;

        while(i + 1 < n && arr[i] < arr[i + 1])
        {
        i++;
        }

        if( n < 3) 
        return false;

    

        while(i + 1 < n && arr[i] > arr[i +1])
        {
        i++;
        }

        return i == n-1;
