using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class HabitatPossition : MonoBehaviour
{
    public Slider slider;
    public Transform capsule;


    void Start()
    {
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    void OnSliderValueChanged(float value)
    {
        capsule.rotation = Quaternion.Euler(0, 0, value * 360f);
    }
}
