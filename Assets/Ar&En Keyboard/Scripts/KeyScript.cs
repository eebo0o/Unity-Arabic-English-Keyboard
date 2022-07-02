using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeyScript : MonoBehaviour {

    public Text mycharcter;
    private void Start()
    {
        mycharcter = transform.GetChild(0).GetComponent<Text>();
    }
    public void AddCahrcter()
    {
        KeysManger.keysManger.AppendCharcter(mycharcter.text);
    }
    public void sendEnter()
    {
        KeysManger.keysManger.AppendCharcter("\n");
    }
    public void sendTab()
    {
        KeysManger.keysManger.AppendCharcter("\t");
    }
    public void sendBackSpace()
    {
        KeysManger.keysManger.DeleteCharcter();
    }

}
