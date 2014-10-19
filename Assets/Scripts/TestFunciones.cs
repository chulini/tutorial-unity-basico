using UnityEngine;
using System.Collections;

public class TestFunciones : MonoBehaviour {
	void Start () {
		SayHi();
		Debug.Log(Suma(1,2));
	}

	void SayHi(){
		Debug.Log("Hola!");
	}

	int Suma(int a, int b){
		int temp;
		temp = a + b;
		return temp;
	}
}
