using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class ItemManager : MonoBehaviour
{
    public Animator[] animators;
    public GameObject[] arrowes;
    private int currentAnimator = -1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (this.currentAnimator != -1) {
            if (this.animators[currentAnimator].GetBool("canClear")) {
                for (int i = 0;  i < arrowes.Length; i++) {
                    this.arrowes[i].SetActive(false);
                }
                this.animators[currentAnimator].SetBool("canClear", false);
                this.currentAnimator = -1;
            }
        }
    }

    public void moveItemDown(int itemIndex) {
        if (this.currentAnimator != -1) return;
        this.animators[itemIndex].SetBool("canMoveDown", true);
        this.arrowes[itemIndex].SetActive(true);
        this.currentAnimator = itemIndex; 
    }
}
