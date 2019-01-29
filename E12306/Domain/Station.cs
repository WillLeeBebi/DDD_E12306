﻿using E12306.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E12306.Domain
{
    /// <summary>
    /// 实体
    /// </summary>
    [Table("Station")]
    public class Station : EntityBase
    {
        protected Station()
        {
        }
        public Station(string Code, string Name)
        {
            this.Code = Code;
            this.Name = Name;

           
            AddTime = DateTimeOffset.Now;
            UpdateTime = DateTimeOffset.Now;
            AddUserId = UserHelper.User.Id;
            UpdateUserId = UserHelper.User.Id;
        }


        [Required]
        [MaxLength(50)]
        public string Code { get; private set; }
        /// <summary>
        /// 站名
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; private set; }



    }
}
