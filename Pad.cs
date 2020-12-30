using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pad : MonoBehaviour,IPointerDownHandler, IPointerUpHandler,IDragHandler
{
    [SerializeField] private RectTransform rect_Background;
    [SerializeField] private RectTransform rect_Joystick;

    private float radius;
    private bool isTouch = false;
    private Vector3 movePosition;


    [SerializeField] private GameObject go_Player;
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        radius = rect_Background.rect.width * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
       if(isTouch) 
        
        go_Player.transform.position += movePosition;


        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isTouch = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isTouch = false;

        rect_Joystick.localPosition = Vector3.zero;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 value = eventData.position - (Vector2)rect_Background.position;
        value = Vector2.ClampMagnitude(value, radius);

        rect_Joystick.localPosition = value;
        value = value.normalized;
        movePosition = new Vector3(value.x * moveSpeed * Time.deltaTime, value.y * moveSpeed * Time.deltaTime, 0);
    }
}
