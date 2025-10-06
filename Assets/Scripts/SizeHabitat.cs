using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HabitatScaler : MonoBehaviour
{
    public GameObject habitat; // cilindro
    public Slider sizeSlider;
    public TextMeshProUGUI valueText;

    private Vector3 baseScale; // guarda la escala original del cilindro

    void Start()
    {
        // Guardar la escala original
        baseScale = habitat.transform.localScale;

        // Configurar el slider para que empiece en el valor central
        sizeSlider.minValue = 0.5f;   // 50% del tamaño original
        sizeSlider.maxValue = 1.5f;   // 150% del tamaño original
        sizeSlider.value = 1.0f;      // posición inicial en el medio

        sizeSlider.onValueChanged.AddListener(UpdateScale);
        UpdateScale(sizeSlider.value);
    }

    void UpdateScale(float value)
    {
        // Escalar el cilindro proporcionalmente al tamaño base
        habitat.transform.localScale = baseScale * value;

        float radius = (baseScale.x * value) / 2f; // Radio es la mitad del diámetro (escala x)
        float area = Mathf.PI * radius * radius; // Área del círculo: πr²

        // Actualizar el texto
        valueText.text = $"Area: {area:F2} m2%";
    }
}