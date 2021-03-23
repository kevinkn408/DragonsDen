using UnityEngine;
using UnityEngine.UI;
using System;

namespace RPG.Stats
{
    public class ExperienceDisplay : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] Text experienceDisplay = null;
        Experience experience;

        void Awake()
        {
            experience = GameObject.FindWithTag("Player").GetComponent<Experience>();
        }

        // Update is called once per frame
        void Update()
        {
            experienceDisplay.text = String.Format("{0:0}", experience.GetExperiencePoints().ToString());
        }
    }
}
