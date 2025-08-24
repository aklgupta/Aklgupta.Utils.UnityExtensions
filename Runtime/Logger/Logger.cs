using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Aklgupta.Utils.Logger {
	public static class Logger {

		[Conditional("UNITY_EDITOR")]
		[Conditional("UNITY_LOG")]
		public static void Log(this object source, object obj) {
			Debug.Log($"Ext [{source.GetType().Name}] : {obj}", source as Object);
		}

		[Conditional("UNITY_EDITOR")]
		public static void LogWarning(this object source, object obj) {
			Debug.LogWarning($"Ext [{source.GetType().Name}] : {obj}", source as Object);
		}

		[Conditional("UNITY_EDITOR")]
		public static void LogError(this object source, object obj) {
			Debug.LogError($"Ext [{source.GetType().Name}] : {obj}", source as Object);
		}

	}
}