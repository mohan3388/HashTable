using System;
using HashDemo;
public class Program
{
    public static void Main(string[] args)
    {
        HashMap<string, int> hash = new HashMap<string, int>(5);//size 5
        Console.WriteLine("Welcome to Hash Table");
        bool end = true;
        Console.WriteLine("1.Frequency Of Words in sentence \n2. Frequency Of Words In Large Paragraph Phrase \n3. End the Program\n");
        while (end == true)
        {
            Console.WriteLine("Take an option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    string words = "to be or not to be";
                    string[] arr = words.Split(' ');
                    LinkedList<string> checkForDuplication = new LinkedList<string>();
                    foreach (string element in arr) // to -> be
                    {
                        int count = 0;
                        foreach (string match in arr) //to->be->or->not->to-> be-> 
                        {
                            if (element == match)
                            {
                                count++;//1->2
                                if (checkForDuplication.Contains(element))
                                {
                                    break;
                                }
                            }
                        }
                        if (!checkForDuplication.Contains(element))
                        {
                            checkForDuplication.AddLast(element);
                            hash.Add(element, count);//(to,2)

                        }
                    }
                    hash.Display();
                    break;
                case 2:
                    string phrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    string[] arr1 = phrase.Split(' ');
                    LinkedList<string> checkDuplication = new LinkedList<string>();
                    foreach (string element in arr1)
                    {
                        int count = 0;
                        foreach (string match in arr1)
                        {
                            if (element == match)
                            {
                                count++;
                                if (checkDuplication.Contains(element))
                                {
                                    break;
                                }
                            }

                        }

                        if (checkDuplication.Contains(element))
                        {
                            continue;
                        }
                        checkDuplication.AddLast(element);
                        hash.Add(element, count);
                    }
                    hash.Display();
                    break;
                
           
                case 3:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Enter Proper Option To Execute");
                    break;
            }
        }
    }
}
