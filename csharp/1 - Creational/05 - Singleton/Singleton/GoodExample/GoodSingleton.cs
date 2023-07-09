namespace Singleton.GoodExample
{
	public sealed class GoodSingleton
	{
		private static readonly GoodSingleton _instance = new();

		public GoodSingleton() { }

		public static GoodSingleton Instance
		{
			get
			{
				return _instance;
			}
		}
	}
}