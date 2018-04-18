using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

 public float damage = 10f, range = 100f;

public GameObject bluelaser;
	void firing () {
		var laserAncestor = GameObject.Find("bluelaser");
		var newLaser = GameObject.Instantiate(laserAncestor,{

			Vector2 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
 
        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
            );
        transform.up = direction;
		} );

		

	}
}
