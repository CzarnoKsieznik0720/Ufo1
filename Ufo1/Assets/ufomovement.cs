using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ufomovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public int force;
    float count=0;
    public Text score;
    public Text winText;
    private AudioSource audioSource;
    public AudioClip CoinSound;
    public AudioClip backgroundAudio;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(backgroundAudio);
        audioSource.loop = true;
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement*force);
    }
    private void OnTriggerEnter2D(Collider2D obiektkolizji)
    {
        if (obiektkolizji.gameObject.CompareTag("Pickup"))
        {
            audioSource.PlayOneShot(CoinSound);
            Destroy(obiektkolizji.gameObject);
            count++;
            UpdateText();
        }
    }

    void UpdateText()
    {
    score.text = count.ToString();

    }
}



   

