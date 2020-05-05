namespace JustLudo
{
    using System;
    using JustLudo.Engine;
    using JustLudo.Renderers;
    using JustLudo.InputProviders;
    using JustLudo.Engine.Contracts;
    using JustLudo.Renderers.Contracts;
    using JustLudo.InputProviders.Contracts;
    using JustLudo.Engine.Initializations;

    public class EntryPoint
    {
        public static void Main()
        {
            IRenderer renderer = new ConsoleRenderer();
          //  renderer.RenderMainMenu();

            IInputProvider inputProvider = new ConsoleInputProvider();
            ILudoEngine ludoEngine = new StandardFourPlayerEngine(renderer, inputProvider);

            IGameInitializationStrategy gameInitializationStrategy = new StartGameInitializationStrategy();


            ludoEngine.Initialize(gameInitializationStrategy);
            ludoEngine.Start();


            Console.ReadLine();

        }
        
    }
}
