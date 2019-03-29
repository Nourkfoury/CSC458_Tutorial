using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

   
    private AudioSource audiosrc;
    public int amount;
    bool destroycoin;
	// Use this for initialization
	void Start () {
        audiosrc = GetComponent<AudioSource>();	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            audiosrc.Play();
            PlayerStats ps = collision.GetComponent<PlayerStats>();
            ps.AddScore(amount);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            Destroy(gameObject);
        }
    }

}
