using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float Speed;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (transform.position.y < -5)
        {
            transform.position = new Vector3(0, 0, 0);
        }
        if (transform.position.y <= 3.5)
        {
            transform.position += new UnityEngine.Vector3(0, 0, Time.deltaTime * Speed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
            thisAnimation.Play();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("LoseScene");
            
        }
    }
}
