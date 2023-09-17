using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    
    [SerializeField] private Button BotaoJogar;

    GameObject MenuGameUI;

    private void Awake()
    {
        BotaoJogar.onClick.AddListener(OnButtonPlayClickJogar);
    }

    private void OnButtonPlayClickJogar()
    {
        Debug.Log("JOGAR");
    }

}
