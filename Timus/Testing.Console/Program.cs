namespace Testing.Console {

    public class Program {

        public static void Main(string[] args) {
            var totalStr = System.Console.ReadLine();
            var total = int.Parse(totalStr);
            for (int i = 0; i < total; i++) {
                var lineStr = System.Console.ReadLine();
                var lineValues = lineStr.Split(new[] { ' ' });
                System.Console.WriteLine(int.Parse(lineValues[0]) + int.Parse(lineValues[1]));
            }
        }
    }
}