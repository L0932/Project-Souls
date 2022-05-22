using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace ALO
{
    public class InteractableUI : MonoBehaviour
    {
        public TextMeshProUGUI popupText;
        public Image itemImage;

        private void Start()
        {
            popupText = GetComponentInChildren<TextMeshProUGUI>();
        }

        public void SetText(string text)
        {
            if (popupText != null)
                popupText.text = text;
        }

        public void SetUIImageSprite(Sprite sprite)
        {
            itemImage.sprite = sprite;
        }
    }
}
