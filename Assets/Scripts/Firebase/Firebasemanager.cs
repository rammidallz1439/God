using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Auth;
using TMPro;
public class Firebasemanager : MonoBehaviour
{
    public static Firebasemanager instance;

    public FirebaseAuth auth;
    public FirebaseUser user;

    [SerializeField]
    private TMP_InputField loginEmail;
    [SerializeField]
    private TMP_InputField loginPaswrod;
    [SerializeField]
    private TMP_Text loginText;

    [SerializeField]
    private TMP_InputField registerEmail;
    [SerializeField]
    private TMP_InputField registerUserName;
    [SerializeField]
    private TMP_InputField regiterPassword;
    [SerializeField]
    private TMP_InputField registerConfrimPassword;
    [SerializeField]
    private TMP_Text registerOutputText;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(instance.gameObject);
            instance = this;
        }
    }
}
