using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AuthUiManager : MonoBehaviour
{
    public static AuthUiManager instance;

    [Header("references")]
    [SerializeField]
    private GameObject checkingForAccountUi;
    [SerializeField]
    private GameObject loginUi;
    [SerializeField]
    private GameObject registerUi;
    [SerializeField]
    private GameObject verifyEmailUi;
    [SerializeField]
    private TMP_Text verifyEmailText;

    // Start is called before the first frame update
    void Start()
    {
        if (instance==null)
        {
            instance = this;
        }
        else if (instance!=null)
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ClearUi()
    {
       
        loginUi.SetActive(false);
        registerUi.SetActive(false);
    }
    void LoginScreen()
    {
        ClearUi();
        loginUi.SetActive(true);
    }
    void RegisterScreen()
    {
        ClearUi();
        registerUi.SetActive(true);
    }
}
