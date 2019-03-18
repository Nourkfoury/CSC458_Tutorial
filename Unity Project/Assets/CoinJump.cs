using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
       GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-2, 2), Random.Range(3, 6)), ForceMode2D.Impulse);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
