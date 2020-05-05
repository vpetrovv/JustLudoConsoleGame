namespace JustLudo.Renderers.Contracts
{
    using JustLudo.Board.Contracts;

    public interface IRenderer
    {
        void RenderMainMenu();

        void RenderBoard(IBoard board);
    }
}
