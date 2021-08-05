using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMoving : MonoBehaviour
{

    [SerializeField] float speed = 4f;
    [SerializeField] float height = 2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed) * height;
        //set the object's Y to the new calculated Y
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + newY);

    }
}
