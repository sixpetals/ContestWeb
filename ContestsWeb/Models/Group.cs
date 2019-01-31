using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContestsWeb.Models {
    /// <summary>
    /// サークルなどのグループをしめす
    /// </summary>
    public class Group {
        public string Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime CreateAt { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime UpdateAt { get; set; }

        public string Name { get; set; }
        public bool Public { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// グループにはメンバーが所属する
        /// </summary>
        public virtual ICollection<Person> Members { get; set; }
    }
}
