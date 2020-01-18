using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlineSceneMenu : MonoBehaviour
{
    // This is the funtion attached to the OnClick listner of the Disconnect Button in the Online Scene.    
    public void DisconnectBTN() {
        // This calls the Disconnect From Server Void from the Multiplayer menu script that has lived from the first scene to the online scene.
        MultiplayerMenu.Instance.DisconnectFromServer(); 
    }
}
