// shoot shapes from camera and click position

using UnityEngine;
using System.Collections;

//attributions
[RequireComponent(typeof(Camera))]
public class ballShooter : MonoBehaviour {

	public GameObject Pellet;
	public float shootForce;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){

			var camera = this.gameObject.GetComponent<Camera>();
			//takes position on screen and converts to ray
			var ray = camera.ScreenPointToRay(Input.mousePosition);



			GameObject pellet = Instantiate(this.Pellet);
			pellet.transform.position = this.gameObject.transform.position;
			pellet.transform.localScale = (Random.value * 10) * Vector3.one;

			var pelletRigidBody = pellet.GetComponent<Rigidbody>();
			pelletRigidBody.AddForce(shootForce * ray.direction);
		}
	
	}
}
