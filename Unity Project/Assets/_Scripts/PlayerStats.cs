using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public GameObject HUD;
    public int health;
    public int score;
    public bool isimmune;
    SpriteRenderer SR;
    private float timeelapsed;
    public float immunityduration;
    // Use this for initialization
    void Start () {
        SR = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(isimmune)
        {
            timeelapsed += Time.deltaTime;
            if(timeelapsed>immunityduration)
            {
                SR.enabled = true;
                isimmune = false;
                StopCoroutine("Flashing");
                timeelapsed = 0;
            }
        }
        
    }
    public void takeDamage(int damage)
    {
        if (!isimmune)
        {
            health -= damage;
            isimmune = true;

            if(health==0)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(300, 300));
                Camera cam = Camera.main;
                cam.transform.SetParent(null);
                GetComponent<CircleCollider2D>().enabled = false;
                GetComponent<PlayerController>().enabled = false;
                GetComponent<Animator>().enabled = false;
                GetComponent<PlayerStats>().enabled = false;
                HUD.GetComponent<HUDController>().GameOverText();

                return;
            }
            HUD.GetComponent<HUDController>().UpdateHealth(health);
            StartCoroutine("Flashing");
        }
       
    }
    public void AddScore(int amount)
    {

        score += amount;
        HUD.GetComponent<HUDController>().UpdateScore(score);
        
    }

        IEnumerator Flashing()
    {
        while (true)
        {
            SR.enabled = false;
            yield return new WaitForSeconds(0.1f);
            SR.enabled = true;
            yield return new WaitForSeconds(0.1f);
        }
    }

  
}
