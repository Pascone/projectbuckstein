////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Project_Buckstein | Programmed and Designed by Parker Staszkiewicz, Anthony Pascone, and John Imgrund (c) 2018 //
//                                                                                                                //
//  JoinMenu : class | Written by John Imgrund, Anthony Pascone, and Parker Staszkiewicz                          //
//   Used in MenuScene. This class handles everything to do with the join subset of the menu.                     //
//   This has a reference to multiple InputFields for UserNames and ServerIP addresses to send to the Plugin.     //
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using ChampNet;


public class JoinMenu : MonoBehaviour
{
    public TMP_InputField serverIP;
    public TMP_InputField userName;

    private void Start()
    {
        userName.characterLimit = 12;
    }

    /// <summary>
    /// Connects the player to the server based on the given IP address.
    /// </summary>
    public void JoinServer()
    {
        ChampNetManager.InitClient(userName.text, serverIP.text);

        PersistentData.SetUserName(userName.text);
        PersistentData.SetHosting(false);

        NextScene();
    }

    public void NextScene()
    {
        if (userName.text == "" || serverIP.text == "")
        {
            return;
        }

        SceneManager.LoadScene(2);
    }
}
