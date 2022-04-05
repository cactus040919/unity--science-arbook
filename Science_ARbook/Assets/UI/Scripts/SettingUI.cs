using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingUI : MonoBehaviour
{
    [SerializeField]
    private Button KoreanButton;
    [SerializeField]
    private Button EnglishButton;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        switch (PlayerSetting.userLanguage)
        {
            case EUserLanguage.Korean:
                KoreanButton.image.color = Color.white;
                EnglishButton.image.color = Color.gray;
                break;

            case EUserLanguage.English:
                EnglishButton.image.color = Color.white;
                KoreanButton.image.color= Color.gray;
                break;

        }
    }

    public void SetLanguageMod(int languageType)
    {
        PlayerSetting.userLanguage = (EUserLanguage)languageType;

        switch (PlayerSetting.userLanguage)
        {
            case EUserLanguage.Korean:
                KoreanButton.image.color = Color.white;
                EnglishButton.image.color = Color.gray;
                break;

            case EUserLanguage.English:
                EnglishButton.image.color = Color.white;
                KoreanButton.image.color = Color.gray;
                break;
        }
    }

    public void Close()
    {
        StartCoroutine(CloseAfterDelay());
    }
    
    private IEnumerator CloseAfterDelay()
    {
        animator.SetTrigger("close");
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
        animator.ResetTrigger("close");
    }
}
