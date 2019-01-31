using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContestsWeb.Models {
    /// <summary>
    /// 競作の1イベントを示す
    /// </summary>
    public class CompetitionEvent {
        public string Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime CreateAt { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime UpdateAt { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// ひとつのイベントに複数の競作を設定出来る
        /// 期間が同じ競作はまとめたほうがいいので、ひとつしか無いことの方が多いと思う
        /// </summary>
        public virtual ICollection<Competition> Competitions { get; set; }

        /// <summary>
        /// ドラフト
        /// </summary>
        public bool IsDraft { get; set; }

        /// <summary>
        /// イベント公開グループ
        /// なにもなければ未公開？全てに公開される？
        /// </summary>
        public virtual ICollection<Group> Targets { get; set; }

    }
}
