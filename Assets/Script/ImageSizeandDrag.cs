using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ImageSizeandDrag : MonoBehaviour, IDragHandler
{
    public GameObject sizeSliderY;
    public GameObject sizeSliderX;
    public GameObject imageHolder;
    private RectTransform rTransForm;
    public Canvas canv;

    public void changeSize()
    {
        float posX = imageHolder.GetComponent<Transform>().localPosition.x;
        float sizeX = sizeSliderX.GetComponent<Slider>().value;
        float sizeY = sizeSliderY.GetComponent<Slider>().value;

        if(posX < 0)
            imageHolder.transform.localScale = new Vector2(sizeX, sizeY);
    }

    void Start()
    {
        rTransForm = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData data)
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        mousePosition.x = Mathf.Clamp(mousePosition.x, 0 + rTransForm.rect.width / 2, Screen.width - rTransForm.rect.width / 2);
        mousePosition.y = Mathf.Clamp(mousePosition.y, 0 + rTransForm.rect.height / 2, Screen.height - rTransForm.rect.height / 2);

        rTransForm.position = mousePosition;
    }
}
