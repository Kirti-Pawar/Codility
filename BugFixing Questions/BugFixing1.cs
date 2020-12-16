using System;

class BugFixing1 {

    //return the character that occurs the most frequently in the given string
    //in case of more than one character satisfying the requirement, we need to
    //return the earliest character alphabetically
    public String solution(string S) {
        int[] occurrences = new int[26];
        foreach (char ch in S) {
            occurrences[(int)ch - 'a']++;
        }
	
Console.WriteLine();
        char best_char = 'a';
        int best_res = -1;
	

         for (int i = 0; i < 26; i++) {
            if (occurrences[i] >best_res) {
                best_char = (char) ('a' + i);
                best_res = occurrences[i];
	}
        }

        return best_char.ToString();
    }
    
    
    public static void Main(string[] args) {
        Console.WriteLine(new BugFixing1().solution("apple"));
    	Console.WriteLine(new BugFixing1().solution("hello"));
    	Console.WriteLine(new BugFixing1().solution("parameter"));
    	
    }
}
