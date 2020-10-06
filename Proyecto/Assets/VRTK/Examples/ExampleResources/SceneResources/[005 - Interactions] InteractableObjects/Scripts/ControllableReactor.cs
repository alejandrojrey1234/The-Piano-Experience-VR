namespace VRTK.Examples
{ 
    using UnityEngine.Audio;
    using UnityEngine;
    using UnityEngine.UI;
    using VRTK.Controllables;
    using System;
    using UnityEngine.Assertions.Must;

    public class ControllableReactor : MonoBehaviour
    {
        public VRTK_BaseControllable controllable;
        public Text displayText;
        public string outputOnMax = "Maximum Reached";
        public string outputOnMin = "Minimum Reached";
        AudioSource asource;
        AudioMixer mixer;

        public void Awake()
        {
            asource = GetComponent<AudioSource>();
        }
        protected virtual void OnEnable()
        {
            controllable = (controllable == null ? GetComponent<VRTK_BaseControllable>() : controllable);
            controllable.ValueChanged += ValueChanged;
            controllable.MaxLimitReached += MaxLimitReached;
            controllable.MinLimitReached += MinLimitReached;
        }

        private void OnCollisionExit(Collision collision)
        {
            
        }
        private void OnCollisionEnter(Collision collision)
        {
       

        }
        protected virtual void ValueChanged(object sender, ControllableEventArgs e)
        {
            //mixer.SetFloat("DefaultVol", e.value); CUANDO SE PRUEBA, SE LAGUEA MUCHO
            asource.Stop();
            asource.volume = e.value;
            if (displayText != null)
            {
               
                displayText.text = e.value.ToString("F1");
            }
        }

        protected virtual void MaxLimitReached(object sender, ControllableEventArgs e)
        {
            asource.Play();
            //FindObjectOfType<AudioManager>().Play(this.name);
            
            if (outputOnMax != "")
            {
                Debug.Log(outputOnMax);
            }
        }

        protected virtual void MinLimitReached(object sender, ControllableEventArgs e)
        {
            
            if (outputOnMin != "")
            {
                Debug.Log(outputOnMin);
            }
        }

        void Update()
        {
           
        }
    }
}