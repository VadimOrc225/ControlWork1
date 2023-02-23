string[] arr = new string[] {"one", "two", "three", "four", "five", "ff"};
string[] arr2 = new string[6];
for (int x=0; x<arr.Length; x++)
{
    int count = 0;
    if (arr[x].Length<4) 
    {
       arr2[count] = arr[x];
       count++;
       Console.Write($"{arr[x]} ");
    }
}