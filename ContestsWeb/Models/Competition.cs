using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContestsWeb.Models {
    /// <summary>
    /// 競作の1イベントを示す
    /// </summary>
    public class Competition {
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
        /// 作品募集開始日時
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime CollectionStartAt { get; set; }

        /// <summary>
        /// 作品募集終了日時
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime CollectionEndAt { get; set; }

        /// <summary>
        /// 作品選定開始日時
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime SelectionStartAt { get; set; }

        /// <summary>
        /// 作品選定終了日時
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime SelectionEndAt { get; set; }


        /// <summary>
        /// 所属する競作イベント
        /// </summary>
        public CompetitionEvent CompetitionEvent { get; set; }
    }
}
