using UnityEngine;

public class Terrain : MonoBehaviour
{
	[SerializeField] GameObject tilePrefab;

	protected float horizontalSize;

	public virtual void Generate (int size) {

		horizontalSize = size;

		if (size == 0) {
			return;
		}

		if ((float)size % 2 == 0) {
			size -= 1;
		}

		int moveLimit = Mathf.FloorToInt((float)size / 2);

		for (int i = -moveLimit; i <= moveLimit; i++) {
			SpawnTile(i);
		}

		var leftBoundaryFile = SpawnTile(-moveLimit - 1);
		var rightBoundaryFile = SpawnTile(moveLimit + 1);
		
		DarkenObject(leftBoundaryFile);
		DarkenObject(rightBoundaryFile);
		
	}

	private GameObject SpawnTile(int xPos) {
		var go = Instantiate(tilePrefab, transform);
		go.transform.localPosition = new Vector3(xPos, 0, 0);
		return go;
	}

	private void DarkenObject(GameObject go) {
		var renderers = go.GetComponentsInChildren<MeshRenderer>(includeInactive: true);
		foreach (var rend in renderers) { 
			rend.material.color *= Color.grey;
		}
	}

}
