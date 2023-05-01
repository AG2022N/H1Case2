while (true)
{
    Console.Clear();
    Console.Write(" Tast 1 for at søge efter lærere: \n" +
                  " Tast 2 for at søge efter elever: \n" +
                  " Tast 3 for at søge efter fag:");
    Console.SetCursorPosition(1, 5);
    Console.Write("Vælg: ");
    int UserChoice; bool UserChoiceParse = Int32.TryParse(Console.ReadLine(), out UserChoice);
    string SearchString;
    switch (UserChoice)
    {
        case 1:
            //Lærer
            Console.Write(" Indtast et navn: ");
            SearchString = Console.ReadLine();




            break;
        case 2:
            //Elev
            SearchString = Console.ReadLine();


            break;
       case 3:
            //Fag
            SearchString = Console.ReadLine();


            break;
       default:
            Console.Write("Ugyldig input, prøv igen:");
            break;
    }
    Console.ReadKey();
}