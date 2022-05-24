using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class mainScript : MonoBehaviourPunCallbacks
{
    public PhotonView pv;

    public float speed = 300;
    public bool isSpining = false;
    public bool roundActive = false;

    public List<GameObject> button_list = new List<GameObject>();
    public bool numberSorted = false;
    public static int choosedNumber;
    public static int sortedNumber;
    public Text sortedNumberText;
    public float value;
    public InputField valueText;
    public float valueResult;
    public Text valueResultText;
    public InputField valueField;
    public bool stopping = false;
    public float time;
    public Text timeText;


    public GameObject pointer;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(valueResult > 0)
        {
            valueResultText.text = "Winnings: +" + valueResult;
        }
        else
        {
            valueResultText.text = "Winnings: " + valueResult;
        }
        
        
        if (valueText.text != "")
        {
            value = int.Parse(valueText.text);
        }

        if (time > 4)
        {
            if (stopping == true)
            {
                this.gameObject.GetPhotonView().RPC("PreStop", RpcTarget.AllBuffered);
                stopping = false;
            }

            if (time >= 20)
            {
                isSpining = true;
                stopping = true;
                roundActive = true;
                speed = 300;
                time = 0;
            }

            
        }

        if (time >= 12 && time <= 12.5)
        {
            numberSorted = false;
            valueResult = 0;
            value = 0;
            valueText.text = null;
            valueField.GetComponent<InputField>().interactable = true;
            foreach (GameObject n in button_list)
            {
                n.GetComponent<Button>().interactable = true;
            }
        }

        if(choosedNumber == sortedNumber && speed >= 0 && isSpining == true && numberSorted == true)
        {
            valueResult = value * 2;
        }
        else if(choosedNumber != sortedNumber && speed>= 0 && isSpining == true && numberSorted == true)
        {
            Debug.Log("Ta indo");
            valueResult = value * -1;
        }

        timeText.text = time.ToString();
        sortedNumberText.text = ("Number: " + sortedNumber.ToString());
        if(roundActive == true)
        {
            this.gameObject.GetPhotonView().RPC("Rotate", RpcTarget.AllBuffered);
        }
    }

    public override void OnCreatedRoom()
    {
        roundActive = true;
        stopping = true;
        isSpining = true;
        speed = 300;
    }

    [PunRPC]
    public void Rotate()
    {
        time += Time.deltaTime;
        roundActive = true;
        transform.Rotate(0, 0, speed * Time.deltaTime);
       
        if(speed > 0)
        {
            
            pointer.GetComponent<BoxCollider2D>().enabled = false;
            valueField.GetComponent<InputField>().interactable = false;
            foreach(GameObject n in button_list)
            {
                n.GetComponent<Button>().interactable = false;
            }
        }

        if (isSpining == false && speed > 0)
        {
            this.gameObject.GetPhotonView().RPC("Stop", RpcTarget.AllBuffered);
           
        }
    }

    [PunRPC]
    public void PreStop()
    {
        isSpining = false;
        
    }

    [PunRPC]
    public void Stop()
    {
        speed--;
        if(speed <= 0)
        {
            speed = 0;
            pointer.GetComponent<BoxCollider2D>().enabled = true;
            numberSorted = true;
            


        }
    }
}
