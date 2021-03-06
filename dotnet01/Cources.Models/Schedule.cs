﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class Schedule : DomainObject
    {
        /// <summary>
        /// Ключевое поле
        /// </summary>
        public int Id
        {
            get;
            set;
        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Text { get; set; }
        public int? ParentId { get; set; }
        public int AppointmentId { get; set; }
       
        public virtual Schedule _Schedule { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}
