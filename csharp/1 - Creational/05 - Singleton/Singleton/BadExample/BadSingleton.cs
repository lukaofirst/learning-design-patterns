namespace Singleton.BadExample
{
	public sealed class BadSingleton
	{
		private static BadSingleton _instance = null!;

		public BadSingleton() { }

		public static BadSingleton Instance
		{
			get
			{
				if (_instance is null)
				{
					_instance = new BadSingleton();
				}

				return _instance;
			}
		}
	}
}