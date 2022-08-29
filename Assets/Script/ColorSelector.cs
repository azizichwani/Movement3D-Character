﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TankU.ColorSelection
{
    public class ColorSelector : MonoBehaviour
    {
        [SerializeField]
        private Button btnNext;
        [SerializeField] 
        GameObject _tutorialPanel;
        [SerializeField]
        private GameObject[] colorView;
        [SerializeField]
        private Button[] btnPicks;
        [SerializeField]
        private Material[] _playerMaterials;
        [SerializeField]
        private Color[] colors;

        private int[] _indexSelected;

        private void Awake()
        {
            btnNext.onClick.AddListener(OnSelection);
            for (int i = 0; i < btnPicks.Length; i++)
            {
                int x = i;
                btnPicks[i].onClick.AddListener(delegate { ChangeMaterial(x); });
            }
            _indexSelected = new int[_playerMaterials.Length];
            for (int i = 0; i < _indexSelected.Length; i++)
            {
                _indexSelected[i] = 0;
                colorView[i].GetComponent<Image>().color = colors[0];
            }
        }

        public void ChangeMaterial(int _index)
        {
            if(_indexSelected[_index] == colors.Length - 1)
            {
                _indexSelected[_index] = 0;
            }
            else
            {
                _indexSelected[_index]++;
            }
            colorView[_index].GetComponent<Image>().color = colors[_indexSelected[_index]];
        }

        private void OnSelection()
        {
            for(int i = 0; i < _playerMaterials.Length; i++)
            {
                _playerMaterials[i].color = colors[_indexSelected[i]];
            }

            _tutorialPanel.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}

