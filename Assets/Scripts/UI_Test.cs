using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Test : MonoBehaviour
{

    public Image img;
    public Button btn;
    public Slider slider;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        // �̹��� ����
        img.color = Color.white;
        img.color = new Color(0.5f, 0.5f, 0.5f);
        //img.sprite =null;

        //�����̴� ���� Ȱ��ȭ, min, max, valuse
        //slider.interactable = true;
        //slider.interactable = false;
        slider.minValue = 0;
        slider.maxValue = 100;
        slider.value = 0;

        //�ؽ�Ʈ
        text.text = "�ȳ��ϼ���.";
        text.fontStyle = FontStyle.Bold;
        text.fontSize = 100;
        text.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
