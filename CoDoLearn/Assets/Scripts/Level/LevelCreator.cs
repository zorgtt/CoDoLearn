using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
    [SerializeField]
    private Level level;

    private bool flag;

    private Color color;


    public void CreateLevels(int levels)
    {
        flag = false;
        int index = 0;
        for (byte i = 0; i < 16; i++)
        {
            index = i + 1;

            if (i == 0)
            {
                if (levels > 0)
                    Instantiate(level, transform).Init("<b>Старт</b>", index, false, Color.green);
                else
                    Instantiate(level, transform).Init("<b>Старт</b>", index, true, Color.gray);
            }
            else if(i == 15)
            {
                if (levels == 15)
                    Instantiate(level, transform).Init("<b>Финал</b>", index, true, Color.blue);
                else
                    Instantiate(level, transform).Init("<b>Финал</b>", index, false, Color.red);
            }
            else
            {
                if(levels > i)
                    Instantiate(level, transform).Init("<b>Урок " + i.ToString() + "</b>", index, false, Color.green);
                if (levels == i)
                {
                    if(levels == 15)
                    Instantiate(level, transform).Init("<b>Урок " + i.ToString() + "</b>", index, false, Color.green);
                    else
                        Instantiate(level, transform).Init("<b>Урок " + i.ToString() + "</b>", index, true, Color.grey);
                }
                if(levels < i)
                    Instantiate(level, transform).Init("<b>Урок " + i.ToString() + "</b>", index, false, Color.red);
            }
        }
    }
}
