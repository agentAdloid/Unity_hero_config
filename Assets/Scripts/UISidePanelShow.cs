using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UISidePanelShow : MonoBehaviour
{
    // Start is called before the first frame update
    public int defaultSelected=0;
    void Start()
    {
        SelectChild(defaultSelected);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectChild(int ind)
    {
        defaultSelected = ind;
        if (ind == 0) return;
        GameObject g1= getContent();
        int ChildCount = g1.transform.childCount;
        for(int i=0;i<ChildCount;i++)
        {
            GameObject child = g1.transform.GetChild(i).gameObject;
            if (i == (ind-1))
            {   child.GetComponent<Image>().color = new Color32(238, 41, 41, 239);
            }
            else
            {
                child.GetComponent<Image>().color = new Color32(226, 218, 218, 255);
            }
        }
    }
    GameObject getContent()
    {
        GameObject g1;
        g1 = this.gameObject.transform.GetChild(0).gameObject;
        g1 = g1.transform.GetChild(0).gameObject;
        g1 = g1.transform.GetChild(0).gameObject;
        return g1;
    }
}
