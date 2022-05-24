using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class Menu : MonoBehaviourPunCallbacks
{
    public GameObject play;
    public GameObject settings;
    public GameObject mainMenu;

    private TypedLobby mainLobby = new TypedLobby("Lobby #1", LobbyType.Default);
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(mainLobby);
        Debug.Log("Connected");


    }

    public void Play()
    {
        play.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void American()
    {
        RoomOptions options = new RoomOptions();
        PhotonNetwork.JoinOrCreateRoom("Room #1", options, TypedLobby.Default);
        PhotonNetwork.LoadLevel(1);
    }

    public void European()
    {
        SceneManager.LoadScene(2);
    }

    public void Settings()
    {
        settings.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void Back()
    {
        mainMenu.SetActive(true);
        settings.SetActive(false);
    }

}
