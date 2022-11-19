#region Cumlenin her sozu boyuk herfle baslasin.
//Console.WriteLine("Enter a sentence:");
//string sentence = Console.ReadLine();
//string sentence2 = sentence.ToUpper();

//Console.Write("Result: ");
//Sentencee(sentence2);

//static void Sentencee(string sentence)
//{
//    for (int i = 0; i < sentence.Length; i++)
//    {
//        if (i == 0)
//        {
//            Console.Write(sentence[i]);
//            sentence = sentence.ToLower();
//            i++;
//        }
//        if (sentence[i] == ' ')
//        {
//            sentence = sentence.ToUpper();
//            Console.Write(sentence[i]);
//            i++;
//        }

//        Console.Write(sentence[i]);
//        sentence = sentence.ToLower();
//    }
//}
#endregion


#region Student Class
using Home_work_StringBuilder__Class;

Student student = new Student("Kamran", " Zeynalov");

Student student1 = new Student("Kamran", "Zeynalov", "P230", 90, true);
student1.Graduated();
student1.Points();
#endregion

