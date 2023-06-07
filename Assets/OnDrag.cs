using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OnDrag : MonoBehaviour
{
    public float num;
    public float value { get; set; }
    public TextMeshPro text;

    private bool check;
    Vector3 offset;
    private object collision;

    private void Start()
    {
        value = num;
        text.text = value.ToString();
    }

    void OnMouseDown()
    {
        check = true;
    }
    void OnMouseDrag()
    {
        if (check)
        {

            float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));


        }

    }
    void OnCollisionEnter(Collision other)
    {
        check = false;
    }


}


