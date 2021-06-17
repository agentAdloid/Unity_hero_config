using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public string myName;
    public GameObject currentSidePanel ;
    public GameObject rootSidePanel ;
    public GameObject TopFeatureButton;
    public GameObject TopBuildButton;
    public int showSidePanel = 0;
    // Start is called before the first frame update
    void Start()
    {   Debug.Log(myName);
        TopFeatureButton.SetActive(true);
    }
    

    public void goToParent()
    {
        GameObject par = currentSidePanel.transform.parent.gameObject;
        if (par == rootSidePanel)
        {
            togglePannel();
        }
        else
        {
            par = par.transform.parent.gameObject;
            GameObject show = par.transform.GetChild(0).gameObject;
            GameObject childs = par.transform.GetChild(1).gameObject;
            show.SetActive(true);
            childs.SetActive(false);
            currentSidePanel.SetActive(false);
            currentSidePanel = par;
        }
    }
    public void changeSidePanelto(GameObject g1)
    {
        showSidePanel = 1;
        rootSidePanel.SetActive(true);
        currentSidePanel.SetActive(false);
        currentSidePanel = g1;
        GameObject show = currentSidePanel.transform.GetChild(0).gameObject;
        GameObject childs = currentSidePanel.transform.GetChild(1).gameObject;
        show.SetActive(true);
        childs.SetActive(false);
        g1.SetActive(true);
        
    }
    public void goToChildPanel(GameObject ChildPanel)
    {
        GameObject show = currentSidePanel.transform.GetChild(0).gameObject;
        GameObject childs = currentSidePanel.transform.GetChild(1).gameObject;
        Debug.Log(show);
        show.SetActive(false);
        childs.SetActive(true);
        currentSidePanel = ChildPanel;
        show = currentSidePanel.transform.GetChild(0).gameObject;
        childs = currentSidePanel.transform.GetChild(1).gameObject;
        show.SetActive(true);
        childs.SetActive(false);
        currentSidePanel.SetActive(true);
    }
    public void togglePannel()
    {   if(showSidePanel==1)
        {
            showSidePanel = 0;
            rootSidePanel.SetActive(false);
        }
        else
        {
            showSidePanel = 1;
            rootSidePanel.SetActive(true);
        }
    }
    public void topBarSelected(int type)
    {   if(type==1)
        {   TopFeatureButton.SetActive(true);
            TopBuildButton.SetActive(false);
        }
        else if(type==2)
        {   TopFeatureButton.SetActive(false);
            TopBuildButton.SetActive(true);
        }
    }
}
