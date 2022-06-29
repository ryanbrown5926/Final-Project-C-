using System;
namespace RandomFoodGen
{
    class Program
    {
        public static void Main(string[] args)
        {
            goto BeginGen;
            BeginGen: //goto statement- kind of like a loop. Program will continue to randomly generate food.
            Console.WriteLine("Can't choose what to eat? I'll help, press enter");// welcoming prompt

            
            PressEnter://goto statement
            Console.WriteLine("---------------");

           string randn = Console.ReadLine(); //waiting for the input
           RandomFoodGE();
           Console.WriteLine("Don't like my choice? Kinda rude but okay... Press Enter again");
           goto PressEnter; //returns to the begining so you can keep choosing

        }
        

        public static void RandomFoodGE()
         {
            int menu;
            int resturant;
            Random men = new Random();
            menu = men.Next(1,3);
            Random rest = new Random(); // creates a collection of numbers
            resturant= rest.Next(1, 10); //rnd.Next gets the next integer between 1-20

            switch (resturant) // setting my switches and responses
            {
                case 1:
                    Console.WriteLine("Resturant--Aliberto's jr");
                    {
                        switch(menu)
                        {
                            case 1:
                            Console.WriteLine("Order-Carne Asada quesadilla");
                            break;
                            case 2:
                            Console.WriteLine("Order-Chile Relleno Burrito");
                            break;
                            case 3:
                            Console.WriteLine("Order-3 rolled Tacos");
                            break;
                            
                        }
                    }
                break;
                case 2:
                Console.WriteLine("Resturant--Ricardo's kitchen and bar");
                {
                    switch(menu)
                    {
                        case 1:
                        Console.WriteLine("Order-Crab Cake Tower");
                        break;
                        case 2:
                        Console.WriteLine("Order-Lobster Ravioli");
                        break;
                        case 3:
                        Console.WriteLine("Order-30 Day Filet Mignon");
                        break;
                    }
                break;
                }
                case 3:
                Console.WriteLine("Resturant--Jasmine Thai Lacey");
                {
                    switch(menu)
                    {
                        case 1:
                        Console.WriteLine("Order-Satay 4 Skewers");
                        break;
                        case 2:
                        Console.WriteLine("Order-Crying Tiger");
                        break;
                        case 3:
                        Console.WriteLine("Order-Rama Noodles");
                        break;
                    }
                    break;
                }
                case 4:
                Console.WriteLine("Resturant--Rod Knock Burger and Bar");
                {
                    switch(menu)
                    {
                        case 1:
                        Console.WriteLine("Order-Pulled Pork and Mac Burger");
                        break;
                        case 2:
                        Console.WriteLine("Order-Bulgogi Fries");
                        break;
                        case 3:
                        Console.WriteLine("Order-Boneless Wings");
                        break;
                    }
                }
                break;
                case 5:
                Console.WriteLine("Resturant--Curry King");
                {
                    switch(menu)
                    {
                        case 1:
                        Console.WriteLine("Order-Veggie Samosas");
                        break;
                        case 2:
                        Console.WriteLine("Order-Korma Curry");
                        break;
                        case 3:
                        Console.WriteLine("Order-Pulao Rice");
                        break;
                        
                    }
                    break;
                }
                case 6:
                Console.WriteLine("Resturant--Bulgogi Hustle");
                {
                    switch(menu)
                    {
                        case 1:
                        Console.WriteLine("Order-Bulgogi Burrito");
                        break;
                        case 2:
                        Console.WriteLine("Order-K-Combo");
                        break;
                        case 3:
                        Console.WriteLine("Order-Gangnam Style Combo");
                        break;
                        
                    }
                 break;
                }
                case 7:
                Console.WriteLine("Resturant--Pints and Quarts");
                {
                    switch(menu)
                    {
                        case 1:
                        Console.WriteLine("Order-NW Cheddar Brat");
                        break;
                        case 2:
                        Console.WriteLine("Order-P & Q Philly");
                        break;
                        case 3:
                        Console.WriteLine("Order-Fish and Skrimps Basket");
                        break;
                        
                    }
                    break;
                }
                case 8:
                Console.WriteLine("Resturant--Taco Brothers");
                {
                    switch(menu)
                    {
                        case 1:
                        Console.WriteLine("Order-Migas con Huevo");
                        break;
                        case 2:
                        Console.WriteLine("Order-Chorizo Papas & Beans tacos");
                        break;
                        case 3:
                        Console.WriteLine("Order-Huevos a la Mexicana");
                        break;
                        
                    }
                    break;
                }
                case 9:
                Console.WriteLine("Resturant--Kobito Sushi");
                {
                    switch(menu)
                    {
                        case 1:
                        Console.WriteLine("Order-Teryaki Beef");
                        break;
                        case 2:
                        Console.WriteLine("Order-California Roll & Cucumber Roll");
                        break;
                        case 3:
                        Console.WriteLine("Order-Futo Maki");
                        break;
                        
                    }
                    break;
                }
                case 10:
                Console.WriteLine("Resturant--Safuras Mediterranean Cuisine");
                {
                    switch(menu)
                    {
                        case 1:
                        Console.WriteLine("Order-Babaghanouj");
                        break;
                        case 2:
                        Console.WriteLine("Order-Western Gyro");
                        break;
                        case 3:
                        Console.WriteLine("Order-Moussaka Platter");
                        break;
                        
                    }
                    break;
                }
            }
         }
         
        }
    }
