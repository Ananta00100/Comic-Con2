using DG.Tweening;
using UnityEngine;

public class RotationAnimation : MonoBehaviour
{
    private void Start()
    {
        transform.DORotate(new Vector3(0f, 360f, 0f), 10f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
    }
}
