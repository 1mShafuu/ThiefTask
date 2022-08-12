using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectThief : MonoBehaviour
{
   [SerializeField] private AudioSource _alarm;
   
   private float _volumeScale = 0.1f;
   private float _runningTime;

   private void Start()
   {
      int beginVolume = 0;
      _alarm.volume = beginVolume;
   }

   private void OnTriggerEnter2D(Collider2D col)
   {
      StartCoroutine(VolumeUp());
   }

   private void OnTriggerExit2D(Collider2D other)
   {
      StartCoroutine(VolumeDown());
   }

   private IEnumerator VolumeDown()
   {
      float targetVolume = 0f;

      for (float index = _alarm.volume; index > targetVolume; index -= _volumeScale)
      {
         _alarm.volume = Mathf.MoveTowards(_alarm.volume, targetVolume, _volumeScale);

         yield return new WaitForSeconds(0.15f);
      }
   }

   private IEnumerator VolumeUp()
   {
      float targetVolume = 1f;

      for (float index = 0; index < targetVolume; index += _volumeScale)
      {
         _alarm.volume = Mathf.MoveTowards(_alarm.volume, targetVolume, _volumeScale);

         yield return new WaitForSeconds(0.15f);
      }
   }
}
