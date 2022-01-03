namespace ExemploPOO.Models
{
    public class Professor : Pessoa 
    {
        public double Salario  { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome}, sou professor e ganho {Salario} reais.");
        }
    }
}