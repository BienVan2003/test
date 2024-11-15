namespace Mod.Plugin;

public class Paint
{
	public static void paint(mGraphics g)
	{
		mFont.tahoma_7b_red.drawString(g, "FPS: " + Main.main.max, 0, 0, 0);
	}
}
