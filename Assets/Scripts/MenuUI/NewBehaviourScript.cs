using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class NewBehaviourScript : MonoBehaviour
{
    public RectTransform mainMenu, playMenu, signupMenu, levelupMenu;
    public float uiSlideSpeed;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        mainMenu.DOAnchorPos(new Vector2(-1920,0),uiSlideSpeed).SetEase(Ease.Linear);
        playMenu.DOAnchorPos(Vector2.zero, uiSlideSpeed).SetEase(Ease.Linear);
    }

    public void closeSignUP()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(signupMenu.DOScale(Vector2.zero,5f));
        playMenu.DOAnchorPos(Vector2.zero, uiSlideSpeed).SetEase(Ease.Linear);
        seq.Append(signupMenu.DOScale(Vector2.one, 5f));
    }
}
