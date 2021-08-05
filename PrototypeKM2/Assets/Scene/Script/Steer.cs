using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steer : MonoBehaviour
{

    public TextManager Tmanager;
    public Boat boat;
    public SampleUserPolling_ReadWrite messageHolder;
    int steerSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(new Vector3(0, 0, 3f));
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Rotate(new Vector3(0, 0, 3f));
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Rotate(new Vector3(0, 0, -3f));
        //}


        if (messageHolder.message == "left")
        {
            boat.animating = true;

            if (Tmanager.currIndex < Tmanager.GetMaxIndex() && steerSpeed > 25)
            {
                Tmanager.currIndex++;
                steerSpeed = 0;

                
            }

            steerSpeed++;
            Debug.Log(steerSpeed);
            //transform.Rotate(new Vector3(0, 0, 3f));
        }
        else if (messageHolder.message == "right")
        {
            boat.animating = true;

            if (Tmanager.currIndex > 0 && steerSpeed > 25)
            {
                Tmanager.currIndex--;
                steerSpeed = 0;
            }

            steerSpeed++;

            //transform.Rotate(new Vector3(0, 0, -3f));
        }
        
    }
}
