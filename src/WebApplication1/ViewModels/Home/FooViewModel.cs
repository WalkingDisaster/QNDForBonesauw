namespace WebApplication1.ViewModels.Home
{
    public class FooViewModel
    {
        public string SendThankYouEmail { get; set; }
        public BasicInfoViewModel BasicInfo { get; set; }
        public string PreferredDay { get; set; }

        public string PreferredTime { get; set; }

        public bool FormIsLicensedAgent { get; set; }

        public bool FormEmailOptIn { get; set; }
        /*
            "SendThankYouEmail": "True",
            "BasicInfo.FullName": "Shawn Lee",
            "BasicInfo.EmailAddress": "(662) 622-6263",
            "BasicInfo.QuestionOrComments": "asdf",
            "PreferredDay": "Wednesday",
            "PreferredTime": "Afternoon",
            "FormIsLicensedAgent": "true",
            "FormEmailOptIn": "true"
        */
    }

    public class BasicInfoViewModel
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string QuestionOrComments { get; set; }
    }
}