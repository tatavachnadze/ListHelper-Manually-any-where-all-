namespace MyLinq
{
	public static class ListHelper
	{
		public static IEnumerable<T> Where<T>(IEnumerable<T> list, Func<T, bool> predicate)
		{
			ValidateParameters(list, predicate);

			foreach (var item in list)
			{
				if (predicate(item))
				{
					yield return item;
				}
			}
		}

		public static bool Any<T>(IEnumerable<T> list, Func<T, bool> predicate)
		{
			ValidateParameters(list, predicate);

			return Where(list, predicate).Count() != 0;
		}

		public static bool All<T>(IEnumerable<T> list, Func<T, bool> predicate)
		{
			ValidateParameters(list, predicate);

			return Where(list, predicate).Count() == list.Count();
		}

		private static void ValidateParameters<T>(IEnumerable<T> list, Func<T, bool> predicate)
		{
			if (list == null) throw new ArgumentNullException(nameof(list));
			if (predicate == null) throw new ArgumentNullException(nameof(predicate));
		}
	}

}