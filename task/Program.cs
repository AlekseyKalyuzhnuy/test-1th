


Console.Clear();
int count;
Console.WriteLine("Введите число элементов массива");
int size = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте элементы массива");

string[] array=GetArray(size);
Console.WriteLine(String.Join(", ", array));


string[] GetArray(int count)
{
    string[] array=new string [count];
    for(int i=0; i<count; i++)
    {
       array[i]= Console.ReadLine(); 
    }
    return array;
}

string [] ARRAY = GetNew(array);
string [] AR= GetReady(ARRAY);

string [] GetNew(string[] array)
{   
    string [] arra = new string [array.Length];
    int count=0;
    for ( int i=0; i<array.Length; i++)
    {
       {
           if(array[i].Length>3) continue;
           else
            arra[i]= array [i];
            count+=1;
        }
    }
    Console.WriteLine(String.Join(", ", arra));    
    Console.WriteLine(count);
    return arra;
}


string[] GetReady(string[] array)
{   
    string [] arr = new string [array.Length];
        int i=0;
        for ( int k=0; k<array.Length; k++)
       {
           if(array[k]==null)
            {
             continue;
            }
            else
            arr[i]= array [k];
            i=i+1;
        }
    
    Console.WriteLine(String.Join(", ", arr));  
    return arr;
}
