using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LoockItem : MonoBehaviour, IPointerEnterHandler,
    IPointerExitHandler, IGvrPointerHoverHandler
{
    public void OnGvrPointerHover(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnLookItemBox(bool isLookAt)
    {
        Debug.Log(isLookAt);
        MoveCtrl.isStopped = isLookAt;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        MoveCtrl.isStopped = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        MoveCtrl.isStopped = true;
    }
    public void OnPointerHover(PointerEventData eventData)
    {
        Debug.Log("Retic On");
    }

}