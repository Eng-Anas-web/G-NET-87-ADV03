namespace Assignment_Adv03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Depart 01
            //List<int> numbers = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };
            #region Question 01
            //numbers.ForEach(n => Console.WriteLine(n));
            #endregion

            #region Question 02
            //Console.WriteLine(numbers.Count);
            #endregion

            #region Question 03
            //Console.WriteLine(numbers[0]);
            #endregion

            #region Question 04
            //Console.WriteLine(numbers[^1]);
            #endregion

            #region Question 05
            //numbers.Sort();
            //numbers.ForEach(n => Console.WriteLine(n));
            #endregion

            #region Question 06
            //int result = numbers.Find(n => n > 90);
            //Console.WriteLine(result);
            #endregion

            #region Question 07
            //List<int> resultnum = numbers.FindAll(n => n < 75);
            //resultnum.ForEach(n => Console.WriteLine($"Falling : {n}"));

            #endregion

            #region Question 08
            //numbers.RemoveAll(n => n < 75);
            //numbers.ForEach(n => Console.WriteLine(n));
            #endregion

            #region Question 09
            // bool result = numbers.Exists(n => n > 100);
            //Console.WriteLine(result);
            #endregion

            #region Question 10
            //  numbers.ToString();
            //numbers.ForEach(n => Console.WriteLine($"Grade: {n}"));
            #endregion


            #endregion

            #region Depart 02
            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [800] = "ALi",
            //    [350] = "Mona"
            //};
            #region Question 11
            //foreach(KeyValuePair<int, string> pair in leaderboard)
            //{
            //    Console.WriteLine($"{pair.Key} = {pair.Value}");
            //}
            #endregion

            #region Question 12
            //Console.WriteLine(leaderboard.First().Key);
            //Console.WriteLine(leaderboard.First().Value);
            #endregion

            #region Question 13 
            //bool result = leaderboard.ContainsKey(500);
            //Console.WriteLine(result);
            #endregion

            #region Question 14
            //Console.WriteLine(leaderboard.GetValueOrDefault(999));
            #endregion

            #region Question 15
            //leaderboard.Remove(200);
            //foreach (KeyValuePair<int, string> pair in leaderboard)
            //{
            //    Console.WriteLine($"{pair.Key} = {pair.Value}");
            //}
            #endregion
            #endregion

            #region Depart 03
            //Dictionary<string , string> phoneBook = new Dictionary<string, string>()
            //{
            //    ["Ahmed"] =" 01009429435",
            //    ["Anas"] = "01019510963",
            //    ["Mohamed"] = "01108865123",
            //    ["Amira"] = "01062108045"
            //};
            #region Question  16
            //phoneBook["Mahmoud"] = "0100850546410";
            #endregion

            #region Question 17
            //try
            //{
            //    phoneBook.Add("Ahmed", "01009429435");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            #endregion

            #region Question 18
            //bool res = phoneBook.TryAdd("Ahmed", "01009429435");
            //if(res == true)
            //{
            //    Console.WriteLine("Add succesfull");
            //}
            //else
            //{
            //    Console.WriteLine("Faild");
            //}
            #endregion

            #region Question 19
            //bool res = phoneBook.ContainsKey("Ali");
            //if(res == true)
            //{
            //    Console.WriteLine("Found");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}
            #endregion

            #endregion

            #region Depart 04

            #region Question 20
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com",
            //    "AHMED@test.com",
            //    "sara@test.com",
            //    "Sara@Test.Com"
            //};
            //The count is 2 because StringComparer.OrdinalIgnoreCase treats uppercase and lowercase letters as the same.
            #endregion

            #region Question 21
          //  HashSet<int> setA = new HashSet<int>() { 1, 2, 3, 4, 5 };
          //  HashSet<int> setB = new HashSet<int>() { 4, 5, 6, 7, 8 };

          //  HashSet<int> result = new HashSet<int>(setA);
          //  result.UnionWith(setB);

          //  foreach (var num in result)
          //  {
          //      Console.WriteLine(num);
          //  }
          //  Console.WriteLine("================================================");
          //  result.IntersectWith(setB);
          //  foreach (var num in result)
          //  {
          //      Console.WriteLine(num);
          //  }
          //  Console.WriteLine("================================================");
          //result.ExceptWith(setA);
          //  foreach (var num in result)
          //  {
          //      Console.WriteLine(num);
          //  }
          //  Console.WriteLine("================================================");
          //  bool res = result.IsSubsetOf(setB);
          //  Console.WriteLine(res);
            #endregion

            #endregion
        }
    }
}
