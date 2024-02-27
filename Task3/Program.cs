// int size = 5;
int[] newAr = ArrayMake(5);
PrintArray(newAr, newAr.Length);


int[] ArrayMake(int size){
    int []array = new int[size];
    Random rand = new Random();
    
    for(int i = 0; i < size; i++){
       array[i] = rand.Next(1, 19);
      
       //Console.Write(array[i]);
       Console.Write("  ");
       
    }return array;
}

void PrintArray(int[] array,int size){
   if(size == 0){
    Console.Write(array[0]);
        return;
    }
   
   Console.Write(array[size - 1]);
   Console.Write("  ");
    
   PrintArray(array, size - 1);
}
