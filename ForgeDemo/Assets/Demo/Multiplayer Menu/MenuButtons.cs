using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    //These are just references to gameobjects in the multiplayer menu scene.
    public GameObject HostBtn, JoinBtn, IPINput, PortInput;

    void Start() {
        GetButtons();
    }

    //This simply gets the multiplayer menu script set back up with its references as it will lose all of them when it is moved to the Online scene.
    public void GetButtons() {
        HostBtn.GetComponent<Button>().onClick.RemoveAllListeners();
        JoinBtn.GetComponent<Button>().onClick.RemoveAllListeners();

        HostBtn.GetComponent<Button>().onClick.AddListener(() => { MultiplayerMenu.Instance.Host(); });
        JoinBtn.GetComponent<Button>().onClick.AddListener(() => { MultiplayerMenu.Instance.Connect(); });
        MultiplayerMenu.Instance.ipAddress = IPINput.GetComponent<InputField>();
        MultiplayerMenu.Instance.portNumber = PortInput.GetComponent<InputField>();
    }
}
