namespace PixelArt3DGame;

static class MainClass
{
	static void Main()
	{
		try
		{
			using (Game game = new Game(640, 480, "Pixel art game"))
			{
				game.Run();
				game.Dispose();
			}
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
			Console.WriteLine(e.StackTrace);
		}
	}
}