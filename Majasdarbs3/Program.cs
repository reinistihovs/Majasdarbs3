using System;
using System.Threading.Tasks;

namespace Majasdarbs3
{
    class Program
    {
        static void Main(string[] args)
        {



///########### 1. uzdevums ########
///


            var phone = new phone();
            phone.Model = "3310";
            phone.Manufacturer = "Nokia";
            phone.Lengh = 10.22;
            phone.width = 4.44;
            phone.Thikness = 5;
            string smstxt = phone.SendSms();
            Console.WriteLine($"1. uzdevums: Sūtīt SMS");
            Interactive.PressToContinue();
            Console.WriteLine(smstxt);
            Console.WriteLine($"1. uzdevums: zvanīt");
            Interactive.PressToContinue();
            phone.MakeCall();
            
            ///########### 2. uzdevums ########
            ///
            var car = new car();
            car.model = "Octavia";
            car.manufacturer = "Skoda";
            car.topspeed = 220;
            car.licencePlate = "KP8833";
            Console.WriteLine($"2. uzdevums: auto");
            Interactive.PressToContinue();
            Console.WriteLine($"Heres {car.manufacturer} {car.model}s HORN sound..");
            car.PressHorn();
            Console.WriteLine($"Lets test {car.manufacturer} {car.model}s top speed.. it should be {car.topspeed}");
            Interactive.PressToContinue();
            Sounds.speedup();

            int speedometer = (car.topspeed / 10);
            int addspeed = (car.topspeed / speedometer);
            int speed = addspeed;

            for (int i = 0; i < speedometer; i++)
            {
                Parallel.Invoke
                (
                    () => Sounds.speedup(),
                    () => Console.WriteLine($"{speed}"),
                    () => speed = speed + addspeed
                ); ;
            }

            /////### 3. uzevms
            ///

            var ThingForSale = new ThingForSale();
            ThingForSale.name = "Ruskij standart 1L 40%";
            ThingForSale.type = "Alcohol";
            ThingForSale.isAlcohol = true;
            ThingForSale.alcoholcontent = 40;
            ThingForSale.price = 10.22;
            ThingForSale.liters = 1;
            ThingForSale.shelfLocation = 1337;
            ThingForSale.instock = true;
            Console.WriteLine($"3. uzdevums: prece");
            Console.WriteLine($"Please enter products {ThingForSale.name} dimensions");
            Console.WriteLine($"Enter width and press Enter");
            ThingForSale.width = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Enter lengh and press Enter");
            ThingForSale.lengh = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Enter width and press Enter");
            ThingForSale.height = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Please enter products {ThingForSale.name} dimensions again, to verify,  \nthat its only possible  to set dimmensions for the first time.");
            Console.WriteLine($"Enter width and press Enter");
            ThingForSale.width = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Enter lengh and press Enter");
            ThingForSale.lengh = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Enter width and press Enter");
            ThingForSale.height = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Current dimmensions for {ThingForSale.name} is {ThingForSale.width} x {ThingForSale.height} x {ThingForSale.lengh}");

            ////########### 4. ########

            var person = new Person();
            Console.WriteLine($"4. uzdevums: Sveiceins");
            Console.WriteLine($"ČAU! Kā tevi sauc?");
            person.Name = Console.ReadLine();
            Console.WriteLine($"cik tev pilni gadi?");
            person.Age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Kāds ir tavs dzimums? 1- Vīrietis , 2-Sieviete");
            int SEX = int.Parse(Console.ReadLine());
            if (SEX == 1)
            {
                person.IsMale = true;
            }
            else if (SEX == 2)
            {
                person.IsMale = false;
            }
            Console.WriteLine($"kāds ir tavs hobbijs?");
            person.hobby = Console.ReadLine();

            if (person.IsMale == true)
            {
                Console.WriteLine($"Sveiks! {person.Name}, tu esi vīrietis un tev ir {person.Age} gadi, \ntev patīk {person.hobby}");
            } else
            {
                Console.WriteLine($"Sveika! {person.Name},tu esi sieviete un tev ir {person.Age} gadi, \ntev patīk {person.hobby}");
            }








        }

    }
}
