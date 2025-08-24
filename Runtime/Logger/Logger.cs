using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Aklgupta.Utils.Logger {
	public static class Logger {

		[Conditional("UNITY_EDITOR")]
		[Conditional("UNITY_LOG")]
		public static void Log(this object source, object message) {
			Debug.Log($"{GetPrefix(source)}{message}", source as Object);
		}

		[Conditional("UNITY_EDITOR")]
		public static void LogWarning(this object source, object message) {
			Debug.LogWarning($"{GetPrefix(source)}{message}", source as Object);
		}

		[Conditional("UNITY_EDITOR")]
		public static void LogError(this object source, object message) {
			Debug.LogError($"{GetPrefix(source)}{message}", source as Object);
		}

		private static string GetPrefix(object source) {
			return $"[{source.GetType().Name}] : ";
		}

	}
}