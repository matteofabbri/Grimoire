using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalTestPanel : MedicalTest
    {
        /*A component test of the panel.*/
        public  MedicalTest[] subTest;
    }
}