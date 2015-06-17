// shapes will cluster together

using UnityEngine;
using System.Collections;

public class ballHugger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		var otherGo = collision.gameObject;

		if (otherGo.layer != this.gameObject.layer){
			return;
		}

		var newParent = new GameObject();
		newParent.layer = this.gameObject.layer;
		newParent.transform.position = this.gameObject.transform.position;
		this.transform.SetParent(newParent.transform, true);
		otherGo.transform.SetParent(newParent.transform, true);

		var myRigidBody = this.gameObject.GetComponent<Rigidbody>();
		var newRigidBody = newParent.AddComponent<Rigidbody>();
		newRigidBody.mass = myRigidBody.mass;
		newRigidBody.drag = myRigidBody.drag;

		Destroy(this.gameObject.GetComponent<Rigidbody>());
		Destroy(otherGo.GetComponent<Rigidbody>());

		var newballBurner = newParent.AddComponent<ballBurner>();
		var myBallBurner = this.GetComponent<ballBurner>();
		newballBurner.DeathYValue = myBallBurner.DeathYValue;
		Destroy(newballBurner);


	}
}
