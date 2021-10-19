using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundChange : MonoBehaviour
{
    public Image image;
    public Sprite[] Sprites;
    private int y;
    // Start is called before the first frame update
    void Start()
    {
        y = Random.Range(0, 3);
        image.sprite = Sprites[y];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
