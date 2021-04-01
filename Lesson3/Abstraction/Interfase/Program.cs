using System;

namespace Interfase
{

    //    Создайте 2 интерфейса IPlayable и IRecodable.В каждом из интерфейсов создайте по
    //    3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. 

    //Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
    //Написать программу, которая выполняет проигрывание и запись.


    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IRecodable recodable = player as IRecodable;
            recodable.Record();
            recodable.Pause();
            recodable.Stop();
            Console.WriteLine(new string('-', 50));
            IPlayable playable = player as IPlayable;
            playable.Play();
            playable.Pause();
            playable.Stop();
        }


    }

    class Player : IPlayable, IRecodable
    {
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause while playing is in progress");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause while recording is in progress");
        }

        void IPlayable.Play()
        {
            Console.WriteLine("Play while playing is in progress");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("Play while recording is in progress");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop while playing is in progress");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop while recording is in progress");
        }
    }
}
