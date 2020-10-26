using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour, IPointerClickHandler
{
    public Button btn;
    public Sprite onSptite;
    public Sprite offSprite;
    private bool on = true;
    private AudioSource back;
    
    
   
   void Start()
   {
       back = FindObjectOfType<AudioSource>();
       if (back.mute)
       {
           btn.image.sprite = offSprite;
       }
       else
       {
           btn.image.sprite = onSptite;  
       }
   }

   

   private void SetLevel()
   {
       back.mute = !back.mute;
       if (back.mute)
       {
           btn.image.sprite = offSprite;
       }
       else btn.image.sprite = onSptite;

       

   }

   public void OnPointerClick(PointerEventData eventData)
   {
       SetLevel();
   }
}
