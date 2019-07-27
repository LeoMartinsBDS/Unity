using System;
using UnityEngine;
using UnityEngine.UI;

public class altura_do_personagem : MonoBehaviour
{
    public Transform personagem;
    Text texto_da_interface;

    // Start is called before the first frame update
    void Start()
    {
        texto_da_interface = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(personagem.position.y);

        texto_da_interface.text = Math.Round(personagem.position.y).ToString();
    }
}
