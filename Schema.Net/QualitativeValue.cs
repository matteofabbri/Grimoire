using System;

namespace Schema.Net
{
    [Serializable]
    public  class QualitativeValue : Enumeration
    {
        /*This ordering relation for qualitative values indicates that the subject is equal to the object.*/
        public  QualitativeValue[] equal;
        /*This ordering relation for qualitative values indicates that the subject is greater than the object.*/
        public  QualitativeValue[] greater;
        /*This ordering relation for qualitative values indicates that the subject is greater than or equal to the object.*/
        public  QualitativeValue[] greaterOrEqual;
        /*This ordering relation for qualitative values indicates that the subject is lesser than the object.*/
        public  QualitativeValue[] lesser;
        /*This ordering relation for qualitative values indicates that the subject is lesser than or equal to the object.*/
        public  QualitativeValue[] lesserOrEqual;
        /*This ordering relation for qualitative values indicates that the subject is not equal to the object.*/
        public  QualitativeValue[] nonEqual;
        /*A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.*/
        public  Enumeration[] valueReference;
    }
}