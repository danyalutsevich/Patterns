using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.State
{
    class StateDemo
    {

        public static void Show()
        {

            new Game().Update();

        }

    }

    class Game
    {
        private IGameState state;

        private List<IGameState> states;

        public IGameState State
        {
            get { return state; }
            set
            {
                state = value;
                Update();
            }
        }

        public Game()
        {
            state = new MenuState(this);
            states = new List<IGameState>();
        }

        public void Update()
        {
                state.Update();
        }

        public void Play()
        {
            foreach (var s in states)
            {
                if (s is PlayState)
                {
                    State = s;
                    return;
                }
            }
            var newState = new PlayState(this);
            states.Add(newState);
            State = newState;
        }

        public void Pause()
        {
            foreach (var s in states)
            {
                if (s is PauseState)
                {
                    State = s;
                    return;
                }
            }
            var newState = new PauseState(this);
            states.Add(newState);
            State = newState;
        }

        public void Menu()
        {
            foreach (var s in states)
            {
                if (s is MenuState)
                {
                    State = s;
                    return;
                }
            }
            var newState = new MenuState(this);
            states.Add(newState);
            State = newState;
        }

    }

    class MenuState : IGameState
    {
        private readonly Game game;

        public MenuState(Game game)
        {
            this.game = game;
        }

        public void Update()
        {
            Console.WriteLine("Menu press a key to exit menu");
            Console.ReadKey(true);
            game.Play();
        }
    }

    class PlayState : IGameState
    {
        private readonly Game game;

        public PlayState(Game game)
        {
            this.game = game;
        }

        public void Update()
        {
            Console.WriteLine("Play press a key to enter menu");
            var key = Console.ReadKey(true);
            while (true)
            {
                if (key.Key == ConsoleKey.Escape)
                {
                    game.Menu();
                    break;
                }
                else if (key.Key == ConsoleKey.P)
                {
                    game.Pause();
                    break;
                }
                else
                {
                    key = Console.ReadKey(true);
                }
            }
        }
    }

    class PauseState : IGameState
    {
        private readonly Game game;

        public PauseState(Game game)
        {
            this.game = game;
        }

        public void Update()
        {
            Console.WriteLine("Pause press a key to enter menu");
            var key = Console.ReadKey(true);

            while (true)
            {
                if (key.Key == ConsoleKey.Escape)
                {
                    game.Menu();
                    break;
                }
                else if (key.Key == ConsoleKey.P)
                {
                    game.Play();
                    break;
                }
                else
                {
                    key = Console.ReadKey(true);
                }
            }

        }
    }


    interface IGameState
    {

        void Update();

    }
}