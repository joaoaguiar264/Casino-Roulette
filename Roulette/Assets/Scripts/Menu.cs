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

    public GameObject Selection1;
    public GameObject Selection2;
    public GameObject Selection3;
    public GameObject Selection4;
    public GameObject Selection5;

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

    public void ChooseGame()
    {
        play.SetActive(false);
        settings.SetActive(false);
        mainMenu.SetActive(true);
        Selection1.SetActive(false);
        Selection2.SetActive(false);
        Selection3.SetActive(true);
        Selection4.SetActive(false);
        Selection5.SetActive(false);
    }
    public void American()
    {
        RoomOptions options = new RoomOptions();
        PhotonNetwork.JoinOrCreateRoom("Room #1", options, TypedLobby.Default);
        PhotonNetwork.LoadLevel(1);
        //SceneManager.LoadScene(1);
    }

    public void European()
    {
        SceneManager.LoadScene(2);
    }

    public void Settings()
    {
        play.SetActive(false);
        settings.SetActive(true);
        mainMenu.SetActive(false);

        Selection1.SetActive(false);
        Selection2.SetActive(false);
        Selection3.SetActive(false);
        Selection4.SetActive(false);
        Selection5.SetActive(true);
    }

}
