using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Netcode;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Button startHostButton;

    [SerializeField]
    private Button startServerButton;

    [SerializeField]
    private Button startClientButton;

    [SerializeField]
    private TextMeshProUGUI playersInGameText;

    private void Awake()
    {
        Cursor.visible = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        startHostButton.onClick.AddListener(() => {
            if(NetworkManager.Singleton.StartHost()){
                
            }
            else{
    
            }
        });
        startServerButton.onClick.AddListener(() => {
             if(NetworkManager.Singleton.StartServer()){
                
             }
             else{

             }   
        });
        startClientButton.onClick.AddListener(() => {
              if(NetworkManager.Singleton.StartClient()){

              }
              else{
    
              }  
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
