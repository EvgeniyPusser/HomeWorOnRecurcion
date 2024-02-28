// // // A (m, n) = (n + 1), if(m = 0);
// // // A (m, n) = A(m - 1, 1), if (m > 0, n = 0);
// // // A (m, n) = A(m - 1, A(m, n - 1)), if (m > 0, n > 0);

// void Main()
// {   
    
// int a = Input("Введите первое натуральное число: ");
// int b = Input("Введите второе натуральное число: ");

// int result = AckermannFunction(a, b);
// Console.Write(result);
// }

// int AckermannFunction(int m, int n){
//   if(m > 0 && n > 0)
//   {Console.Write("m and n > 0");
//    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//   }
 
//   else if(m > 0 && n == 0)
//   {Console.Write("n = 0");
//     return AckermannFunction(m - 1, 1);
//   }
//   else
//  {
//      return n + 1;
//   }
        
//  }

     

// int Input(string message)
// {
// Console.Write(message);
// return Convert.ToInt32(Console.Read());
// }

// Main();
// void Main(){
//    for (long m = 0; m <= 3; ++m)
//    {
//     for( long n = 0; n <= 4; ++n)
//       {
//       Console.WriteLine(Ackermann(m, n));
//       Ackermann(m, n);
//     }
//    }
//    }


// long Ackermann(long m, long n){
//   if(m > 0)
//       {
//         if(n > 0)
            
//             return Ackermann(m - 1, Ackermann(m, n - 1));
            
//         else if(n == 0)
        
//         return Ackermann(m - 1, 1);
        
//   else if(m == 0)
//   {
//     if(n >= 0)
       
//        return n + 1;
       
//   }
 
 
//   }  return 0;
//   //System.ArgumentOutOfRangeExeption();
//   }
  

//   Main(

// void  Button1Click(object sender, EventArgs e)
//         {
//             var t = Ackermann(4,2);
//             Console.Write(t);

//             label1.Text += string.Format(": {0}", t);
//             label1.Visible = true;
//         }

        int Ackermann(uint m, uint n)
        {
            if (m == 0)
                return  (int) (n+1);
            if (m > 0 && n == 0)
                return Ackermann(m - 1, 1);
            if (m > 0 && n > 0)
                return Ackermann(m - 1, (uint)Ackermann(m, n - 1));
            else
            {
                return -1;
            }
        }
        int result = Ackermann(0,1);
        Console.Write(result);
        Console.Write("\n");