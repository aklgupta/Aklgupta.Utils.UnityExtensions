using UnityEngine;

namespace Aklgupta.Utils.UnityExtensions {
	public static class TransformExtensions {

		public static void SetWorldScale(this Transform t, Vector3 worldScale) {
			if (t.parent == null) {
				t.localScale = worldScale;
				return;
			}

			Vector3 parentScale = t.parent.lossyScale;
			t.localScale = new Vector3(
				parentScale.x == 0f ? 0f : worldScale.x / parentScale.x,
				parentScale.y == 0f ? 0f : worldScale.y / parentScale.y,
				parentScale.z == 0f ? 0f : worldScale.z / parentScale.z
			);
		}

	}
}