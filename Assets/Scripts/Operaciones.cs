using UnityEngine;
using System.Collections;

public class Operaciones : MonoBehaviour {
	int counter;
	void Start(){
		// Operadores numericos: retornan un valor numerico
		// suma + (ej 2+4 retorna 6)
		// resta - (ej 3-5 retorna -2)
		// multiplicacion * (ej 2*3 retorna 6)
		// division / (ej 5/3 retorna 1)
		// modulo % (ej 5%3 retorna 2)

		// Operadores logicos: retornan un valor de verdad (true o false)
		// and &&
		// or ||
		// not !
		// equal ==
		// not equal !=
		// less than <
		// more than >
		// less or equal <=
		// more or equal >=

		//inicializacion del contador
		counter = 0;
		//condicion
		while(counter <= 100){
			//inicio ciclo
			Debug.Log("counter vale "+ counter);
			//termino del ciclo

			//incremento
			counter++;
		}

		for(counter = 0; counter <= 100; counter++){
			Debug.Log("counter vale "+ counter);
		}

		Debug.Log("termine");
	}
}
