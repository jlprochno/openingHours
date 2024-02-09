namespace openingHours;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, por gentileza, insira a hora: ");
            int hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Olá, por gentileza, insira os minutos: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

        if(hours <= 7 && hours <= 23){
            if((hours >= 7 && minutes <30) || (hours == 23 && minutes > 10))
            Console.WriteLine("Desculpa, mas a entrada não será permitida!");
        }
        else Console.WriteLine("Seja bem-vindo! Entrada permitida!");        
    }
}
