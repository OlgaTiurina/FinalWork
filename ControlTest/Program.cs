
string[] mymassive = new string[4] {"777", "hi", "hello", "324"};
DecisionTask(mymassive);

void DecisionTask(string[] mymassive)
{
    Console.Write("[ ");
    for (int i = 0; i < mymassive.Length; i++)
    {
        if(mymassive[i].Length <= 3)
        {
            Console.Write($"{mymassive[i]} ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}
