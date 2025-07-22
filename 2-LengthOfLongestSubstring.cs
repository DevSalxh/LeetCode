public class Solution {
    public int LengthOfLongestSubstring(string Word) {
        // This variable gonna have the value of the maximum length of whole substrings
        int MaximumLength = 0;
        // Declaring Dictionary
        Dictionary<char, int> map = new Dictionary<char, int>();
        // I used it for Sliding-Window technique
        int Begin = 0;

        for (int End = 0; End < Word.Length; End++) {
            char CurrentCharacter = Word[End];

            //  map.ContainsKey(...): to check if the character already has key in the map
            //  map[CurrentCharacter]...: to check if the last occur of the char is inside the current substring
            if (map.ContainsKey(CurrentCharacter) && map[CurrentCharacter] >= Begin) {
                Begin = map[CurrentCharacter] + 1;
            }

            //  Update the last occur in the map
            map[CurrentCharacter] = End;
            // This statement check which one higher and keep it inside MaximumLength
            MaximumLength = Math.Max(MaximumLength, End - Begin + 1);
        }

        //  Return the longest length of the all possible non-repeating substring
        return MaximumLength;
    }
}
