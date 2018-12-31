using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellUI : MonoBehaviour {

    public Text spell;
    public Text descript;

    private void Start()
    {
        spell.text = "";
        descript.text = "";
    }
    void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            spell.text = "Element";
            descript.text = "/ˈel.ɪ.mənt/  Invokes one of the main witchly elements, like fire, water, etc.";
        }
        else if (Input.GetKey(KeyCode.S))
        {
            spell.text = "Matter";
            descript.text = "/ˈmæt.ər/  Breaks something into its basic components. It is also used to mix them when needed.";
        }
        else if (Input.GetKey(KeyCode.D))
        {
            spell.text = "Death";
            descript.text = "/deθ/  Observes the moment of someone's death. Connection is almost impossible after four days.";
        }
        else if (Input.GetKey(KeyCode.W))
        {
            spell.text = "Mind";
            descript.text = "/maɪnd/  Reads the surface of someone's mind. Stronger witches and warlocks can manipulate thoughts, albeit illegal";
        }
        else if (Input.GetKey(KeyCode.X))
        {
            spell.text = "Time";
            descript.text = "/taɪm/  Reverses or advances time of an object or the self.";
        }
        else
        {
            spell.text = "";
            descript.text = "";
        }
    }

}
