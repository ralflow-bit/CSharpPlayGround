namespace CSharpPlayGround
{
    class Chef : ItalianChef
    {
        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");

            Console.WriteLine("Salad is made");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes special dish");
            Console.WriteLine("Special dish is made");
        }
    }
   
}