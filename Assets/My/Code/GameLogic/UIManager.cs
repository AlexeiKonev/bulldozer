using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
  [SerializeField]  private GameObject _pausePanel;

    
     public void ShowPause(bool state) {
        _pausePanel.SetActive(state);
    }
}
