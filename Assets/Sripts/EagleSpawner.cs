using UnityEngine;

public class EagleSpawner : MonoBehaviour
{
	[SerializeField] Eagle eagle;
	[SerializeField] Duck duck;
	[SerializeField] float initialTimer = 5;

	float timer;
	private void Start () {
		timer = initialTimer;
		eagle.gameObject.SetActive(false);
	}

	private void Update () {
		if (timer <= 0 && eagle.gameObject.activeInHierarchy == false) {
			eagle.gameObject.SetActive(true);
			eagle.transform.position = duck.transform.position + new Vector3(0,0,13);
			duck.SetMovable(false);
		}

		timer -= Time.deltaTime;
	}

	public void ResetTimer () {
		timer = initialTimer;
	}
}
