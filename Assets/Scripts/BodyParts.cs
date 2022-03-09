using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyParts : MonoBehaviour
{
    public Image iconBrain;
    public Image iconHeart;


    void Start()
    {
        iconBrain.color = new Color(1, 1, 1, 0.3f);
        iconHeart.color = new Color(1, 1, 1, 0.3f);
    }

    public void OnBrainFound()
    {
        iconBrain.color = new Color(1, 1, 1, 1);
    }

    public void OnHeartFound()
    {
        iconHeart.color = new Color(1, 1, 1, 1);
    }
}
