using UnityEngine;
using System.Collections;

public class TriggerZoneScript : MonoBehaviour {
	void Start () {
	
	}
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		Destroy (other.gameObject);
	}
}
