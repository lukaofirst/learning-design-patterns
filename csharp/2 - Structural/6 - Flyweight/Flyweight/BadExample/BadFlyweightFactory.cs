using Flyweight.Common;

namespace Flyweight.BadExample
{
	public class BadFlyweightFactory
	{
		private readonly Dictionary<string, CommonFlyweight> _flyweights = new();

		public CommonFlyweight GetFlyweight(string key)
		{
			if (!_flyweights.ContainsKey(key))
			{
				_flyweights.Add(key, new CommonFlyweight(key));
			}

			return _flyweights[key];
		}
	}
}