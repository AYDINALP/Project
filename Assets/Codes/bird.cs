using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bird : MonoBehaviour
{
    public float zýplama_aralýk;
    Rigidbody2D rb;
    public Text skor_text;
    public float SKOR;
    public bool ddead;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * zýplama_aralýk;
        }

        skor_text.text = SKOR.ToString();
    }
    void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.gameObject.tag == "scorer")
        {
            SKOR++;
            SoundManager.PlaySound("Point");
        }
    }
    void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "Asteriot")
        {
            Time.timeScale = 0;
            ddead = true;
            SoundManager.PlaySound("Dead");
        }
    }
}