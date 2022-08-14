using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Alarm : MonoBehaviour
{
   [SerializeField] private AudioSource _alarm;
   
   private float _volumeChangeAmount = 0.1f;
   private Coroutine _volumeChanger;
   private WaitForSeconds _waitForSeconds = new WaitForSeconds(0.15f);
   
   private void Start()
   {
      int beginVolume = 0;
      _alarm.volume = beginVolume;
   }

   public void StartVolumeChange(float targetVolume)
   {
      if (_volumeChanger != null)
         StopCoroutine(_volumeChanger);
      _volumeChanger = StartCoroutine(VolumeChange(targetVolume));
   }
   
   private IEnumerator VolumeChange(float targetVolume)
   {
      while (_alarm.volume != targetVolume)
      {
         _alarm.volume = Mathf.MoveTowards(_alarm.volume, targetVolume, _volumeChangeAmount);

         yield return _waitForSeconds;
      }
   }
}
   