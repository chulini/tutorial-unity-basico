using UnityEngine;
using System.Collections;

public class ShootGameObject : MonoBehaviour {
	public GameObject bullet;
	public Transform shootPoint;
	public float ampShoot;
	void Update(){
		if(Input.GetMouseButtonDown(0)){
			GameObject newBullet = Instantiate(bullet,shootPoint.position,shootPoint.rotation) as GameObject;
			newBullet.rigidbody.AddForce(shootPoint.forward*ampShoot);
			audio.Play();
		}
	}
}
