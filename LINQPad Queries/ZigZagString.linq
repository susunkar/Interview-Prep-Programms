<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
   Convert("PAYPALISHIRING",4);
}

public void Convert (string s, int numRows)
{
    int delta = -1;
    int row = 0;
    string[] res = new string[numRows];
   
   foreach (char c in s.ToArray()){
       if(res[row] == null) res[row] = "";
       res[row] += c;
       if(row == 0 || row == numRows -1){
           delta *=-1;
       }
       row +=delta;
   }
   res.Dump();
   string r = "";
   for( int i =0; i<res.Length; i++){
       r += res[i];
   }
}
// You can define other methods, fields, classes and namespaces here
