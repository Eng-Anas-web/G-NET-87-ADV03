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
            SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
            {
                [500] = "Ahmed",
                [200] = "Sara",
                [800] = "ALi",
                [350] = "Mona"
            };
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
            #endregion
        }
    }
}
