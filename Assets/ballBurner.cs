//destroy shapes when below DeathYValue ... otherwise never dies

using UnityEngine;
using System.Collections;

public class ballBurner : MonoBehaviour {

	//create an input variable to cut off objects
	public float DeathYValue = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// access gameobjecy position - test against deathvalue
		if (this.gameObject.transform.position.y < this.DeathYValue){
			//unity method to destroy game objects
			Destroy(this.gameObject);
		}
	
	}
}
