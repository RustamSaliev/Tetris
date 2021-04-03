using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figure s;

            while (true)
            {
                FigureFall(out s, generator);
                s.Draw();
            }

            static void FigureFall(out Figure fig, FigureGenerator generator)
            {
                fig = generator.GetNewFigure();
                fig.Draw();

                for (int i = 0; i < 15; i++)
                {
                    fig.Hide();
                    fig.Move(Direction.DOWN);
                    fig.Draw();
                    Thread.Sleep(200);
                }
            }

            /*s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.LEFT);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.DOWN);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.DOWN);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.RIGHT);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();

            //Stick t = new Stick(4, 7, '*');
            //t.Draw();

            //Point p1 = new Point(2, 3, '*');
            //p1.Draw();

            /*Point p2 = new Point()
            {
                x = 4,
                y = 5,
                c = '#'
            };

            p2.Draw();*/

            Console.ReadLine();
        }
    }
}
