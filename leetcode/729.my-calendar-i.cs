/*
 * @lc app=leetcode id=729 lang=csharp
 *
 * [729] My Calendar I
 */

// @lc code=start
using System.Collections.Generic;

public class MyCalendar {
    Dictionary<int, int> kk = new Dictionary<int, int>();

    public MyCalendar() {
        
    }
    
    public bool Book(int start, int end) {
        foreach (var kv in kk)
        {
            if (!(kv.Key >= end || kv.Value <= start))
                return false;
        }
        kk[start] = end;
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */
// @lc code=end

