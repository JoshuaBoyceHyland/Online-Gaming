using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConnectionChecker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (!NetworkManager.Singleton.IsServer)
        {
            if (!NetworkManager.Singleton.IsConnectedClient)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
