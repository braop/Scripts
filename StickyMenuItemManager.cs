using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StickyMenuItemManager : MonoBehaviour
{
    public RectTransform viewport;

    public RectTransform[] items;

    public GameObject toolBar;

    public TMP_Text stickyTitle;

    float toolBarYPosition = 0f;

    void Start()
    {
       toolBarYPosition = toolBar.transform.position.y; 
    }

    // Update is called once per frame
    void Update()
    {
       foreach (RectTransform item in items){

        float itemYPosition = item.position.y;

        if(itemYPosition > toolBarYPosition){

            // update title text in sticky panel
            stickyTitle.text = item.name;
        } else{

            // do nothing
        }

       }
    }
}
