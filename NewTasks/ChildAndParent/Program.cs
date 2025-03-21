using ParentAndChild;

class Program
{
    
    public static void Main(string[] args)
    {
        Child[] children = new Child[10];
        children[0] = new Child("John", 6, new Parent("Alexandr", 30, 16000), new Parent("Betty", 26, 6500));
        children[1] = new Child("Janice", 7, new Parent("Juan", 33, 6000), new Parent("Alice", 30, 4800));
        children[2] = new Child("Casey", 6, new Parent("Howard", 30, 6400), new Parent("Brenda", 25, 13000));
        children[3] = new Child("Morgan", 8, new Parent("Scott", 35, 17000), new Parent("Carol", 29, 13000));
        children[4] = new Child("Taylor", 10, new Parent("Jeffrey", 30, 9500), new Parent("Diane", 30, 5000));
        children[5] = new Child("Blake", 4, new Parent("Raymond", 26, 6500), new Parent("Esther", 24, 3900));
        children[6] = new Child("Jordan", 2, new Parent("Dennis", 25, 7200), new Parent("Frances", 25, 9800));
        children[7] = new Child("Rowan", 11, new Parent("Oscar", 35, 20000), new Parent("Gloria", 30, 7600));
        children[8] = new Child("Blake", 7, new Parent("Kenneth", 30, 17000), new Parent("Helen", 26, 4600));
        children[9] = new Child("Quinn", 12, new Parent("Clifford", 36, 3400), new Parent("Irene", 30, 3300));

    // Printing Children whos parents age in sum is less than 70

        foreach (Child child in children)
        {
            if (child.GetParentsAge() < 70)
            {
                child.Display();
            }
        }

    // Finding oldest Child's Father's salary

        Child oldest = children[0];

        for (int i = 1; i < children.Length; ++i)
        {
            if (children[i].Age > oldest.Age)
            {
                oldest = children[i];
            }    
        }

        Console.WriteLine("The Oldest Child");
        oldest.Display();
        Console.WriteLine($"The Oldest Child's Father's Salary ${oldest.GetFatherSalary()}");
    
    // Finding the richest Child

        oldest = children[0];

        for (int i = 1; i < children.Length; ++i)
        {
            if (children[i].GetProfit() > oldest.GetProfit())
            {
                oldest = children[i];
            }
        }

        Console.WriteLine("The Richest Guy");
        oldest.Display();
    
    //Swaping Oldest and Youngest Children

        int maxid = 0;
        int minid = 0;

        

        for (int i = 1; i < children.Length; ++i)
        {
            if (children[i].Age > children[maxid].Age)
            {
                maxid = i;
            }
        }
    
        for (int i = 1; i < children.Length; ++i)
        {
            if (children[i].Age < children[minid].Age)
            {
                minid = i;
            }
        }

        Child tmp = children[maxid];
        children[maxid] = children[minid];
        children[minid] = tmp;


        for (int i = 0; i < children.Length; ++i)
        {   
            Console.WriteLine($"Child {i + 1})");
            children[i].Display();
        }


    }
}