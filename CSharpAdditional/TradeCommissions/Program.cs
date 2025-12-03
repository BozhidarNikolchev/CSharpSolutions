string city = Console.ReadLine();
double sales = Double.Parse(Console.ReadLine());

double comission = 0.0;

if (sales < 0)
{
    Console.WriteLine("error");
}
else
{

    switch (city)
    {
        case "Sofia":

            if (sales >= 0 && sales <= 500)
            {
                comission = sales * 0.05;
            }
            else if (sales > 500 && sales <= 1000)
            {
                comission = sales * 0.07;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                comission = sales * 0.08;
            }
            else
            {
                comission = sales * 0.12;
            }

            Console.WriteLine($"{comission:f2}");
            break;

        case "Varna":

            if (sales >= 0 && sales <= 500)
            {
                comission = sales * 0.045;
            }
            else if (sales > 500 && sales <= 1000)
            {
                comission = sales * 0.075;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                comission = sales * 0.10;
            }
            else
            {
                comission = sales * 0.13;
            }

            Console.WriteLine($"{comission:f2}");
            break;

        case "Plovdiv":

            if (sales >= 0 && sales <= 500)
            {
                comission = sales * 0.055;
            }
            else if (sales > 500 && sales <= 1000)
            {
                comission = sales * 0.08;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                comission = sales * 0.12;
            }
            else
            {
                comission = sales * 0.145;
            }

            Console.WriteLine($"{comission:f2}");
            break;

        default:
            Console.WriteLine("error");
            break;
    }
}


