using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mlapiUi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClickStartHost()
    {
        Debug.Log("Start Host!!");
        MLAPI.NetworkingManager.Singleton.StartHost();
    }

    public void OnClickStartClient()
    {
        Debug.Log("Start Client!!");
        MLAPI.NetworkingManager.Singleton.StartClient();
    }
}
