using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LanguageObject
{
    [SerializeField] public GameObject m_Language;
    [SerializeField] public GameObject m_Language_Small_Alphabets;
    [SerializeField] public GameObject m_Language_Capitalized_Alphabets;
    [SerializeField] public GameObject m_Language_Special_Alphabets_And_Calculator;
}
public class KeyboardFunctionltyChanger : MonoBehaviour {
    
    private enum Language { English,Arabic };
    private enum View { Small, Cabitalized, Special_And_Calculator };
    [Header("English Settings")]
    public LanguageObject engLanguage;


    [Header("Arabic Settings")]
    public LanguageObject arabicLanguage;


    [SerializeField] Language language;
    [SerializeField] View view;




    private LanguageObject choosedLanguage;
    private GameObject choosedView;
    private void Start()
    {
        language = Language.English;
        view = View.Small;
    }
    private void Update()
    {
        LanguageChooser();
    }

    private void LanguageChooser()
    {
        switch (language)
        {
            case Language.English:
                {
                    engLanguage.m_Language.SetActive(true);
                    arabicLanguage.m_Language.SetActive(false);
                    choosedLanguage = engLanguage;
                    break;
                }
            case Language.Arabic:
                {
                    arabicLanguage.m_Language.SetActive(true);
                    engLanguage.m_Language.SetActive(false);
                    choosedLanguage = arabicLanguage;
                    break;
                }
        }
        LanguageViewChooser();
    }
    private void LanguageViewChooser()
    {
        switch (view)
        {
            case View.Small:
                choosedLanguage.m_Language_Small_Alphabets.SetActive(true);
                choosedLanguage.m_Language_Capitalized_Alphabets.SetActive(false);
                choosedLanguage.m_Language_Special_Alphabets_And_Calculator.SetActive(false);
                break;
            case View.Cabitalized:
                choosedLanguage.m_Language_Small_Alphabets.SetActive(false);
                choosedLanguage.m_Language_Capitalized_Alphabets.SetActive(true);
                choosedLanguage.m_Language_Special_Alphabets_And_Calculator.SetActive(false);
                break;
            case View.Special_And_Calculator:
                choosedLanguage.m_Language_Small_Alphabets.SetActive(false);
                choosedLanguage.m_Language_Capitalized_Alphabets.SetActive(false);
                choosedLanguage.m_Language_Special_Alphabets_And_Calculator.SetActive(true);
                break;
        }
    }

    public void chooseLanguage(int languageindex)
    {
        language =  (Language)languageindex;
        chooseLanguageView(0);
    }
    public void chooseLanguageView(int languageindex)
    {
        view = (View)languageindex;
    }
}
