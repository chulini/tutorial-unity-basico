using UnityEngine;
using System.Collections;

public class SelfDestroyDelayed : MonoBehaviour {
	public float delay;

	void Start(){
		StartCoroutine(DestroyDelayed());
	}
	IEnumerator DestroyDelayed(){
		yield return new WaitForSeconds(delay);
		Destroy(gameObject);
	}
}
