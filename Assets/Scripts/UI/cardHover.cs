using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class cardHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    [SerializeField] private float cardHoverDistance = 60;
    [SerializeField] private float timeToHover = 60.0f;


    private Vector3 initialHoverPos;
    private Vector3 initialDragPos;

    private cardInfo information;

    public plate plateInGame;

    void Awake()
    {
        information = GetComponent<cardInfo>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!CardHandManager.dragging)
        {
            
        
        
            GameObject pointerObject = eventData.pointerEnter.gameObject;
            Vector3 newPos = new Vector3(pointerObject.transform.position.x, pointerObject.transform.position.y + cardHoverDistance, pointerObject.transform.position.z);

            initialHoverPos = transform.position;


            if(pointerObject.GetComponent<UnityEngine.UI.Image>().sprite != null)
            {
                pointerObject.transform.position = Vector3.Lerp(pointerObject.transform.position, newPos, timeToHover);
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!CardHandManager.dragging)
        {
            
        
            GameObject pointerObject = eventData.pointerEnter.gameObject;

            if(pointerObject.GetComponent<UnityEngine.UI.Image>().sprite != null)
            {
                pointerObject.transform.position = Vector3.Lerp(pointerObject.transform.position, initialHoverPos, timeToHover);
            }
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        CardHandManager.dragging = true;
        initialDragPos = transform.position;

        eventData.pointerEnter.gameObject.transform.parent.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!plate.cardOverPlate)
        {
            transform.position = initialDragPos;
        }
        else
        {
            Debug.Log(information);
        }
        CardHandManager.dragging = false;

    }
}
