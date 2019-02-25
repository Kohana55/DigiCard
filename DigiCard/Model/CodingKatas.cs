namespace DigiCard.Model
{
    public class CodingKatas
    {

        public string header = "Coding Katas";
        public string body = "FizzBuzz: <Click Here>\n" +
                             "BubbleSort: <Click Here>";

        public FizzBuzz fizzBuzz;

        public CodingKatas()
        {
            fizzBuzz = new FizzBuzz();
        }
    }
}