using System;

namespace Schema.Net
{
    [Serializable]
    public  class UserComments : UserInteraction
    {
        /*The string of the UserComment.*/
        public  string[] commentstring;
        /*The time at which the UserComment was made.*/
        public  string[] commentTime;
        /*The creator/author of this CreativeWork or UserComments. This is the same as the Author property for CreativeWork.*/
        public  Organization[] creator;
        /*Specifies the CreativeWork associated with the UserComment.*/
        public  CreativeWork[] discusses;
        /*The string at which a reply may be posted to the specified UserComment.*/
        public  string[] replyToUrl;
    }
}