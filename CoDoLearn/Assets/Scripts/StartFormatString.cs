using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFormatString : MonoBehaviour
{
    [SerializeField]
    Text text;

    private void OnEnable()
    {
        text.text = string.Format("Мы будем изучать практические основы языка {0}. Научимся работать с числами, их последовательностями, таблицами, а также освоим несложные структуры данных и алгоритмы: сортировку, ассоциативные массивы, множества. У нас нет цели глубоко погрузиться во внутреннее устройство языка, поэтому даже после окончания курса в наших программах для вас останется немного необъяснимой «магии». Это нормально.",PlayerPrefsManager.GetCategory());
    }
}
