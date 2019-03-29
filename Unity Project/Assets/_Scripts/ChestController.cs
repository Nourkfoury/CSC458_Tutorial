using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChestController : MonoBehaviour {
    public Transform SpawnPt;
    public GameObject Coin;
    private bool CoinPopped = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player" && !CoinPopped)
        {
            GetComponent<Animator>().enabled = true;
            GameObject temp=GameObject.Instantiate(Coin, SpawnPt.position, SpawnPt.rotation);
            temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-2, 2), Random.Range(3, 6)), ForceMode2D.Impulse);

            CoinPopped = true;
            GetComponent<ParticleSystem>().Play();
        }
    }
}
