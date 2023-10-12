using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Brid : MonoBehaviour
{
    Rigidbody2D rb;
    public TMP_Text scoretext;
    public float rotatepower;
    public float jumpSpeed;
    private int score = 0;
    private AudioSource AS;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        AS = GameObject.Find("scoresound").GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }
        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * rotatepower);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoretext.text = "score: " + score.ToString();
        
    }


}
