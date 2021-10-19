using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float Fly;
    private Rigidbody rb;
    public Text scoreText;
    private int score = 0;
    public AudioClip Point;
    public AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene("LoseScene");
        }
        if (transform.position.y >= 3.5)
        {
            rb.velocity = Vector3.zero;
            transform.position = new Vector3(transform.position.x, 3.5f, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector3(0, Fly, 0));
        }
     
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("LoseScene");

        }
        if (collision.gameObject.tag == "Point")
        {
            score++;
            scoreText.text = "SCORE: " + score;
            audioSource.PlayOneShot(Point);
            CheckScore();
        }
    }

    public void CheckScore()
    {
        if (score >= 10)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
