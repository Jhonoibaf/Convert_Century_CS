// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Centuries
{
    //clase para evaluar a que siglo pertenece el año:
    public string GetCentury(int year)
    {
        if((year>=1) && (year <=2005))
        {
            decimal getDecimalOfCentury = year / 100.0m;
            return Math.Ceiling(getDecimalOfCentury).ToString();   
        }
        return "The number year is out of range";
    }

    // imprimir resultado
    class Result : Centuries
    {
        static void Main()
        {
            int count = 0;
            while(count++ < 10)
            {
                int year;
                Console.WriteLine("enter year to calculate century");
                year = int.Parse( Console.ReadLine() );
                Result century = new Result();
                string numberOfCentury = century.GetCentury(year);
                Console.WriteLine(numberOfCentury);
            }
        }
    }
}