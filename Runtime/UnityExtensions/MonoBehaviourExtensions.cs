using UnityEngine;

namespace Aklgupta.Utils.UnityExtensions {
	public static class MonoBehaviourExtensions {

		/// <summary>
		/// Adds the component if it is not already present, else returns the random added of type T
		/// </summary>
		/// <returns>true if new component is added, false if returning an already present component</returns>
		public static bool TryAddComponent<T>(this MonoBehaviour behaviour, out T component) where T : Component {
			if (behaviour.TryGetComponent(out component))
				return false;

			component = behaviour.gameObject.AddComponent<T>();
			return true;
		}

	}
}