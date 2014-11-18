using UnityEngine;
using System.Collections;

public class BouncyCubeCollisionManager : MonoBehaviour {
	public GameObject explosionPrefab;
	int bounceCounter = 0;
	void OnCollisionEnter(Collision collision) {
		bounceCounter++;
		if(bounceCounter == 3){
			Instantiate(explosionPrefab,transform.position,transform.rotation);
			Destroy(gameObject);
		} else {
			audio.pitch = .5f + Random.value;
			audio.Play();
		}

	}
}
