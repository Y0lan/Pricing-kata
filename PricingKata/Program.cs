namespace RCorpFoodPricer
{
    using System;
    using static Console;
    public class Program
    {
     
        public static void Main(string[] args)
        {
            //pour tester, lancer en ligne de commande : 
            //dotnet run -- "assiette" "couscous" "coca" "moyen" "baba" "normal" "yes"
            var price = new App().Compute(args[0],args[1],args[2],args[3], args[4], args[5], args[6]);
            Console.WriteLine($"Prix à payer : {price}€");
            
            
            //Parser.Default.ParseArguments<CommandLineOptions>(args)
                //.WithParsed(RunOptions);
               // string input = null;
               // do
                //{
                    //Console.WriteLine("Response");
                    //input = Console.ReadLine();
                    //if (input.ToLower() != "y" || input.ToLower() != "yes")
                        //break;
               // } while (true); 
               //CommandLineOptions program = new CommandLineOptions(); 
               //program.Run();
        }
    }
}