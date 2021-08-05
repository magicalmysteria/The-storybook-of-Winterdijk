using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boat : MonoBehaviour
{
    private Vector2 startPos;

    public bool animating = false;

    float newA = 1;

    float speed = 0.001f;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.localPosition;

    //    animating = true;

    }

    // Update is called once per frame
    void Update()
    {
        //Animating();
        if(animating) Animating();
    }

    public bool Animating()
    {
            // GetComponent<RawImage>().color.a - Mathf.Cos(Time.time * 0.1f);
           // GetComponent<RawImage>().color.a - Mathf.Cos(Time.time * 0.1f);'

       // anim.SetBool("Animating", animating);

        if(animating)
        {
            anim.Play("newAnime", 0, 0f);
            animating = false;
        }

        //speed += 0.001f;

        //GetComponent<RawImage>().color = new Color(GetComponent<RawImage>().color.r, GetComponent<RawImage>().color.b, GetComponent<RawImage>().color.g, newA);

        //transform.localPosition -= new Vector3(1.5f, 0, 0);
        //if(transform.localPosition.x < 80)
        //{
        //    speed = 0.005f;
        //    transform.localPosition = new Vector3(500, transform.localPosition.y, transform.localPosition.z);
        //}

        //else if (transform.localPosition.x < 310 && transform.localPosition.x > startPos.x)
        //{
        //    transform.localPosition = startPos;
        //    animating = false;
        //}

        //if(transform.localPosition.x < startPos.x)
        //{
        //    newA = Mathf.Lerp(newA, 0, speed);
        //}

        //if (transform.localPosition.x > startPos.x)
        //{
        //    newA = Mathf.Lerp(newA, 1, speed);
        //}



        return true;
    }
}
