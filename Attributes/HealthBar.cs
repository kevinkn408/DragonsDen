using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Attributes
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] Health healthComponent = null;
        [SerializeField] RectTransform foreGround = null;
        [SerializeField] float healthbarDisableFadeTime = 0.2f;

        void Update()
        {

            if(Mathf.Approximately(healthComponent.GetHealthFraction(), 0))
            {
                StartCoroutine(DisableHealthBar());
            }
            foreGround.localScale = new Vector3(healthComponent.GetHealthFraction(), 1, 1);
        }

        private IEnumerator DisableHealthBar()
        {
            yield return new WaitForSeconds(healthbarDisableFadeTime);
            GetComponentInChildren<Canvas>().enabled = false;

        }
    }

}