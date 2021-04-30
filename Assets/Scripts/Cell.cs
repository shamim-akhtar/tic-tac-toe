using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GMAI;

public class Cell : MonoBehaviour
{
    //public CellIndex RowCol;
    public int RowIndex;
    public int ColIndex;
    private bool active = false;

    public bool Used()
    {
        return active;
    }
    //private bool circle = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public int GetRowIndex()
    {
        return RowIndex;
    }
    public int GetColIndex()
    {
        return ColIndex;
    }

    public void Activate(bool is_computer)
    {
        if (active) return; // already active
        active = true;
        if(is_computer)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }

    public void Deactivate()
    {
        active = false;
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
    }
}
