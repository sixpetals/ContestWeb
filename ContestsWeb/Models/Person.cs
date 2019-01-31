using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContestsWeb.Models {
    /// <summary>
    /// 人格。作者や所有者などで使う
    /// 登録されていない人も表したいのでユーザとは分離している
    /// </summary>
    public class Person {

        public string Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime CreateAt { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime UpdateAt { get; set; }

        /// <summary>
        /// この人格の名前
        /// （グループに表明するペンネームなど）
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// この人格のプロフィール
        /// </summary>
        public string Profile { get; set; }

        ///ユーザアカウントとも紐付けが出来る（なくてもよい）
    }
}
