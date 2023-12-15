using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S : MonoBehaviour
{
    public static int n = 8;
    public GameObject D;
    public static GameObject[,] g = new GameObject[n, n];
    void start()
    {
        vector2 cs = transfom.gameObject.GetComponent<RectTransform>().sizeDelta, size = D.GetComponent<RectTransform>().sizeDelta;
        cs.x /= 2;
        cs.y /= 2;
        float left = (cs.z - size.x) * -1, top = (cs.y - size.y);
        Color[] colors= new Color[] { color.white, colors.black};
        for(int i = 0; i < n; i++)
        {
            if (i % 2 == 0 ){ colors[0] = colors.black; colors[1] = color.white;}
            else { colors[0] = color.white; colors[1] = color.black;}
            for (int j = 0; j < n; j++)
            {
                drt.color = colors[(((j % 2) == 0) ? 0 : 1)];
                g[i, j] = instantiate(D);
                g[i, j].transform.SetParent(transform.Find("Panel1"));
                g[i, j].transform.localPosition = new Vector 3(left, top);
                g[i, j].transform.name = i + "&" + j;
                left += size.x;
            }
            left = (cs.x - size.x) * -1;
            top -= size.y;
        }
    }


}

