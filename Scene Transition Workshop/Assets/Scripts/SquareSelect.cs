using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SquareSelect : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] RectTransform selector;
    [SerializeField] int colorNumber;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        selector.position = transform.position;
    }
}
