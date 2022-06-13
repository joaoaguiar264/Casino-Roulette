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
    public bool isSpining = true;
    public bool roundActive = true;
    public float finalTotal;
    public bool roundFinished = false;

    public List<GameObject> button_list = new List<GameObject>();
    public bool numberSorted = false;
    public int choosedNumber;
    public static int sortedNumber;
    public Text sortedNumberText;

    public bool count0Made = false;
    public bool countMade = false;
    private float multiplier = 36;
    public Text winResultText;
    public Text loseResultText;

    public bool stopping = true;
    public float time;
    public Text timeText;


    public GameObject pointer;

    public GameObject guest;



    // Start is called before the first frame update
    void Start()
    {
        if(PhotonNetwork.IsMasterClient == true)
        {
        roundActive = true;
        stopping = true;
        isSpining = true;
        speed = 300;
        }
    }

    // Update is called once per frame
    
    void Update()
    {

        if (PhotonNetwork.IsMasterClient == true)
        {
            if (roundActive == true)
            {
                this.gameObject.GetPhotonView().RPC("Rotate", RpcTarget.AllBuffered);

                if (isSpining == false && speed > 0)
                {
                    this.gameObject.GetPhotonView().RPC("Stop", RpcTarget.AllBuffered);
                }

                if (time > 4)
                {
                    if (stopping == true)
                    {
                        this.gameObject.GetPhotonView().RPC("PreStop", RpcTarget.AllBuffered);
                        stopping = false;
                    }

                    if (time >= 26)
                    {
                        this.gameObject.GetPhotonView().RPC("Reset1", RpcTarget.AllBuffered);
                    }


                }

                if (time >= 10f && time <= 10.2f)
                {
                    this.gameObject.GetPhotonView().RPC("Unlock", RpcTarget.AllBuffered);
                }
                if (time >= 10.3f && time <= 10.4f)
                {
                    this.gameObject.GetPhotonView().RPC("Reset2", RpcTarget.AllBuffered);

                }
                if(time >= 16 && time < 17)
                {
                    timeText.text = "10 Seconds left!";
                }

                if (time >= 21 && time < 25)
                {
                    timeText.text = "5 Seconds left!";
                }
            }
        }

        if (roundFinished == true)
        {
            if (finalTotal > numberChoosen.totalBet)
            {
                float win = finalTotal - numberChoosen.totalBet;
                winResultText.text = "total win: +" + win.ToString("F2");
            }
            else if(finalTotal < numberChoosen.totalBet)
            {
                float lose = numberChoosen.totalBet - finalTotal;
                loseResultText.text = "total lose: -" + lose.ToString("F2");
            }
            else if(finalTotal == numberChoosen.totalBet)
            {

            }
        }





        //Offline

        if (numberSorted == true)
        {


            if (sortedNumber == 0)
            {
                if (numberChoosen.zero > 0 && count0Made == false)
                {
                    numberChoosen.zero = numberChoosen.zero * multiplier;
                    finalTotal = finalTotal + numberChoosen.zero;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 1)
            {
                if (numberChoosen.one > 0 && count0Made == false)
                {
                    numberChoosen.one = numberChoosen.one * multiplier;
                    finalTotal = finalTotal + numberChoosen.one;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 2)
            {
                if (numberChoosen.two > 0 && count0Made == false)
                {
                    numberChoosen.two = numberChoosen.two * multiplier;
                    finalTotal = finalTotal + numberChoosen.two;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 3)
            {
                if (numberChoosen.three > 0 && count0Made == false)
                {
                    numberChoosen.three = numberChoosen.three * multiplier;
                    finalTotal = finalTotal + numberChoosen.three;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 4)
            {
                if (numberChoosen.four > 0 && count0Made == false)
                {
                    numberChoosen.four = numberChoosen.four * multiplier;
                    finalTotal = finalTotal + numberChoosen.four;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 5)
            {
                if (numberChoosen.five > 0 && count0Made == false)
                {
                    numberChoosen.five = numberChoosen.five * 2;
                    finalTotal = finalTotal + numberChoosen.five;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 6)
            {
                if (numberChoosen.six > 0 && count0Made == false)
                {
                    numberChoosen.six = numberChoosen.six * multiplier;
                    finalTotal = finalTotal + numberChoosen.six;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 7)
            {
                if (numberChoosen.seven > 0 && count0Made == false)
                {
                    numberChoosen.seven = numberChoosen.seven * multiplier;
                    finalTotal = finalTotal + numberChoosen.seven;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 8)
            {
                if (numberChoosen.eight > 0 && count0Made == false)
                {
                    numberChoosen.eight = numberChoosen.eight * multiplier;
                    finalTotal = finalTotal + numberChoosen.eight;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 9)
            {
                if (numberChoosen.nine > 0 && count0Made == false)
                {
                    numberChoosen.nine = numberChoosen.nine * multiplier;
                    finalTotal = finalTotal + numberChoosen.nine;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 10)
            {
                if (numberChoosen.ten > 0 && count0Made == false)
                {
                    numberChoosen.ten = numberChoosen.ten * multiplier;
                    finalTotal = finalTotal + numberChoosen.ten;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 11)
            {
                if (numberChoosen.eleven > 0 && count0Made == false)
                {
                    numberChoosen.eleven = numberChoosen.eleven * multiplier;
                    finalTotal = finalTotal + numberChoosen.eleven;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 12)
            {
                if (numberChoosen.twelve > 0 && count0Made == false)
                {
                    numberChoosen.twelve = numberChoosen.twelve * multiplier;
                    finalTotal = finalTotal + numberChoosen.twelve;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 13)
            {
                if (numberChoosen.thirteen > 0 && count0Made == false)
                {
                    numberChoosen.thirteen = numberChoosen.thirteen * multiplier;
                    finalTotal = finalTotal + numberChoosen.thirteen;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 14)
            {
                if (numberChoosen.fourteen > 0 && count0Made == false)
                {
                    numberChoosen.fourteen = numberChoosen.fourteen * multiplier;
                    finalTotal = finalTotal + numberChoosen.fourteen;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 15)
            {
                if (numberChoosen.fifteen > 0 && count0Made == false)
                {
                    numberChoosen.fifteen = numberChoosen.fifteen * multiplier;
                    finalTotal = finalTotal + numberChoosen.fifteen;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 16)
            {
                if (numberChoosen.sixteen > 0 && count0Made == false)
                {
                    numberChoosen.sixteen = numberChoosen.sixteen * multiplier;
                    finalTotal = finalTotal + numberChoosen.sixteen;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 17)
            {
                if (numberChoosen.seventeen > 0 && count0Made == false)
                {
                    numberChoosen.seventeen = numberChoosen.seventeen * multiplier;
                    finalTotal = finalTotal + numberChoosen.seventeen;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 18)
            {
                if (numberChoosen.eighteen > 0 && count0Made == false)
                {
                    numberChoosen.eighteen = numberChoosen.eighteen * multiplier;
                    finalTotal = finalTotal + numberChoosen.eighteen;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 19)
            {
                if (numberChoosen.nineteen > 0 && count0Made == false)
                {
                    numberChoosen.nineteen = numberChoosen.nineteen * multiplier;
                    finalTotal = finalTotal + numberChoosen.nineteen;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 20)
            {
                if (numberChoosen.twenty > 0 && count0Made == false)
                {
                    numberChoosen.twenty = numberChoosen.twenty * multiplier;
                    finalTotal = finalTotal + numberChoosen.twenty;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 21)
            {
                if (numberChoosen.twentyOne > 0 && count0Made == false)
                {
                    numberChoosen.twentyOne = numberChoosen.twentyOne * multiplier;
                    finalTotal = finalTotal + numberChoosen.twentyOne;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 22)
            {
                if (numberChoosen.twentyTwo > 0 && count0Made == false)
                {
                    numberChoosen.twentyTwo = numberChoosen.twentyTwo * multiplier;
                    finalTotal = finalTotal + numberChoosen.twentyTwo;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 23)
            {
                if (numberChoosen.twentyThree > 0 && count0Made == false)
                {
                    numberChoosen.twentyThree = numberChoosen.twentyThree * multiplier;
                    finalTotal = finalTotal + numberChoosen.twentyThree;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 24)
            {
                if (numberChoosen.twentyFour > 0 && count0Made == false)
                {
                    numberChoosen.twentyFour = numberChoosen.twentyFour * multiplier;
                    finalTotal = finalTotal + numberChoosen.twentyFour;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 25)
            {
                if (numberChoosen.twentyFive > 0 && count0Made == false)
                {
                    numberChoosen.twentyFive = numberChoosen.twentyFive * multiplier;
                    finalTotal = finalTotal + numberChoosen.twentyFive;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 26)
            {
                if (numberChoosen.twentySix > 0 && count0Made == false)
                {
                    numberChoosen.twentySix = numberChoosen.twentySix * multiplier;
                    finalTotal = finalTotal + numberChoosen.twentySix;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 27)
            {
                if (numberChoosen.twentySeven > 0 && count0Made == false)
                {
                    numberChoosen.twentySeven = numberChoosen.twentySeven * multiplier;
                    finalTotal = finalTotal + numberChoosen.twentySeven;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 28)
            {
                if (numberChoosen.twentyEight > 0 && count0Made == false)
                {
                    numberChoosen.twentyEight = numberChoosen.twentyEight * multiplier;
                    finalTotal = finalTotal + numberChoosen.twentyEight;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 29)
            {
                if (numberChoosen.twentyNine > 0 && count0Made == false)
                {
                    numberChoosen.twentyNine = numberChoosen.twentyNine * multiplier;
                    finalTotal = finalTotal + numberChoosen.twentyNine;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 30)
            {
                if (numberChoosen.thirty > 0 && count0Made == false)
                {
                    numberChoosen.thirty = numberChoosen.thirty * multiplier;
                    finalTotal = finalTotal + numberChoosen.thirty;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 31)
            {
                if (numberChoosen.thirtyOne > 0 && count0Made == false)
                {
                    numberChoosen.thirtyOne = numberChoosen.thirtyOne * multiplier;
                    finalTotal = finalTotal + numberChoosen.thirtyOne;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 32)
            {
                if (numberChoosen.thirtyTwo > 0 && count0Made == false)
                {
                    numberChoosen.thirtyTwo = numberChoosen.thirtyTwo * multiplier;
                    finalTotal = finalTotal + numberChoosen.thirtyTwo;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 33)
            {
                if (numberChoosen.thirtyThree > 0 && count0Made == false)
                {
                    numberChoosen.thirtyThree = numberChoosen.thirtyThree * multiplier;
                    finalTotal = finalTotal + numberChoosen.thirtyThree;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 34)
            {
                if (numberChoosen.thirtyFour > 0 && count0Made == false)
                {
                    numberChoosen.thirtyFour = numberChoosen.thirtyFour * multiplier;
                    finalTotal = finalTotal + numberChoosen.thirtyFour;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 35)
            {
                if (numberChoosen.thirtyFive > 0 && count0Made == false)
                {
                    numberChoosen.thirtyFive = numberChoosen.thirtyFive * multiplier;
                    finalTotal = finalTotal + numberChoosen.thirtyFive;
                    count0Made = true;
                }
            }
            else
            {

            }

            if (sortedNumber == 36)
            {
                if (numberChoosen.thirtySix > 0 && count0Made == false)
                {
                    numberChoosen.thirtySix = numberChoosen.thirtySix * multiplier;
                    finalTotal = finalTotal + numberChoosen.thirtySix;
                    count0Made = true;
                }
            }
            else
            {

            }
        }



        
        sortedNumberText.text = ("Number: " + sortedNumber.ToString());
        
    }



    [PunRPC]
    public void Rotate()
    {

        time += Time.deltaTime;

        roundActive = true;
        transform.Rotate(0, 0, speed * Time.deltaTime);

        if (speed > 0)
        {
            winResultText.text = "total win: ";
            loseResultText.text = "total lose: ";
            finalTotal = 0;
            countMade = false;
            count0Made = false;
            roundFinished = false;
            pointer.GetComponent<CapsuleCollider2D>().enabled = false;
            foreach (GameObject n in button_list)
            {
                n.GetComponent<Button>().interactable = false;
            }
        }

        
    }

    [PunRPC]
    public void Unlock()
    {
        roundFinished = true;
        numberSorted = false;
        foreach (GameObject n in button_list)
        {
            n.GetComponent<Button>().interactable = true;
        }
        timeText.text = "15 Seconds left!";
    }

    [PunRPC]
    public void Reset1()
    {
        isSpining = true;
        stopping = true;
        roundActive = true;
        speed = 300;
        time = 0;
        timeText.text = "Starting Round";
    }

    [PunRPC]
    public void Reset2()
    {
        roundFinished = false;
        numberChoosen.Clear();
    }

    [PunRPC]
    public void PreStop()
    {
        isSpining = false;
        timeText.text = "";
    }

    [PunRPC]
    public void Stop()
    {
        speed--;
        if (speed <= 0)
        {
            speed = 0;
            pointer.GetComponent<CapsuleCollider2D>().enabled = true;
            numberSorted = true;
        }

        
    }
}
