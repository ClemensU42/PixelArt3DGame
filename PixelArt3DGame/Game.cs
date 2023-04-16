using System.Runtime.InteropServices;
using OpenTK.Graphics.OpenGL;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace PixelArt3DGame;

public class Game : GameWindow
{

	public Game(int width, int height, string title) : base(GameWindowSettings.Default, new NativeWindowSettings() { Size = (width, height), Title = title })
	{
		
	}

	protected override void OnUpdateFrame(FrameEventArgs args)
	{
		base.OnUpdateFrame(args);

		KeyboardState input = KeyboardState;

		if (input.IsKeyDown(Keys.Escape))
		{
			Close();
		}
	}

	protected override void OnRenderFrame(FrameEventArgs args)
	{
		base.OnRenderFrame(args);

		GL.Clear(ClearBufferMask.ColorBufferBit);
		
		GL.ClearColor(0.5f, 0.3f, 0.2f, 1.0f);
		
		SwapBuffers();
	}

	protected override void OnResize(ResizeEventArgs e)
	{
		base.OnResize(e);
		
		GL.Viewport(0, 0, e.Width, e.Height);
	}
}