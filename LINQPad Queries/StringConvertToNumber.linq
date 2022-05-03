<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
   MyAtoi("-   234").Dump();
}
public int MyAtoi (string s)
{
    if (!IsValidInput (s))
    {
        return 0;
    }
    StringBuilder numStr = new StringBuilder();
    
    foreach (char c in s.Trim())
    {
        if (numStr.Length == 0 && c == ' ') continue;
       
        if (!"+-0123456789".Contains (c))
        {
            break;
        }
        else
        {
            if(numStr.Length >0 && (c== '+' || c=='-' || c=='.' || c== ' '))
                break;
            numStr.Append(c);
        }
    }
    if (numStr.ToString() == "" || numStr.ToString() == "+" || numStr.ToString() == "-") return 0;
    
    int temp ;
    bool result = int.TryParse (numStr.ToString(),out temp);
    if (result)
    {
        return temp;
    }
    else
    {
        if(numStr.ToString().Contains('-'))
            return int.MinValue;
        else
            return int.MaxValue;
    }
}
public bool IsValidInput (string s)
{
    //if (string.IsNullOrEmpty (s) || string.IsNullOrWhiteSpace (s)) return false;
    //bool digitFirst = true;
    //for (int i = 0; i < s.Length; i++)
    //{
    //    if (s [i] == ' ') continue;
    //    if (!"-+.0123456789".Contains (s [i]))
    //    {
    //        digitFirst = false;
    //        break;
    //    }
    //    else
    //    {
    //        digitFirst = true;
    //        break;
    //    }
    //}
    //return digitFirst;
    if (string.IsNullOrEmpty (s) || string.IsNullOrWhiteSpace (s))
        return false;
    int numIdx = s.IndexOfAny (new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
    
    if(numIdx == -1) return false;
    int symbole = 0;
    for (int i = 0; i < numIdx; i++)
    {
        if (s [i] == ' ') continue;
        if (s [i] == '.') return false;
        if (s [i] == '+' || s [i] == '-')
        {
            symbole++;
        }
        if (symbole == 2) return false;
    }
    return true;
}
// You can define other methods, fields, classes and namespaces here
