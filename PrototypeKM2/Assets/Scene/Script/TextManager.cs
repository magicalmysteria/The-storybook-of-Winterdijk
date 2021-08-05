using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text currText;
    public Text textRight;
    public Text textLeft;

    public List<string> textList = new List<string>();

    public int currIndex = 1;

    public string getCurrentWord()
    {
        return textList[currIndex];
    }

    public int GetMaxIndex() { return textList.Count; }

    // Update is called once per frame
    void Update()
    {
        currText.text = textList[currIndex];
        textRight.text = textList[currIndex - 1];
        textLeft.text = textList[currIndex + 1];
    }
}
