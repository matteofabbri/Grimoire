using System;

namespace Schema.Net
{
    [Serializable]
    public  class ImagingTest : MedicalTest
    {
        /*Imaging technique used.*/
        public  MedicalImagingTechnique[] imagingTechnique;
    }
}