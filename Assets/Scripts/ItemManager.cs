using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public Animator[] animators;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveItemDown(int itemIndex) {
        this.animators[itemIndex].SetBool("canMoveDown", true);
    }
}
