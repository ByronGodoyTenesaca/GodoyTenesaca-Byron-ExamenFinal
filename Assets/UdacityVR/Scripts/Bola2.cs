using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola2 : MonoBehaviour {
	bool mover= false;
	bool tirar=false;
	public GameObject bola;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(tirar){
		transform.Translate(-7f* Time.deltaTime,0.0f*Time.deltaTime,0.0f*Time.deltaTime);
	}
	if(mover){
		transform.Translate(-2f* Time.deltaTime,1f*Time.deltaTime,3f*Time.deltaTime);
		 if(transform.position.x<-29.41425){
			mover=false;
			tirar=true;
		 }
	}

	if(transform.position.x < -129){
		Destroy(gameObject);
	}
	}

	public void OnbalaClicked () {
		/// Called when the 'Key' game object is clicked
		/// - Unlocks the door (handled by the Door class)
		/// - Displays a poof effect (handled by the 'KeyPoof' prefab)
		/// - Plays an audio clip (handled by the 'KeyPoof' prefab)
		/// - Removes the key from the scene

		// Prints to the console when the method is called
		//audioSource.Play();
		//Instantiate(keyPoofPrefab, transform.position, transform.rotation);
		//door.Unlock();
		//Debug.Log ("'bola 2");
		//transform.Translate(-20.02f,9.3f,7.5f);
	if(bola == null){
		mover= true;
		Update();
	}else
	{
		
	}
		
	}

	
}
