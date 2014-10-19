using UnityEngine;
using System.Collections;

public class Auto : MonoBehaviour {
	public float position;
	public Color color;

	void MoveRight(){
		position++;
		transform.position = transform.position + Vector3.right*position;
	}

	void Update(){
		if(Input.GetMouseButton(0)){
			MoveRight();
		}
	}
}
