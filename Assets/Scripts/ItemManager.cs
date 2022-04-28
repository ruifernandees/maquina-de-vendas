using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class ItemManager : MonoBehaviour
{
    public Animator[] animators;
    public GameObject[] arrowes;
    public SpriteRenderer initialState;
    public Sprite initialStateNormalColor;
    public Sprite initialStateGrayscale;
    private int currentAnimator = -1;

    // Start is called before the first frame update
    void Start()
    {
        this.initialState.sprite = this.initialStateGrayscale; 
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
                this.initialState.sprite = this.initialStateGrayscale;
            }
        }
    }

    public void moveItemDown(int itemIndex) {
        if (this.currentAnimator != -1) return;
        this.initialState.sprite = this.initialStateNormalColor;
        this.animators[itemIndex].SetBool("canMoveDown", true);
        this.arrowes[itemIndex].SetActive(true);
        this.currentAnimator = itemIndex; 
    }
}
