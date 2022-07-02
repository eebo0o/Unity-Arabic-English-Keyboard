using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using UPersian.Components;

public class InputFieldLanguageAlignmenter : MonoBehaviour {
    public InputField inputField;
    // Use this for initialization
    void Start () {
        inputField = GetComponent<InputField>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeingText()
    {
        if (inputField.text != "")
        {
            if (HasArabicCharacters(inputField.text))
            {
                if (HasFirstArabicCharacters(inputField.text))
                {
                    inputField.transform.GetChild(2).GetComponent<Text>().alignment = TextAnchor.UpperRight;
                    inputField.transform.GetChild(2).GetComponent<RtlText>().active = true;
                }
                else
                {
                    inputField.transform.GetChild(2).GetComponent<Text>().alignment = TextAnchor.UpperLeft;
                    inputField.transform.GetChild(2).GetComponent<RtlText>().active = true;
                }
            }
            else
            {
                inputField.transform.GetChild(2).GetComponent<Text>().alignment = TextAnchor.UpperLeft;
                inputField.transform.GetChild(2).GetComponent<RtlText>().active = false;
            }
        }
    }
    private bool HasArabicCharacters(string text)
    {

        Regex regex = new Regex(".[\u0600-\u06FF]+.|^[\u0600-\u06FF]");

        return regex.IsMatch(text);
    }
    private bool HasFirstArabicCharacters(string text)
    {

        Regex regex = new Regex("^[\u0600-\u06FF]");

        return regex.IsMatch(text);
    }
}
