using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numberChoosen : MonoBehaviour
{
    public static float bet = 0;

    public static float totalBet;
    public Text totalBetText;

    public GameObject chip1;
    public GameObject chip2;
    public GameObject chip3;
    public GameObject chip4;
    public GameObject chip5;
    public GameObject chip6;

    public List<GameObject> oneToTwelve_1 = new List<GameObject>();
    public List<GameObject> oneToTwelve_2 = new List<GameObject>();
    public List<GameObject> oneToTwelve_3 = new List<GameObject>();
    public List<GameObject> blues = new List<GameObject>();
    public List<GameObject> blacks = new List<GameObject>();
    public List<GameObject> evens = new List<GameObject>();
    public List<GameObject> odds = new List<GameObject>();
    public List<GameObject> oneTo18 = new List<GameObject>();
    public List<GameObject> nineteenTo36 = new List<GameObject>();
    public List<GameObject> twoTo1_1 = new List<GameObject>();
    public List<GameObject> twoTo1_2 = new List<GameObject>();
    public List<GameObject> twoTo1_3 = new List<GameObject>();

    public static float zero;
    public static float one;
    public static float two;
    public static float three;
    public static float four;
    public static float five;
    public static float six;
    public static float seven;
    public static float eight;
    public static float nine;
    public static float ten;
    public static float eleven;
    public static float twelve;
    public static float thirteen;
    public static float fourteen;
    public static float fifteen;
    public static float sixteen;
    public static float seventeen;
    public static float eighteen;
    public static float nineteen;
    public static float twenty;
    public static float twentyOne;
    public static float twentyTwo;
    public static float twentyThree;
    public static float twentyFour;
    public static float twentyFive;
    public static float twentySix;
    public static float twentySeven;
    public static float twentyEight;
    public static float twentyNine;
    public static float thirty;
    public static float thirtyOne;
    public static float thirtyTwo;
    public static float thirtyThree;
    public static float thirtyFour;
    public static float thirtyFive;
    public static float thirtySix;

    public void Update()
    {
        totalBetText.text = "total bet: " + totalBet.ToString("F2");
    }

    public void Number0()
    {
        zero = zero + bet;
        totalBet = totalBet + bet;
    }
    public void Number1()
    {
        one = one + bet;
        totalBet = totalBet + bet;
    }

    public void Number2()
    {
        two = two + bet;
        totalBet = totalBet + bet;
    }

    public void Number3()
    {
        three = three + bet;
        totalBet = totalBet + bet;
    }

    public void Number4()
    {
        four = four + bet;
        totalBet = totalBet + bet;
    }

    public void Number5()
    {
        five = five + bet;
        totalBet = totalBet + bet;
    }

    public void Number6()
    {
        six = six + bet;
        totalBet = totalBet + bet;
    }

    public void Number7()
    {
        seven = seven + bet;
        totalBet = totalBet + bet;
    }

    public void Number8()
    {
        eight = eight + bet;
        totalBet = totalBet + bet;
    }

    public void Number9()
    {
        nine = nine + bet;
        totalBet = totalBet + bet;
    }

    public void Number10()
    {
        ten = ten + bet;
        totalBet = totalBet + bet;
    }

    public void Number11()
    {
        eleven = eleven + bet;
        totalBet = totalBet + bet;
    }

    public void Number12()
    {
        twelve = twelve + bet;
        totalBet = totalBet + bet;
    }

    public void Number13()
    {
        thirteen = thirteen + bet;
        totalBet = totalBet + bet;
    }

    public void Number14()
    {
        fourteen = fourteen + bet;
        totalBet = totalBet + bet;
    }

    public void Number15()
    {
        fifteen = fifteen + bet;
        totalBet = totalBet + bet;
    }

    public void Number16()
    {
        sixteen = sixteen + bet;
        totalBet = totalBet + bet;
    }

    public void Number17()
    {
        seventeen = seventeen + bet;
        totalBet = totalBet + bet;
    }

    public void Number18()
    {
        eighteen = eighteen + bet;
        totalBet = totalBet + bet;
    }

    public void Number19()
    {
        nineteen = nineteen + bet;
        totalBet = totalBet + bet;
    }

    public void Number20()
    {
        twenty = twenty + bet;
        totalBet = totalBet + bet;
    }

    public void Number21()
    {
        twentyOne = twentyOne + bet;
        totalBet = totalBet + bet;
    }

    public void Number22()
    {
        twentyTwo = twentyTwo + bet;
        totalBet = totalBet + bet;
    }

    public void Number23()
    {
        twentyThree = twentyThree + bet;
        totalBet = totalBet + bet;
    }
    public void Number24()
    {
        twentyFour = twentyFour + bet;
        totalBet = totalBet + bet;
    }

    public void Number25()
    {
        twentyFive = twentyFive + bet;
        totalBet = totalBet + bet;
    }

    public void Number26()
    {
        twentySix = twentySix + bet;
        totalBet = totalBet + bet;
    }
    public void Number27()
    {
        twentySeven = twentySeven + bet;
        totalBet = totalBet + bet;
    }

    public void Number28()
    {
        twentyEight = twentyEight + bet;
        totalBet = totalBet + bet;
    }
    public void Number29()
    {
        twentyNine = twentyNine + bet;
        totalBet = totalBet + bet;
    }
    public void Number30()
    {
        thirty = thirty + bet;
        totalBet = totalBet + bet;
    }
    public void Number31()
    {
        thirtyOne = thirtyOne + bet;
        totalBet = totalBet + bet;
    }
    public void Number32()
    {
        thirtyTwo = thirtyTwo + bet;
        totalBet = totalBet + bet;
    }
    public void Number33()
    {
        thirtyThree = thirtyThree + bet;
        totalBet = totalBet + bet;
    }
    public void Number34()
    {
        thirtyFour = thirtyFour + bet;
        totalBet = totalBet + bet;
    }
    public void Number35()
    {
        thirtyFive = thirtyFive + bet;
        totalBet = totalBet + bet;
    }
    public void Number36()
    {
        thirtySix = thirtySix + bet;
        totalBet = totalBet + bet;
    }


    public void st12()
    {
        totalBet = totalBet + bet;
        float eachValue = bet / 12;

        one = one + eachValue;
        two = two + eachValue;
        three = three + eachValue;
        four = four + eachValue;
        five = five + eachValue;
        six = six + eachValue;
        seven = seven + eachValue;
        eight = eight + eachValue;
        nine = nine + eachValue;
        ten = ten + eachValue;
        eleven = eleven + eachValue;
        twelve = twelve + eachValue;
    }
    public void nd12()
    {
        totalBet = totalBet + bet;
        float eachValue = bet / 12;

        thirteen = thirteen + eachValue;
        fourteen = fourteen + eachValue;
        fifteen = fifteen + eachValue;
        sixteen = sixteen + eachValue;
        seventeen = seventeen + eachValue;
        eighteen = eighteen + eachValue;
        nineteen = nineteen + eachValue;
        twenty = twenty + eachValue;
        twentyOne = twentyOne + eachValue;
        twentyTwo = twentyTwo + eachValue;
        twentyThree = twentyThree + eachValue;
        twentyFour = twentyFour + eachValue;
    }
    public void rd12()
    {
        totalBet = totalBet + bet;
        float eachValue = bet / 12;

        twentyFive = twentyFive + eachValue;
        twentySix = twentySix + eachValue;
        twentySeven = twentySeven + eachValue;
        twentyEight = twentyEight + eachValue;
        twentyNine = twentyNine + eachValue;
        thirty = thirty + eachValue;
        thirtyOne = thirtyOne + eachValue;
        thirtyTwo = thirtyTwo + eachValue;
        thirtyThree = thirtyThree + eachValue;
        thirtyFour = thirtyFour + eachValue;
        thirtyFive = thirtyFive + eachValue;
        thirtySix = thirtySix + eachValue;
    }

    public void Blue()
    {
        totalBet = totalBet + bet;
        float eachValue = bet / 18;

        one = one + eachValue;
        three = three + eachValue;
        five = five + eachValue;
        seven = seven + eachValue;
        nine = nine + eachValue;
        twelve = twelve + eachValue;
        fourteen = fourteen + eachValue;
        sixteen = sixteen + eachValue;
        eighteen = eighteen + eachValue;
        nineteen = nineteen + eachValue;
        twentyOne = twentyOne + eachValue;
        twentyThree = twentyThree + eachValue;
        twentyFive = twentyFive + eachValue;
        twentySeven = twentySeven + eachValue;
        thirty = thirty + eachValue;
        thirtyTwo = thirtyTwo + eachValue;
        thirtyFour = thirtyFour + eachValue;
        thirtySix = thirtySix + eachValue;
    }
    public void Black()
    {
        totalBet = totalBet + bet;
        float eachValue = bet / 18;

        two = two + eachValue;
        four = four + eachValue;
        six = six + eachValue;
        eight = eight + eachValue;
        ten = ten + eachValue;
        eleven = eleven + eachValue;
        thirteen = thirteen + eachValue;
        fifteen = fifteen + eachValue;
        seventeen = seventeen + eachValue;
        twenty = twenty + eachValue;
        twentyTwo = twentyTwo + eachValue;
        twentyFour = twentyFour + eachValue;
        twentySix = twentySix + eachValue;
        twentyEight = twentyEight + eachValue;
        twentyNine = twentyNine + eachValue;
        thirtyOne = thirtyOne + eachValue;
        thirtyThree = thirtyThree + eachValue;
        thirtyFive = thirtyFive + eachValue;
    }
    public void Odd()
    {
        totalBet = totalBet + bet;
        float eachValue = bet / 18;

        one = one + eachValue;
        three = three + eachValue;
        five = five + eachValue;
        seven = seven + eachValue;
        nine = nine + eachValue;
        eleven = eleven + eachValue;
        thirteen = thirteen + eachValue;
        fifteen = fifteen + eachValue;
        seventeen = seventeen + eachValue;
        nineteen = nineteen + eachValue;
        twentyOne = twentyOne + eachValue;
        twentyThree = twentyThree + eachValue;
        twentyFive = twentyFive + eachValue;
        twentySeven = twentySeven + eachValue;
        twentyNine = twentyNine + eachValue;
        thirtyOne = thirtyOne + eachValue;
        thirtyThree = thirtyThree + eachValue;
        thirtyFive = thirtyFive + eachValue;
    }
    public void Even()
    {
        totalBet = totalBet + bet;
        float eachValue = bet / 18;

        two = two + eachValue;
        four = four + eachValue;
        six = six + eachValue;
        eight = eight + eachValue;
        ten = ten + eachValue;
        twelve = twelve + eachValue;
        fourteen = fourteen + eachValue;
        sixteen = sixteen + eachValue;
        eighteen = eighteen + eachValue;
        twenty = twenty + eachValue;
        twentyTwo = twentyTwo + eachValue;
        twentyFour = twentyFour + eachValue;
        twentySix = twentySix + eachValue;
        twentyEight = twentyEight + eachValue;
        thirty = thirty + eachValue;
        thirtyTwo = thirtyTwo + eachValue;
        thirtyFour = thirtyFour + eachValue;
        thirtySix = thirtySix + eachValue;
    }
    public void OneToEighteen()
    {
        totalBet = totalBet + bet;
        float eachValue = bet / 18;

        one = one + eachValue;
        two = two + eachValue;
        three = three + eachValue;
        four = four + eachValue;
        five = five + eachValue;
        six = six + eachValue;
        seven = seven + eachValue;
        eight = eight + eachValue;
        nine = nine + eachValue;
        ten = ten + eachValue;
        eleven = eleven + eachValue;
        twelve = twelve + eachValue;
        thirteen = thirteen + eachValue;
        fourteen = fourteen + eachValue;
        fifteen = fifteen + eachValue;
        sixteen = sixteen + eachValue;
        seventeen = seventeen + eachValue;
        eighteen = eighteen + eachValue;
    }
    public void NineteenToThirtySix()
    {
        totalBet = totalBet + bet;
        float eachValue = bet / 18;

        nineteen = nineteen + eachValue;
        twenty = twenty + eachValue;
        twentyOne = twentyOne + eachValue;
        twentyTwo = twentyTwo + eachValue;
        twentyThree = twentyThree + eachValue;
        twentyFour = twentyFour + eachValue;
        twentyFive = twentyFive + eachValue;
        twentySix = twentySix + eachValue;
        twentySeven = twentySeven + eachValue;
        twentyEight = twentyEight + eachValue;
        twentyNine = twentyNine + eachValue;
        thirty = thirty + eachValue;
        thirtyOne = thirtyOne + eachValue;
        thirtyTwo = thirtyTwo + eachValue;
        thirtyThree = thirtyThree + eachValue;
        thirtyFour = thirtyFour + eachValue;
        thirtyFive = thirtyFive + eachValue;
        thirtySix = thirtySix + eachValue;
    }
    public void twoToOne1()
    {
        totalBet = totalBet + bet;
        float eachValue = bet / 12;

        three = three + eachValue;
        six = six + eachValue;
        nine = nine + eachValue;
        twelve = twelve + eachValue;
        fifteen = fifteen + eachValue;
        eighteen = eighteen + eachValue;
        twentyOne = twentyOne + eachValue;
        twentyFour = twentyFour + eachValue;
        twentySeven = twentySeven + eachValue;
        thirty = thirty + eachValue;
        thirtyThree = thirtyThree + eachValue;
        thirtySix = thirtySix + eachValue;
    }
    public void twoToOne2()
    {
        totalBet = totalBet + bet;
        float eachValue = bet / 12;

        two = two + eachValue;
        five = five + eachValue;
        eight = eight + eachValue;
        eleven = eleven + eachValue;
        fourteen = fourteen + eachValue;
        seventeen = seventeen + eachValue;
        twenty = twenty + eachValue;
        twentyThree = twentyThree + eachValue;
        twentySix = twentySix + eachValue;
        twentyNine = twentyNine + eachValue;
        thirtyTwo = thirtyTwo + eachValue;
        thirtyFive = thirtyFive + eachValue;
    }
    public void twoToOne3()
    {
        totalBet = totalBet + bet;
        float eachValue = bet / 12;

        one = one + eachValue;
        four = four + eachValue;
        seven = seven + eachValue;
        ten = ten + eachValue;
        thirteen = thirteen + eachValue;
        sixteen = sixteen + eachValue;
        nineteen = nineteen + eachValue;
        twentyTwo = twentyTwo + eachValue;
        twentyFive = twentyFive + eachValue;
        twentyEight = twentyEight + eachValue;
        thirtyOne = thirtyOne + eachValue;
        thirtyFour = thirtyFour + eachValue;
    }
    public void buttonColor1()
    {
        foreach (GameObject n in oneToTwelve_1)
        {
            n.GetComponent<Button>().interactable = false;
        }
    }

    public void buttonColor1_2()
    {
        foreach (GameObject n in oneToTwelve_1)
        {
            n.GetComponent<Button>().interactable = true;
        }
    }

    public void buttonColor2()
    {
        foreach (GameObject n in oneToTwelve_2)
        {
            n.GetComponent<Button>().interactable = false;
        }
    }

    public void buttonColor2_2()
    {
        foreach (GameObject n in oneToTwelve_2)
        {
            n.GetComponent<Button>().interactable = true;
        }
    }

    public void buttonColor3()
    {
        foreach (GameObject n in oneToTwelve_3)
        {
            n.GetComponent<Button>().interactable = false;
        }
    }

    public void buttonColor3_2()
    {
        foreach (GameObject n in oneToTwelve_3)
        {
            n.GetComponent<Button>().interactable = true;
        }
    }

    public void buttonColor4()
    {
        foreach (GameObject n in blues)
        {
            n.GetComponent<Button>().interactable = false;
        }
    }

    public void buttonColor4_2()
    {
        foreach (GameObject n in blues)
        {
            n.GetComponent<Button>().interactable = true;
        }
    }

    public void buttonColor5()
    {
        foreach (GameObject n in blacks)
        {
            n.GetComponent<Button>().interactable = false;
        }
    }

    public void buttonColor5_2()
    {
        foreach (GameObject n in blacks)
        {
            n.GetComponent<Button>().interactable = true;
        }
    }

    public void buttonColor6()
    {
        foreach (GameObject n in evens)
        {
            n.GetComponent<Button>().interactable = false;
        }
    }

    public void buttonColor6_2()
    {
        foreach (GameObject n in evens)
        {
            n.GetComponent<Button>().interactable = true;
        }
    }

    public void buttonColor7()
    {
        foreach (GameObject n in odds)
        {
            n.GetComponent<Button>().interactable = false;
        }
    }

    public void buttonColor7_2()
    {
        foreach (GameObject n in odds)
        {
            n.GetComponent<Button>().interactable = true;
        }
    }

    public void buttonColor8()
    {
        foreach (GameObject n in oneTo18)
        {
            n.GetComponent<Button>().interactable = false;
        }
    }

    public void buttonColor8_2()
    {
        foreach (GameObject n in oneTo18)
        {
            n.GetComponent<Button>().interactable = true;
        }
    }

    public void buttonColor9()
    {
        foreach (GameObject n in nineteenTo36)
        {
            n.GetComponent<Button>().interactable = false;
        }
    }

    public void buttonColor9_2()
    {
        foreach (GameObject n in nineteenTo36)
        {
            n.GetComponent<Button>().interactable = true;
        }
    }

    public void buttonColor10()
    {
        foreach (GameObject n in twoTo1_1)
        {
            n.GetComponent<Button>().interactable = false;
        }
    }

    public void buttonColor10_2()
    {
        foreach (GameObject n in twoTo1_1)
        {
            n.GetComponent<Button>().interactable = true;
        }
    }

    public void buttonColor11()
    {
        foreach (GameObject n in twoTo1_2)
        {
            n.GetComponent<Button>().interactable = false;
        }
    }

    public void buttonColor11_2()
    {
        foreach (GameObject n in twoTo1_2)
        {
            n.GetComponent<Button>().interactable = true;
        }
    }

    public void buttonColor12()
    {
        foreach (GameObject n in twoTo1_3)
        {
            n.GetComponent<Button>().interactable = false;
        }
    }

    public void buttonColor12_2()
    {
        foreach (GameObject n in twoTo1_3)
        {
            n.GetComponent<Button>().interactable = true;
        }
    }

    public void Chip1()
    {
        bet = 0.01f;
        chip1.gameObject.GetComponent<Button>().interactable = false;
        chip2.gameObject.GetComponent<Button>().interactable = true;
        chip3.gameObject.GetComponent<Button>().interactable = true;
        chip4.gameObject.GetComponent<Button>().interactable = true;
        chip5.gameObject.GetComponent<Button>().interactable = true;
        chip6.gameObject.GetComponent<Button>().interactable = true;
    }

    public void Chip2()
    {
        bet = 0.05f;
        chip1.gameObject.GetComponent<Button>().interactable = true;
        chip2.gameObject.GetComponent<Button>().interactable = false;
        chip3.gameObject.GetComponent<Button>().interactable = true;
        chip4.gameObject.GetComponent<Button>().interactable = true;
        chip5.gameObject.GetComponent<Button>().interactable = true;
        chip6.gameObject.GetComponent<Button>().interactable = true;
    }

    public void Chip3()
    {
        bet = 0.1f;
        chip1.gameObject.GetComponent<Button>().interactable = true;
        chip2.gameObject.GetComponent<Button>().interactable = true;
        chip3.gameObject.GetComponent<Button>().interactable = false;
        chip4.gameObject.GetComponent<Button>().interactable = true;
        chip5.gameObject.GetComponent<Button>().interactable = true;
        chip6.gameObject.GetComponent<Button>().interactable = true;
    }

    public void Chip4()
    {
        bet = 0.25f;
        chip1.gameObject.GetComponent<Button>().interactable = true;
        chip2.gameObject.GetComponent<Button>().interactable = true;
        chip3.gameObject.GetComponent<Button>().interactable = true;
        chip4.gameObject.GetComponent<Button>().interactable = false;
        chip5.gameObject.GetComponent<Button>().interactable = true;
        chip6.gameObject.GetComponent<Button>().interactable = true;
    }

    public void Chip5()
    {
        bet = 0.5f;
        chip1.gameObject.GetComponent<Button>().interactable = true;
        chip2.gameObject.GetComponent<Button>().interactable = true;
        chip3.gameObject.GetComponent<Button>().interactable = true;
        chip4.gameObject.GetComponent<Button>().interactable = true;
        chip5.gameObject.GetComponent<Button>().interactable = false;
        chip6.gameObject.GetComponent<Button>().interactable = true;
    }

    public void Chip6()
    {
        bet = 1f;
        chip1.gameObject.GetComponent<Button>().interactable = true;
        chip2.gameObject.GetComponent<Button>().interactable = true;
        chip3.gameObject.GetComponent<Button>().interactable = true;
        chip4.gameObject.GetComponent<Button>().interactable = true;
        chip5.gameObject.GetComponent<Button>().interactable = true;
        chip6.gameObject.GetComponent<Button>().interactable = false;
    }

    public static void Clear()
    {
        totalBet = 0f;
        zero = 0f;
        one = 0f;
        two = 0f;
        three = 0f;
        four = 0f;
        five = 0f;
        six = 0f;
        seven = 0f;
        eight = 0f;
        nine = 0f;
        ten = 0f;
        eleven = 0f;
        twelve = 0f;
        thirteen = 0f;
        fourteen = 0f;
        fifteen = 0f;
        sixteen = 0f;
        seventeen = 0f;
        eighteen = 0f;
        nineteen = 0f;
        twenty = 0f;
        twentyOne = 0f;
        twentyTwo = 0f;
        twentyThree = 0f;
        twentyFour = 0f;
        twentyFive = 0f;
        twentySix = 0f;
        twentySeven = 0f;
        twentyEight = 0f;
        twentyNine = 0f;
        thirty = 0f;
        thirtyOne = 0f;
        thirtyTwo = 0f;
        thirtyThree = 0f;
        thirtyFour = 0f;
        thirtyFive = 0f;
        thirtySix = 0f;
    }
    public void Double2x()
    {

    }
}
