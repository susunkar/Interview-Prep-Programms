<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    int[] array = new int[] { 4, 1, 6, 2, 5, 3, 9, 7, 8 };
    
    CreateMaxHeap(array);
    
    //MaxHeap Creation
    array.Dump();
    
    //HeapShort
    HeapShort(array);
    
    array.Dump();
}

void HeapShort (int [] array)
{
    for(int i = array.Length-1; i>=0; i--){
        Swap(0, i, array);
        shiftDown(0,i-1,array);
    }
}

void CreateMaxHeap (int [] array)
{
    int firstParent = ((array.Length-1)-1)/2;
    
    for(int i = firstParent; i>=0; i--){
        shiftDown(i,array.Length-1, array);
    }
}

void shiftDown (int current, int length, int [] array)
{
    int currentOneChild = current * 2 + 1;
    
    while(currentOneChild <= length){
        int currentSecChild = current * 2 + 2 <= length ? current * 2 + 2: -1;
        
        int IdxToSwap;
        if(currentSecChild != -1 && array[currentSecChild] > array[currentOneChild]){
           IdxToSwap = currentSecChild; 
        }
        else{
            IdxToSwap = currentOneChild;
        }
        if(array[IdxToSwap] > array[current]){
            Swap(IdxToSwap, current, array);
            current = IdxToSwap;
            currentOneChild = current * 2 +1;
        }
        else{
            return;
        }
    }
}

void Swap (int i, int j, int [] array)
{
    int temp = array [i];
    array [i] = array [j];
    array [j] = temp;
}

// Define other methods, classes and namespaces here
