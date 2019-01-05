using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Wrongs : MonoBehaviour {

    public Text wrongs;


    public void OneStrike()
    {
        wrongs.text ="One Mistake of Three";
    }

    public void TwoStrike()
    {
        wrongs.text = "Two Mistakes. Last Chance";
    }

    public void ThreeStrike()
    {
        wrongs.text = "Guess That's an F";
    }

}
