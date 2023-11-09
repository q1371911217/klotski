using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public enum BlockDirection
{
    None,
    Up,
    Down,
    Left,
    Right,
}
public class Block : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    public bool isSolutionBlock;
    
    public int length;

    public int type;
    public  int x, y, offset;

    public BlockDirection blockDirection = BlockDirection.None;

    private Vector3 startMousePos;
    private Vector3 endMousePos;
    private bool isCheck = false;

    RectTransform rectTrans;
    RectTransform thisTrans;
    void Start()
    {
        rectTrans = this.transform.parent.GetComponent<RectTransform>();
        thisTrans = this.transform.GetComponent<RectTransform>();
    }

    public  void OnBeginDrag(PointerEventData eventData)
    {
        startMousePos = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        endMousePos = Input.mousePosition;
        //Debug.LogError((endMousePos - startMousePos).normalized);
        checkDireaction();
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isCheck) return;
        endMousePos = Input.mousePosition;
        dragEndPos = eventData.position;
        checkDireaction();
    }

    public void setType(int type)
    {
        this.type = type;
    }

    public void setGridPos(int x, int y, int offset)
    {
        this.x = x;
        this.y = y;
        this.offset = offset;
    }

    public void checkOver()
    {
        startMousePos = Input.mousePosition;
        isCheck = false;
        blockDirection = BlockDirection.None;
        
    }
    Vector3 dragEndPos;
    public void checkDireaction()
    {
        if (isCheck || blockDirection != BlockDirection.None) return;
        //Debug.LogError(RectTransformUtility.WorldToScreenPoint(Camera.main, dragEndPos));
        //Debug.LogError(Camera.main.WorldToScreenPoint(dragEndPos));
        Vector2 globalMousePos;
        //RectTransformUtility.ScreenPointToWorldPointInRectangle(this.transform.parent.GetComponent<RectTransform>(), Input.mousePosition, Camera.main, out globalMousePos);
        RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTrans, Input.mousePosition, Camera.main, out globalMousePos);

        //Debug.LogError(globalMousePos);
        //Vector3 direction = (endMousePos - startMousePos).normalized;
        //Debug.LogError(direction);
       
        if(type < 4)
        {
            if (thisTrans.anchoredPosition.x + 110 * offset < globalMousePos.x)
            //if (direction.x > 0.999f)
            {
                blockDirection = BlockDirection.Right;
            }
            if (thisTrans.anchoredPosition.x > globalMousePos.x)
            //else if (direction.x < -0.999f)
            {
                blockDirection = BlockDirection.Left;
            }
        }
        else
        {
            if (thisTrans.anchoredPosition.y < globalMousePos.y)
                    //if (direction.y > 0.999f)
             {
                blockDirection = BlockDirection.Up;
            }
            else if (thisTrans.anchoredPosition.y - 110 * offset > globalMousePos.y)
            //else if (direction.y < -0.999f)
            {
                blockDirection = BlockDirection.Down;
            }
            
        }    
        
        if(blockDirection != BlockDirection.None)
        {
            isCheck = true;
            SendMessageUpwards("move", this, SendMessageOptions.RequireReceiver);
        }
        
    }
}
