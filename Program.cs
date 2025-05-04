// See https://aka.ms/new-console-template for more information
//exercise from https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/create-and-run-simple-c-sharp-console-applications/add-decision-logic-to-your-code-using-if-else-and-else-if-statements-in-c-sharp
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
Console.WriteLine(daysUntilExpiration + " days");
if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration <= 5)
    {
        if (daysUntilExpiration <= 1)
        {
            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else 
            {
                Console.WriteLine("Your subscription expires within a day!");
            }
        }
        else 
        {
            Console.WriteLine($@"Your subscription expires in {daysUntilExpiration} days.");
        }
    }
    else
    {
        Console.WriteLine("");
    }

}

if (daysUntilExpiration <= 5)
{
    if (daysUntilExpiration == 1)
    {
        discountPercentage = 20;
    }
    else 
    {
        discountPercentage = 10;
    }
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
