namespace CSharpPlayGround
{
    class ItalianChef
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
            Console.WriteLine("Pasta is made");
        }
        public void MakePizza()
        {
            Console.WriteLine("The chef makes pizza");
            Console.WriteLine("Pizza is made");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef can not make special dish");
        }
    }
    
}