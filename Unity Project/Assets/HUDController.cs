using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour {
    
    public GameObject heart1, heart2, heart3;
    private SpriteRenderer heart1Sp, heart2Sp, heart3Sp;
    public Sprite fullHeart, HalfHeart, NoHeart;

	// Use this for initialization
	void Start () {
        heart1Sp = heart1.GetComponent<SpriteRenderer>();
        heart2Sp = heart2.GetComponent<SpriteRenderer>();
        heart3Sp = heart3.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void UpdateHealth(int health)
    {
        switch(health)
        {
            case 6:
                heart1Sp.sprite = fullHeart;
                heart2Sp.sprite = fullHeart;
                heart3Sp.sprite = fullHeart;
                break;
            case 5:
                heart1Sp.sprite = fullHeart;

                heart2Sp.sprite = fullHeart;
                heart3Sp.sprite = HalfHeart;
                break;
            case 4:
                heart1Sp.sprite = fullHeart;
                heart2Sp.sprite = fullHeart;
                heart3Sp.sprite = NoHeart;
                break;
            case 3:
                heart1Sp.sprite = fullHeart;
                heart2Sp.sprite = HalfHeart;
                heart3Sp.sprite = NoHeart;
                break;
            case 2:
                heart1Sp.sprite = fullHeart;
                heart2Sp.sprite = NoHeart;
                heart3Sp.sprite = NoHeart;
                break;
            case 1:
                heart1Sp.sprite = HalfHeart;
                heart2Sp.sprite = NoHeart;
                heart3Sp.sprite = NoHeart;
                break;
            case 0:
                heart1Sp.sprite = NoHeart;
                heart2Sp.sprite = NoHeart;
                heart3Sp.sprite = NoHeart;
                break;
        }
    }
}
