using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Poäng : MonoBehaviour
{
    int Points = 20;

    [SerializeField]
    GameObject Poeng;

    TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {
        Text = Poeng.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        string LiveText = "Poäng; " + Points;
        Text.text = LiveText;
    }

    // Försökte göra så att poängen går upp när man träffar ett block men hann inte
    public void hit2()
    {
        Points = Points + 50;
    }
}
