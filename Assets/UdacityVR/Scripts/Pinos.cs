using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pinos : MonoBehaviour {
	
	public Text texto;
	public Text texto1;
	public Text texto2;
	bool choco=true;
	int puntaje=0;
	string numero="";
	int Snumero=0;
	bool Schoque=false;

	[SerializeField]
	private AudioSource audioSource = null;

	[Header("Sounds")]
	public AudioClip clip1	= null;


	void OnCollisionEnter (Collision collision){
		if(choco){
			if(Schoque){
				Debug.Log(collision.gameObject.name);
				choco= false;
				numero=texto.text;
				Snumero=int.Parse(numero);
				puntaje=Snumero+10;
				texto.text=puntaje.ToString();
				audioSource.Play();

				if(puntaje==100){

					StartCoroutine(Reloj());
				}
			}
			Schoque=true;
		}
		
	}

	IEnumerator Reloj(){
		Debug.Log("llegamos bien");
		yield return new WaitForSeconds(5);
		texto1.text="Felicidades";
		texto2.text="Has Ganado";
		texto.text="Jugar De nuevo";
	}
}
