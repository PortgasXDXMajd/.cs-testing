


namespace Helpers
{
    public static class ValideSlidingWindow
    {
        private static bool IsValidWindow(Dictionary<char, int> window, string t)
        {   
            return window.All(kvp => t.Contains(kvp.Key) && kvp.Value >= 1);
        }

        private static string GetWindowSubstring(string s, int left, int right)
        {
            return s.Substring(left, right - left + 1);
        }

        private static bool IsNeededChar(char c)
        {
            return c == 'a' || c == 'b' || c == 'c';
        }

        // This method finds the minimum valid window in the given string that contains 'a', 'b', and 'c' exactly once.
        public static string GetMinValidWindow(string s, string t)
        {
            if(s.Length < 3) 
                return string.Empty;

            string validWindow = string.Empty;
            int left = 0;
            int right = 1;

            var window = t.ToDictionary(c => c, c => 0);
        
            if(IsNeededChar(s[0]))
            {
                window[s[0]] = window.GetValueOrDefault(s[0], 0) + 1;
            }

            // Time Complexity: O(n), where n is the length of the input string. Each character is processed at most twice (once when expanding the window and once when contracting it).
            while(right < s.Length)
            {
                char rightChar = s[right];
                if (IsNeededChar(rightChar))
                {
                    window[rightChar] = window.GetValueOrDefault(rightChar, 0) + 1;
                }
                
                while(IsValidWindow(window, t))
                {
                    if(validWindow == string.Empty || (right - left + 1) < validWindow.Length)
                    {
                        validWindow = GetWindowSubstring(s, left, right);
                    }

                    char leftChar = s[left];
                    if(IsNeededChar(leftChar))
                    {
                        window[leftChar]--;
                    }

                    left++;
                }

                right++;
            }
           

            return validWindow;
        }
    }
}