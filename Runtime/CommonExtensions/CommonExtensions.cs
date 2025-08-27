using System;
using System.Collections.Generic;

namespace Aklgupta.Utils.CommonExtensions {
	public static class CommonExtensions {

		private static readonly Random random = new();

		public static T Random<T>(this IList<T> list) {
			if (list == null || list.Count == 0)
				return default;

			return list[random.Next(list.Count)];
		}
		
	}
}