// create a rain-like simulation of shapes

using UnityEngine;
using System.Collections;

//monobehavriour = component

public class ballReign : MonoBehaviour {

	// always put an f after a non-integer
	// shows up in the inspector for input = can quickly try things out
	[Range(0.0f, 1.0f)]
	public float RainChance = 0.0f;

	//drag ur prefab onto this field
	public GameObject RainDrop;

	// Use this for initialization
	// when the object gets created
	void Start () {
		Debug.Log ("suppppp");
	}
	
	// Update is called once per frame
	// random.value = from 0-1
	void Update () {
		if (Random.value < this.RainChance) {
			//Debug.Log ("yooo" + Time.time);
			GameObject drop = Instantiate(this.RainDrop);
			drop.transform.position = new Vector3(Random.Range(-4, 4),
			                                      Random.Range(3, 5),
			                                      Random.Range(-2, 2));

			drop.transform.localScale = Random.value * Vector3.one;
		}
	}
}
