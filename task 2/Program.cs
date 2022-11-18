#region Parse, TryParse
//int num1;
//string numSt = Console.ReadLine();
////int num2 = int.Parse(numSt);
////Console.WriteLine(num2);

//bool num2 = int.TryParse(numSt, out num1);
//if (num2 == true)
//{
//    Console.WriteLine(num1);
//}
//else
//{
//    Console.WriteLine("Please enter valid number");
//} 
#endregion

#region Ref and Out
//int num1 = 5;
//int num2 = num1 ;
//Number(ref num2);
//Console.WriteLine(num1);
//static void Number(ref int num2) // out = ref
//{
//    num2 = 25;
//    Console.WriteLine(num2);
//} 

//int[] arr1 = { 1, 2, 3, 4, 5, 6 };
//Array1(ref arr1);

//foreach (var item in arr1)
//{
//    Console.WriteLine(item);
//}

//static void Array1(ref int[] arr1)
//{
//    arr1 =new int[] {7,8,9,10};
//    foreach (var item in arr1)
//    {
//        Console.WriteLine(item);
//    }
//}
#endregion

#region Array's Method
//int[] arr = { 1, 2, 3, 4, 5, 6 };
//int[] arr2 = new int[10];

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}


//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
//int[] arr2 = new int[5]; //{0,0,0,0,0}

//for (int i = 0; i < arr2.Length; i++)
//{
//    arr2[i] = i;
//    Console.WriteLine(arr2[i]);
//}

//foreach (var item in arr)
//{
//    Array.Clear(arr, arr[3],2); //1)arrayin adi. 2)hansi indexden sonra silinsin. 3) Uzunluq hara qeder silinsin.
//    Console.WriteLine(item);
//}

//int[] arr3 = (int[])arr.Clone(); // arrayname.Clone();
//arr[0] = 10000;
//foreach (var item in arr3)
//{
//    Console.WriteLine(item);
//}

//int[] arr1 = { 1, 2, 3, 4, 5, 6,7,8,9,10}; //Array.Copy
//int[] arr2 = new int[10];
//Array.Copy(arr1,4, arr2,3, 4); //1)copyalanan array. 2)hansi indexden baslayib copy etsin. 3) haraya copy etsin. 4)nece index sonra paste olunsun. 5) Length
//foreach (var item in arr2)
//{
//    Console.WriteLine(item);
//}

//Array doubleArr = Array.CreateInstance(typeof(double), 5);
//Console.WriteLine(doubleArr);

//string kamran1 = "Kamran Zeynalov";
//string kamran2 = "Kamran Zeynalov";
//Console.WriteLine(kamran1.Equals(kamran2)); //kamran1 == kamran2? True or False

//int length = arr.GetLength(0); //arrayin uzunlugunu gosterir
//Console.WriteLine(length);

//Console.WriteLine(arr.GetType());

//int index = Array.LastIndexOf(arr,5);
//Console.WriteLine("Yazilanin ededin indexi " + index + "-dir");

//Array.Sort(arr);

//Array.Reverse(arr, 0, 6);
//foreach (var item in arr)
//{
//    Console.WriteLine(item); // ters cevirir
//}

//Array.Resize(ref arr, arr.Length +2);
//arr[6] = 7;
//arr[7] = 8;

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

#endregion

#region String methods and StringBuilder
using System.Text;
using task_2;

//string str1 = "Salam Kamran Zeynalov";

//string remove = str1.Remove(14,7);
//Console.WriteLine(remove);

//string replace = str1.Replace("Kamran", "Kamal");
//Console.WriteLine(replace);

//char[] carr = str1.ToCharArray();

//foreach (var item in carr)
//{
//    Console.WriteLine(item);
//}

//string str2 = str1.Substring(0,14);
//Console.WriteLine(str2);

//Console.WriteLine(str1.ToLower()); // or ToUpper

//string str2 = "cola, tea, fanta, sprite, cappy";
//string[] str3 = str2.Split(", ");
//foreach (var item in str3)
//{
//    Console.WriteLine(item);
//}

//string drinkProducts = string.Join(" ==>> ", str3);
//Console.WriteLine(drinkProducts);

//string names = String.Concat("Kamran ", "Kamal ", "Kamile ", "Kemale");
//Console.WriteLine(names.Contains("a")); //true or false
//Console.WriteLine(names.StartsWith("an"));
//Console.WriteLine(names.EndsWith("le"));

//StringBuilder builder = new StringBuilder();
//builder.AppendLine("Ho");
//builder.AppendLine("Kamran");
//builder.AppendLine("Zeynalov");
//builder.Insert(1,"ell");

//Console.WriteLine(builder);

#endregion


#region Classes
//HousePractic house = new HousePractic();
//house.room = 4;
//house.meter = 200;
//house.isRented = false;
//house.price = 20000;
//Console.WriteLine(house.room);

//HousePractic house1 = new HousePractic();
//house1.room = 2;
//house1.meter = 100;
//house1.isRented = true;
//house1.price = 12000;
//Console.WriteLine(house1.room);

//HousePractic house = new HousePractic(5, 150, false, 15000);
//Console.WriteLine(house.room);


#endregion
