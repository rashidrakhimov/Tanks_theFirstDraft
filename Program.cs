namespace TanksOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Field f = new Field(20, 20);
            MainHero hero = new MainHero(0, 0, 0, 0);
            Enemy e1 = new Enemy(7, 6);
            f.CreateObstacle( 4, 5); f.CreateObstacle(6, 7);
            f.CreateObstacle( 4, 6); f.CreateObstacle(7, 7);
            f.CreateObstacle( 4, 7); f.CreateObstacle(8, 7);
            f.CreateObstacle( 5, 4); f.CreateObstacle(9, 7);
            f.CreateObstacle( 6, 4); f.CreateObstacle(10,7);
            f.CreateObstacle(8, 8); f.CreateObstacle(3, 2);
            f.CreateObstacle(8, 9); f.CreateObstacle(3, 1);
            f.CreateObstacle(2, 3); f.CreateObstacle(4, 5);
            f.CreateObstacle(3, 3); f.CreateObstacle(4, 6);
            f.CreateObstacle(1, 3); f.CreateObstacle(4, 7);

     ConsoleKeyInfo key = new ConsoleKeyInfo();
            while (true)
            {
               
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        hero.SetSteps(0, 1);
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        hero.SetSteps(0, -1);
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        hero.SetSteps(1, 0);
                    }
                    else if (key.Key == ConsoleKey.UpArrow)
                    {
                        hero.SetSteps(-1, 0);
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
                else
                {
                    hero.SetSteps(0, 0);
                }               
                hero.Movement(f);
                hero.WriteDown(f);
                e1.WriteDown(f);
                f.CreateField();
                Console.Clear();
                f.ClearUp();
            }            
        }
    }
}
