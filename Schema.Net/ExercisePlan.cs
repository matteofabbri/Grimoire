using System;

namespace Schema.Net
{
    [Serializable]
    public  class ExercisePlan : CreativeWork
    {
        /*Length of time to engage in the activity.*/
        public  string[] activityDuration;
        /*How often one should engage in the activity.*/
        public  string[] activityFrequency;
        /*Any additional component of the exercise prescription that may need to be articulated to the patient. This may include the order of exercises, the string of repetitions of movement, quantitative distance, progressions over time, etc.*/
        public  string[] additionalVariable;
        /*Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.*/
        public  string[] exerciseType;
        /*Quantitative measure gauging the degree of force involved in the exercise, for example, heartbeats per minute. May include the velocity of the movement.*/
        public  string[] intensity;
        /*string of times one should repeat the activity.*/
        public  string[] repetitions;
        /*How often one should break from the activity.*/
        public  string[] restPeriods;
        /*Quantitative measure of the physiologic output of the exercise; also referred to as energy expenditure.*/
        public  string[] workload;
    }
}