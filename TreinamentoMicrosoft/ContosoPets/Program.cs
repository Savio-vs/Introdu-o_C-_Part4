// the ourAnimals array will store the following: 

using System.Data;
using System.Diagnostics;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry

int readResult = 0;
bool menuSelection = true;

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[8, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries

for (int i = 0; i < ourAnimals.GetLength(0); i++)
{
    switch(i)
    {   
        case 0:
        {
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
        }
        break;
        case 1:
        {
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
        }
        break;  
        case 2:
        {
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
        }
        break;  
        case 3:
        {
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
        }
        break;
        default:
        {
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
        }
        break;
   
    }
    
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
    
}

// display the top-level menu options
while (menuSelection )
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine(" 9. Exit");
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");
    readResult = Int32.Parse(Console.ReadLine());

    Console.WriteLine($"You selected menu option {readResult}.");
    if (readResult >= 9)
    {
        menuSelection = false;
    }
    Console.WriteLine("Press the Enter key to continue");
    Console.ReadLine();

    switch (readResult)
    {
        case 1://List all Animals Corrigir... funcionando, mas na função errada
        {
            for (int i = 0;i < ourAnimals.GetLength(0);i++)
            {   
                if (ourAnimals[i,0]!="ID #: ")
                {
                    Console.WriteLine();
                    //Exiba o valor da ID do animal de estimação e solicite ao usuário 
                    //um valor de dados atualizado caso os dados da matriz ourAnimals estejam ausentes ou incompletos.
                    while(ourAnimals[i,2] == "Age: ")
                    {
                        Console.WriteLine($"Enter the  Age of the Animal for {ourAnimals[i,0]}");
                        try{//Verifique se há um valor numérico válido atribuído a animalAge para dados atribuídos.
                            int age = Int32.Parse(Console.ReadLine());
                            ourAnimals[i,2] = $"Age: {age}";
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine($"Valor não aceito\n");
                        }
                    }    
                    
                    //Verifique se há uma cadeia de caracteres válida atribuída a animalPhysicalDescription
                    while(ourAnimals[i,4]=="Physical description: ")
                    {   
                        try 
                        { 
                            Console.WriteLine($"Enter a physical description for {ourAnimals[i,0]}");
                            var description = Console.ReadLine();
                            try
                            {
                                int inteiroDescription = Int32.Parse(description);
                                Console.WriteLine($"Enter a physical description for {ourAnimals[i,0]} (size, color, breed, gender, weight, housebroken)");
                                continue;
                            }catch(FormatException e)
                            {
                                ourAnimals[i,4] = "Physical description: " + description;
                            }
                            
                            
                            if (description == null )
                            {
                                Console.WriteLine($"Enter a physical description for {ourAnimals[i,0]} (size, color, breed, gender, weight, housebroken)");
                                continue;
                            } else ourAnimals[i,4] = "Physical description: " + description;

                        }catch(FormatException e)
                        {
                            Console.WriteLine($"Enter a physical description for {ourAnimals[i,0]} (size, color, breed, gender, weight, housebroken)");    

                        }

                    }
                //Imprimir os dados já existentes.
                Console.WriteLine(ourAnimals[i,0]);
                Console.WriteLine(ourAnimals[i,1]);
                Console.WriteLine(ourAnimals[i,2]);
                Console.WriteLine(ourAnimals[i,3]);
                Console.WriteLine(ourAnimals[i,4]);
                Console.WriteLine(ourAnimals[i,5]);
                }
                
            }    

            
        }break;
        
        case 2:// Add new animal
        {
            int line = ourAnimals.GetLength(0);
    
            string[,] newOurAnimals = new string[line+1,6]; 
            Console.Clear();
            for (int i = 0;i < newOurAnimals.GetLength(0);i++)
            {   
                if (ourAnimals.GetLength(0)-1< i)
                {   
                    
                    Console.Write("Enter the Species of the Animal:");
                    animalSpecies = Console.ReadLine();
                    Console.Clear();

                    Console.Write("Enter the ID of the Animal:");
                    animalID = Console.ReadLine();      Console.Clear();  
                    
                    do{
                    Console.Write("Enter the Age of the Animal:");
                    animalAge = Console.ReadLine();
                    }while(animalAge=="");      Console.Clear();
                    
                    do{
                    Console.Write("Enter the Physical Description of the Animal:");
                    animalPhysicalDescription =Console.ReadLine();
                    }while(animalPhysicalDescription=="");      Console.Clear();
                    
                    do{
                    Console.Write("Enter Animal Personality Description:");
                    animalPersonalityDescription = Console.ReadLine();
                    }while(animalPersonalityDescription=="");   Console.Clear();

                    do{
                    Console.Write("Enter the Nickname of the Animal:");
                    animalNickname = Console.ReadLine();
                    }while(animalNickname=="");     Console.Clear();
                    
                    for(int j = 0;j<6;j++)
                    {
                        newOurAnimals[i, 0] = "ID #: " + animalID;
                        newOurAnimals[i, 1] = "Species: " + animalSpecies;
                        newOurAnimals[i, 2] = "Age: " + animalAge;
                        newOurAnimals[i, 3] = "Nickname: " + animalNickname;
                        newOurAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                        newOurAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                    }
                    continue;
                }
                for (int j = 0;j<newOurAnimals.GetLength(1);j++)
                {
                    newOurAnimals[i,j] = ourAnimals[i,j];
                }
                
            }
         
            ourAnimals = newOurAnimals;
            
            Console.WriteLine($"nova quantidade de linhas de ourAnimals: {ourAnimals.GetLength(0)}");
            
        }
            
        break;
        
        case 4://Garantir que os apelidos dos animais de estimação e suas descrições de personalidade estejam preenchidos
        {
            for(int i = 0;i<ourAnimals.GetLength(0);i++)
            {
                if (ourAnimals[i,0] != "ID #: ")
                {   
                    while(ourAnimals[i,3] =="Nickname: ")
                    {
                        Console.WriteLine($"Enter a nickname for {ourAnimals[i,0]}");
                        string nickName = Console.ReadLine();

                        if (nickName == null){
                            continue;
                        }else ourAnimals[i,3]= "Nickname: " + nickName;

                    }

                    while(ourAnimals[i,5]== "Personality: ")
                    {
                        Console.WriteLine($"Enter a personality description for {ourAnimals[i,0]} (likes or dislikes, tricks, energy level)");
                        string personality = Console.ReadLine();

                        if (personality == null){
                            continue;
                        }else ourAnimals[i,5]= "Personality: " + personality;

                    }
                }
                Console.WriteLine("Nickname and personality description fields are complete for all of our friends.\n");

            }
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            
        }
        break;
        case 5:// Edit Age the Pet
        {   
            Console.Write("Read the Nickname in your pet:");
            string namePet = Console.ReadLine();
            for (int i = 0;i<ourAnimals.GetLength(0);i++)// percorrer cada linha da matriz
            {   
                if (ourAnimals[i,3].Contains(namePet))
                {   
                    Console.WriteLine($"Read the new age to your pet: ");
                    ourAnimals[i,2] = "Age: " + Console.ReadLine();


                    continue;
                }

            }   
        }break;    
        
        case 6:// Edit Personality the Pet
        {
            Console.Write("Read the Nickname in your pet:");
            string namePet = Console.ReadLine();
            
            for (int i = 0;i<ourAnimals.GetLength(0);i++)// percorrer cada linha da matriz
            {   
                if (ourAnimals[i,3].Contains(namePet))
                {   
                    Console.WriteLine($"Read the new Personality to your pet: ");
                    ourAnimals[i,5] = "Personality: " + Console.ReadLine();
                    
                    continue;
                }

            }   
        }break;
        
        case 7:// List all's cat's
        {
            for (int i = 0;i<ourAnimals.GetLength(0);i++)
            {
                for(int j = 0;j<ourAnimals.GetLength(1);j++)
                {
                    if (ourAnimals[i,1].Contains("cat"))
                    {
                        Console.WriteLine("" + ourAnimals[i,j]);
                        Console.WriteLine("\n");
                    }
                }
                
            }
        }break;
        
        case 8:// List all's dog's
        {
            for (int i = 0;i<ourAnimals.GetLength(0);i++)
            {
                for(int j = 0;j<ourAnimals.GetLength(1);j++)
                {
                    if (ourAnimals[i,1].Contains("dog"))
                    {
                        Console.WriteLine("" + ourAnimals[i,j]);
                        Console.WriteLine("\n");
                    }
                }
                
            }
        }break;
        default:
        {   
            Console.WriteLine("Critical Error!!!!\n Bye Bye...");
        }break;
    }
    Console.ReadLine();
}




// pause code execution

