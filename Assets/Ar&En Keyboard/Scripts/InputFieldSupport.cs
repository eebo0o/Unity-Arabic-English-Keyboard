using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputFieldSupport : MonoBehaviour {
    public InputField myRefrance;
    private void Start()
    {
        myRefrance = GetComponent<InputField>();
    }
    public void SendReferance()
    {
        KeysManger.keysManger.FoucseInputField(myRefrance);
    }

}
