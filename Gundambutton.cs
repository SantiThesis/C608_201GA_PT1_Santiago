using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Gundambutton : MonoBehaviour
{
    public UI characterScript;
    public Sprite[] spriteToChangeTo;
    public Image GundamImage; 
    
    public void SetData(Gundam gundam)
    {
        GundamImage = GetComponent<Image>();
        characterScript = FindAnyObjectByType<UI>();
        GundamImage.sprite = spriteToChangeTo[gundam.imageValue];
    }


}