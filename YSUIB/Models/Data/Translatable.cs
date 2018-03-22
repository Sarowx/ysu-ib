using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
    public string Value
    {
        get
        {
            return base.GetValueFromTranslation(this);
        }
    }

*/

namespace YSUIB.Models.Data
{
    public class Translator
    {
        private const string DefaultLanguageCode = "am";
        public string LanguageCode
        {
            get;
            set;
        }

        public Translator()
        {
            LanguageCode = DefaultLanguageCode;
        }

        protected string GetValueFromTranslation(Translation t)
        {
            string value;

            if (t.Entries.Any(e => e.Language.Code == LanguageCode))
            {
                value = (from v in t.Entries
                         where v.Language.Code == LanguageCode
                         select v.Value).First();
            }
            else if (t.Entries.Any(e => e.Language.Code == DefaultLanguageCode))
            {
                value = (from v in t.Entries
                         where v.Language.Code == DefaultLanguageCode
                         select v.Value).First();
            }
            else if(t.Entries.Any())
            {
                value = t.Entries.First().Value;
            }
            else
            {
                value = "";
            }

            return value;
        }

        protected string GetValueFromTranslation(TranslationText t)
        {
            string value;

            if (t.Entries.Any(e => e.Language.Code == LanguageCode))
            {
                value = (from v in t.Entries
                         where v.Language.Code == LanguageCode
                         select v.Value).First();
            }
            else if (t.Entries.Any(e => e.Language.Code == DefaultLanguageCode))
            {
                value = (from v in t.Entries
                         where v.Language.Code == DefaultLanguageCode
                         select v.Value).First();
            }
            else if (t.Entries.Any())
            {
                value = t.Entries.First().Value;
            }
            else
            {
                value = "";
            }

            return value;
        }
    }
}