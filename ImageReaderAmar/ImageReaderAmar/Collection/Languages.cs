using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageReaderAmar.Collection
{
    class Languages
    {
        public string LangPack { get; set; }
        public string LangCode { get; set; }
        public Languages(string langPack, string langCode)
        {
            LangPack = langPack;
            LangCode = langCode;
        }

        public static List<Languages> GetAllAvailableLanguages(){
            List<Languages> languagesList = new List<Languages>()
            {
                // A
                // B
                new Languages("Bosnian", "bos"),
                // C
                new Languages("Chinese Simplified", "chi_sim"),
                new Languages("Chinese Traditional", "chi_tra"),
                new Languages("Croatian", "hrv"),
                // D
                // E
                new Languages("English", "eng"),
                // F
                // G
                // H
                // I
                new Languages("Italian", "ita"),
                // J
                // K
                new Languages("Korean", "kor"),
                // L
                // M
                // N
                // O
                // P
                new Languages("Portugese", "por"),
                // Q
                // R
                new Languages("Romanian", "ron"),
                new Languages("Russian", "rus"),
                // S
                new Languages("Slovenian", "slv"),
                new Languages("Spanish", "spa"),
                // T
                new Languages("Thai", "tha")
                // U
                // V
                // W
                // X
                // Y
                // Z
                // X
            };
            return languagesList;
        }
    }
}
