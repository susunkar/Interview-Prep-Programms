<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    string s = "cat";
    string t = "cta";
    int [] counts = new int[26];
    for(int i=0; i<s.Length; i++){
        counts[s.ElementAt(i) -'a']++;
        counts[t.ElementAt(i) - 'a']--;
    }
  
    for(int i=0; i<counts.Count(); i++){
        if(counts[i] != 0){
            "No Annagram".Dump();
            return;
        }
    }
    "Annagram".Dump();
}

// Define other methods, classes and namespaces here
