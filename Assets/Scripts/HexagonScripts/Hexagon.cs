using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour {


	void Start () {
		gameObject.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
			
		}
	
	void Update () {
		
	}
}
