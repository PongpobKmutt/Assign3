class Program
{
    struct CharStruct
    {
        public char c;
    }

    
    static void Main(string[] args)
    {

        
        CircularLinkedList<CharStruct> list = new CircularLinkedList<CharStruct>();

        
        while (true)
        {
           
            string input = Console.ReadLine();
            char charInput = input[0];

        
            int length = list.GetLength();

            
            if (charInput == 'G' && length >= 1 && (list.Get(length - 1).c == 'G' || list.Get(0).c == 'G'))
            {
                
                if (length >= 3 && list.Get(length - 2).c == 'G' && list.Get(length - 3).c == 'G')
                {
                    Console.WriteLine("Invalid pattern.");
                }
                
                else if (length >= 4 && list.Get(0).c == 'G' && list.Get(1).c == 'G' && list.Get(2).c == 'G' && list.Get(3).c != 'G')
                {
                    Console.WriteLine("Invalid pattern.");
                }
                
                else if (length >= 4 && list.Get(0).c == 'G' && list.Get(length - 3).c != 'G' && list.Get(length - 2).c == 'G')
                {
                    Console.WriteLine("Invalid pattern.");
                }
               
                else
                {
                    list.Add(new CharStruct() { c = 'G' });
                }
                
                continue;
            }
            
            if (charInput == 'J' || charInput == 'G' || charInput == 'O' || charInput == 'R')
            {
                
                if (length == 0 && charInput == 'R')
                {
                    Console.WriteLine("Invalid pattern.");
                }
                
                else if (length >= 1 && list.Get(length - 1).c == 'R' && list.Get(length - 2).c == charInput)
                {
                    Console.WriteLine("Invalid pattern.");
                }
                else
                {
                    list.Add(new CharStruct() { c = charInput });
                }
               
            }
            else
            {

                for (int i = 0; i < length; i++)
                {
                    Console.Write(list.Get(i).c);
                }
                break;
            }
            
        }
        
    }
}