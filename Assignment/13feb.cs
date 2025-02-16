using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    // 1. Container With Most Water
    public static int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int currentArea = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, currentArea);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }

    // 2. Merge Intervals
    public static List<Interval> MergeIntervals(List<Interval> intervals)
    {
        if (intervals == null || intervals.Count <= 1)
        {
            return intervals;
        }

        intervals.Sort((a, b) => a.start - b.start); // Sort by start time

        List<Interval> merged = new List<Interval>();
        Interval current = intervals[0];

        for (int i = 1; i < intervals.Count; i++)
        {
            Interval next = intervals[i];
            if (next.start <= current.end)
            {
                current.end = Math.Max(current.end, next.end);
            }
            else
            {
                merged.Add(current);
                current = next;
            }
        }
        merged.Add(current); // Add the last interval

        return merged;
    }

    public class Interval
    {
        public int start;
        public int end;

        public Interval()
        {
            start = 0;
            end = 0;
        }

        public Interval(int s, int e)
        {
            start = s;
            end = e;
        }

        public override string ToString()
        {
            return "[" + start + "," + end + "]";
        }
    }


    // 3. Longest Substring Without Repeating Characters
    public static int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        int maxLength = 0;
        Dictionary<char, int> charMap = new Dictionary<char, int>();
        int left = 0;

        for (int right = 0; right < n; right++)
        {
            char c = s[right];
            if (charMap.ContainsKey(c) && charMap[c] >= left)
            {
                left = charMap[c] + 1;
            }
            charMap[c] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }

    // 4. Rotate Image
    public static void Rotate(int[][] matrix)
    {
        int n = matrix.Length;

        // Transpose the matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        // Reverse each row
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][n - 1 - j];
                matrix[i][n - 1 - j] = temp;
            }
        }
    }

    // 5. Valid Parentheses
    public static bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0 || stack.Peek() != '(') return false;
                stack.Pop();
            }
            else if (c == '}')
            {
                if (stack.Count == 0 || stack.Peek() != '{') return false;
                stack.Pop();
            }
            else if (c == ']')
            {
                if (stack.Count == 0 || stack.Peek() != '[') return false;
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    // 6. Reverse Linked List
    public static ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null)
        {
            ListNode nextTemp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextTemp;
        }

        return prev;
    }

    // 7. Find Missing Number
    public static int FindMissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expectedSum = (n + 1) * (n + 2) / 2;
        int actualSum = 0;

        foreach (int num in nums)
        {
            actualSum += num;
        }

        return expectedSum - actualSum;
    }

    // 8. Top K Frequent Elements
    public static List<int> TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            frequencyMap[num] = frequencyMap.ContainsKey(num) ? frequencyMap[num] + 1 : 1;
        }

        return frequencyMap.OrderByDescending(pair => pair.Value)
                           .Take(k)
                           .Select(pair => pair.Key)
                           .ToList();
    }

    // 9. Search Insert Position
    public static int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left;
    }

    // 10. Jump Game
    public static bool CanJump(int[] nums)
    {
        int reachable = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > reachable)
            {
                return false;
            }
            reachable = Math.Max(reachable, i + nums[i]);
        }
        return true;
    }
}