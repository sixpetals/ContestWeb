using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContestsWeb.Models {
    /// <summary>
    /// 俳句ひとつぶん
    /// </summary>
    public class HaikuWork {

        /// <summary>
        /// 俳句
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public Person Author { get; set; }


        /// <summary>
        /// お題
        /// </summary>
        public ICollection<CompetitionItem> Themes { get; set; }
    }
}
