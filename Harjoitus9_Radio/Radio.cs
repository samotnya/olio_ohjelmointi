using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9_Radio
{
    internal class Radio
    {
        private bool kytkin { get; set; }
        private float aanenvoimakkuudenSaadin
        {
            get { return aanenvoimakkuudenSaadin; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 9)
                {
                    value = 9;
                }

                aanenvoimakkuudenSaadin = value;
            }

        }

        private float kanavanValinta
        {
            get { return kanavanValinta; }
            set
            {
                if (value < 88.0)
                {
                    value = 88.0f;
                }
                else if (value > 107.9)
                {
                    value = 107.9f;
                }
                kanavanValinta = value;
            }


        }
        public void SetKytkin(bool _kytkin)
        {
            kytkin = _kytkin;
        }
        public bool GetKytkin()
        {
            return kytkin;
        }
        public void SetKanavaValinta(float _kanavaValinta)
        {
            kanavanValinta = _kanavaValinta;
        }
        public float GetKanavaValinta() 
        { 
            return kanavanValinta; 
        }
        public void SetAanenvoimakkuudenSaadin(float _kananavanValinta)
        {
            aanenvoimakkuudenSaadin = _kananavanValinta;
        }
        public float GetAanenvoimakkuudenSaadin()
        {
            return aanenvoimakkuudenSaadin;
        }

    }
}
