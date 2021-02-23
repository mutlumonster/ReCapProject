using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Translation
{
    public interface ITranslate
    {
        string baseLanguage { get; }
        string targetLanguage { get; }
        string Message { get; }

    }
}
