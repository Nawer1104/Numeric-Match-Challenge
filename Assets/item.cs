using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class item : MonoBehaviour
{
    public string tag;
    // Start is called before the first frame update
    public float value;
    public TextMeshPro text;

    void Start()
    {
        text.text = value.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tag)
        {
            value += collision.gameObject.GetComponent<OnDrag>().value;
            text.text = value.ToString();

            game.Instance.RemoveBall(collision.gameObject);
            Destroy(collision.gameObject);
            
        }
    }
}
