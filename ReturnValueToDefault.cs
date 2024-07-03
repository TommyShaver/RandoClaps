using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ReturnValueToDefault : MonoBehaviour ,IPointerClickHandler , IPointerEnterHandler , IPointerExitHandler
{
    //if the player double clicks a silder set it back to deafult value
    [SerializeField] private float _defaultValue;
    [SerializeField] private float _scrollWheelSpeed = 0.1f;
    private float _lastClickTime = 0f;
    private float _doubleClickThreshold = 0.3f;
    private bool _isHovering;

    public UnityEngine.UI.Slider _slider;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.clickCount == 2)
        {
            SliderValueDefault(_defaultValue);
        }
        else if (eventData.clickCount == 1)
        {
            float timeSinceLastClick = Time.time - _lastClickTime;

            if (timeSinceLastClick <= _doubleClickThreshold)
            {
                SliderValueDefault(_defaultValue);
                Debug.Log("Double Click Detected");
                // Perform your double-click action here
            }
            else
            {
                _lastClickTime = Time.time;
            }
        }
    }

    private void SliderValueDefault(float vaule)
    {
        if(_slider != null)
        {
            _slider.value = vaule;
        }
        else
        {
            Debug.Log("[Return To Defaul] - SliderValueDefault: Slider is null ");
        }
    }

    private void Update()
    {
        if(_isHovering)
        {
            float _scroll = Input.GetAxis("Mouse ScrollWheel");
            if (_scroll != 0)
            {
                _slider.value += _scroll * _scrollWheelSpeed;
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _isHovering = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _isHovering = false;
    }
}

