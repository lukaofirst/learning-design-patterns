using Flyweight.Common;

namespace Flyweight.GoodExample
{
	public class GoodFlyweightFactory
	{
		private readonly Dictionary<string, CommonFlyweight> _flyweights = new();
		private readonly Stack<CommonFlyweight> _recycledFlyweights = new();

		public CommonFlyweight GetFlyweight(string key)
		{
			if (_recycledFlyweights.Any())
			{
				var flyweight = _recycledFlyweights.Pop();
				_flyweights[key] = flyweight;

				return flyweight;
			}
			else if (!_flyweights.ContainsKey(key))
			{
				_flyweights.Add(key, new CommonFlyweight(key));
			}

			return _flyweights[key];
		}

		public void Recycle(CommonFlyweight flyweight)
		{
			_recycledFlyweights.Push(flyweight);
		}
	}
}