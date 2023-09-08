using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SampleRotate : MonoBehaviour
{

    public Image image_1;
    public float dur;
    public float fadeDur;
    public Vector3 targetRot;

    public Image image_2;

    // Start is called before the first frame update
    void Start()
    {
        //Transition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotate()
    {
        image_1.transform.DOLocalRotate(targetRot, dur).SetEase(Ease.Linear).SetLoops(-1,LoopType.Incremental);
    }

    public void Fade()
    {
        image_1.DOFade(0, fadeDur).SetLoops(-1,LoopType.Restart);
        image_2 = image_1.GetComponentInChildren<Image>();
        image_2.DOFade(0, fadeDur).SetLoops(-1, LoopType.Restart);
    }

    public void Transition()
    {
        Sequence seq = DOTween.Sequence();

        //First Task
        seq.Append(image_1.transform.DOLocalMoveX(-335, 4.5f));
        //Delay for 2nd Task
        seq.AppendInterval(2);
        //Second Task
        seq.Append(image_1.transform.DOLocalRotate(targetRot, dur));
        //Delay for 3rd Task
        seq.AppendInterval(4);
        //Third Task
        seq.Append(image_1.DOFade(0, fadeDur).SetLoops(-1, LoopType.Restart));
    }
}
