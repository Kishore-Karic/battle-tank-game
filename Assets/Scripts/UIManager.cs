using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button quitButton, okButton, cancelButton;
    [SerializeField] private GameObject buttonLayer, quitLayer;
    private void Awake()
    {
        quitButton.onClick.AddListener(Quit);
        okButton.onClick.AddListener(QuitOk);
        cancelButton.onClick.AddListener(QuitCancel);
    }

    private void Quit()
    {
        buttonLayer.SetActive(false);
        quitLayer.SetActive(true);
    }

    private void QuitOk()
    {
        Application.Quit();
    }

    private void QuitCancel()
    {
        buttonLayer.SetActive(true);
        quitLayer.SetActive(false);
    }
}
