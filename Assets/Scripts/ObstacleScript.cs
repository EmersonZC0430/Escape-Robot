using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {
	
	public GameControlScript control;
	
	void Start () {
	
	}
	
	void Update () {
		transform.Translate(0, 0, control.objectSpeed);
	}
}
