using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseWord : MonoBehaviour
{
    public TextManager Tmanager;
    public Text canvasText;
    bool called = false;
    public SampleUserPolling_ReadWrite messageHolder;
    public RawImage steerImg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //   if(Input.GetKeyDown(KeyCode.A)) canvasText.text = canvasText.text + " " + Tmanager.getCurrentWord();
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            if (!called)
            {
                string currWord = canvasText.text + " " + Tmanager.getCurrentWord();
                Debug.Log(canvasText.text);
                canvasText.text = currWord;
                called = true;
            }
            if(called) called = false;
           
        }

     //   Debug.Log("Message = " + messageHolder.message);

        if (messageHolder.message == "Text" && !called)//Input.GetKeyDown(KeyCode.A))
        {
                called = true;
                string currWord = canvasText.text + " " + Tmanager.getCurrentWord();
                Debug.Log(canvasText.text);
                canvasText.text = currWord;
                steerImg.enabled = false;
        }
        if(called && messageHolder.message == "No text")
        {
            called = false;
        }
        //  Debug.Log(canvasText.text += Tmanager.getCurrentWord());
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    canvasText.text = canvasText.text + " " + Tmanager.getCurrentWord();
    //}
}
