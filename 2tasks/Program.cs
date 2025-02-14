                                    /* TASK 1 */

// using System;
// class Program {
//     static void Main(string[] args) {
//         int fibo;
//         int first = 0;
//         int second = 1;
//         int current = first + second; //0,1,1,2,3,5,8

//         Console.WriteLine("enter a number: ");
//         fibo = int.Parse(Console.ReadLine());

//         if (fibo == 0 || fibo == 1) {
//             Console.WriteLine($"{fibo}");
//         }
//         while (fibo != 0) {
//             current = first + second;
//             first = second;
//             second = current;
//             --fibo;
//         }

//         Console.WriteLine("the number is {0}", current);


//     }
// }

                                    /* TASK 2 */

//using System;
//class Program {
//    static void Main(string[] args) {
//        int inputNum = 0;
//        int outputNum = 0;
//        Console.WriteLine("enter a number: ");
//        inputNum = int.Parse(Console.ReadLine());
//        while (inputNum != 0) {
//            int last = inputNum % 10;
//            outputNum = outputNum * 10 + last;
//            inputNum /= 10;
//        }
//
//        Console.WriteLine($"the reversed digit is {outputNum}");
//    }
//}

                                    /* TASK 3 */

//using System;
//
//class Program {
//    static void Main(string[] args) {
//        int input = 0;
//        Console.WriteLine("enter an integer");
//        input = int.Parse(Console.ReadLine());
//        int sum = 0;
//        while (input != 0) {
//            sum += input % 10;
//            input /= 10;
//        }
//
//        Console.WriteLine("the sum of digits is {0}", sum);
//    }
//}

                                    /* TASK 4 */

//using System;
//
//class Program {
//    static void Main(string[] args) {
//        int num = 0;
//        Console.WriteLine("enter a number");
//        num = int.Parse(Console.ReadLine());
//
//        for (int i = 1; i <= 9; ++i) {
//            Console.WriteLine($"{i} * {num} = {i * num}");
//        }
//    }
//}
                                   /* TASK 5 */

//using System;
//
//class Program {
//    static void Main(string[] args) {
//        int num = 0;
//        Console.WriteLine("enter a number");
//        num = int.Parse(Console.ReadLine());
//        if (num <= 1) {
//            Console.WriteLine($"{num} is neither prime nor composite");
//            return;
//        }
//        bool isPrime = true;
//
//        for (int i = 2; i <= num/2; ++i) {
//            if (num % i == 0) {
//                isPrime = false;
//                break;
//            }
//        }
//
//        if (isPrime) {
//            Console.WriteLine("is prime");
//        } else {
//            Console.WriteLine("isnt prime");
//        }
//    }  
//}

//                                     /* TASK 6 */
// 
// using System;
// 
// class Program {
//     static void Main(string[] args) {
//         int num;
//         Console.WriteLine("enter a positive number (excluding 0)");
//         num = int.Parse(Console.ReadLine());
//         
//         if (num <= 0) {
//             Console.WriteLine("invalid input");
//             return;
//         }
//         
//         int counter = 0;
// 
//         while (num != 1) {
//             if (num % 2 == 0) {
//                 num /= 2;
//             } else {
//                 num = 3 * num + 1;
//             }
// 
//             ++counter;
//         }
// 
//         Console.WriteLine($"it took {counter} iterations");
//     }
// }

                                    /* TASK 7 */

//using System;
//
//class Program {
//    static void Main(string[] args) {
//        int count;
//        Console.WriteLine("enter a number");
//        count = int.Parse(Console.ReadLine());
//        if (count <= 0) {
//            Console.WriteLine("invalid input");
//            return;
//        }
//            Console.Write("\n");
//
//        for (int i = 1; i <= count; ++i) {
//            for (int j = 0; j < i; ++j) {
//                Console.Write($"{i}");
//            }
//            Console.Write("\n");
//        }
//    }
//}

                                /*TASK 8*/
// using System;
// 
// class Program {
//     static void Main(string[] args) {
//         char [] uppers = {'A', 'Z', 'X', 'Y', 'Z', 'B', 'V', 'G'};
//         char [] lowers = {'a', 'z', 'x', 'y', 'z', 'b', 'v', 'g'};
//         char [] symbols = {'*', '$', '@', '#', '%', '^', '&', '?'};
//         char [] numbers = {'0', '1', '2', '3', '4', '5', '6', '7'};
//         Random rndGenerator = new Random();
//         while (true) {
//             Console.WriteLine("enter \'a\' to generate a password, \'x\' to exit");
//             char key = char.Parse(Console.ReadLine());
//             if (key == 'x') {
//                 goto exitLabel;
// 
//             } else if (key == 'a') {
//                 char[] arr = new char[8];
//                 for (int i = 0; i < 8; ) {
//                     if (i >= 8) {
//                         break;
//                     }
//                     arr[i++] = uppers[rndGenerator.Next(0,8)];
//                     if (i >= 8) {
//                         break;
//                     }
//                      arr[i++] = lowers[rndGenerator.Next(0,8)];
//                     if (i >= 8) {
//                         break;
//                     }
//                      arr[i++] = symbols[rndGenerator.Next(0,8)];
//                     if (i >= 8) {
//                         break;
//                     }
//                      arr[i++] = numbers[rndGenerator.Next(0,8)];
// 
// 
//                 }
//                 string myString = new string(arr);
//                 Console.WriteLine(myString);
// 
//             } else {
//                 Console.WriteLine("invalid input, please be attended\n");
//             }
//         }
//     
//     exitLabel:
//         Console.WriteLine("exiting...");
//     }
// }
//                              /*TASK 9*/
// using System;
// 
// class Program {
//     static void Main(string[] args) {
//         Console.WriteLine("enter a sentance");
//         string? sentance = Console.ReadLine();
//         
//         string current = "";
//         string longest = "";
//         for (int i = 0; i < sentance.Length; i++) {
// 
//             char c = sentance[i];
//             
//             if (char.IsLetterOrDigit(c)) {
//                 current += c;
//             } else {
//                 if (current.Length > longest.Length) {
//                     longest = current;
//                 }
// 
//                 current = "";
//             }
// 
//             if (current.Length > longest.Length) {
//                 longest = current;
//             }
//         }
// 
//         Console.WriteLine($"the longest world: {longest}");
//      }
// }
                                    /*TASK 10*/

// using System;
// 
// class Program {
//     static void Main(string[] args) {
//         char[,] mtx = new char[10,10];
// 
//         Random id1 = new Random();
//         Random id2 = new Random();
// 
//         mtx[id1.Next(0,10), id2.Next(0,11)] = 'X';
// 
//         for (int i = 0; i < 10; ++i) {
//             for (int j = 0; j < 10; ++j) {
//                 if (mtx[i,j] == 'X') {
//                     Console.WriteLine("\'X\' was found at mtx[{0}][{1}]", i, j);
//                     break;
//                 }
//             } 
//         }
//     }      
// }