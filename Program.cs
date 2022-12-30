namespace LamdaExpressionDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            LambdaDemo.AddRecords(listPersonInCity);
            LambdaDemo.RetrievingTopTwoRecordForAgelsLessThanSixty(listPersonInCity);
            LambdaDemo.CheckingForTeenagerPerson(listPersonInCity);
            LambdaDemo.AllPersonsAverageAge(listPersonInCity);
            LambdaDemo.CheckNameExistOrNot(listPersonInCity);
            Console.ReadKey();
        }
    }
}