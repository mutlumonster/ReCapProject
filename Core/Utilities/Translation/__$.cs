using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Translation;

namespace Core.Utilities.Result
{
    public class __ : ITranslate
    {
        public string baseLanguage { get; }
        public string targetLanguage { get; }
        public string Message { get; }

        public __(string baselanguage, string targetlanguage, string message):this(targetlanguage,message)
        {
            //return new __("en", "Message")
            //return new __("en", "Message")

            baseLanguage = baselanguage;
            targetLanguage = targetLanguage;
            Message = message;
        }

        public __(string targetlanguage, string message)
        {
            targetLanguage = targetLanguage;
            Message = message;
        }


    }
}
