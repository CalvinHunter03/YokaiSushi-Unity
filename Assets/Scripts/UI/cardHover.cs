using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class cardHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    [SerializeField] private float cardHoverDistance = 60;
    [SerializeField] private float timeToHover = 60.0f;


    private Vector3 initialPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

        
        GameObject pointerObject = eventData.pointerEnter.gameObject;
        Vector3 newPos = new Vector3(pointerObject.transform.position.x, pointerObject.transform.position.y + cardHoverDistance, pointerObject.transform.position.z);

        initialPos = transform.position;


        if(pointerObject.GetComponent<UnityEngine.UI.Image>().sprite != null)
        {
            pointerObject.transform.position = Vector3.Lerp(pointerObject.transform.position, newPos, timeToHover);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        GameObject pointerObject = eventData.pointerEnter.gameObject;

        if(pointerObject.GetComponent<UnityEngine.UI.Image>().sprite != null)
        {
            pointerObject.transform.position = Vector3.Lerp(pointerObject.transform.position, initialPos, timeToHover);
        }
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = initialPos;
    }
}
