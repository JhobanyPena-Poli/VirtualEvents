﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace VirtualEvent.Model.Models
{
    public partial class AttendanceAttanchments
    {
        public long AttendanceAttanchmentsId { get; set; }
        public long AttendanceId { get; set; }
        public string Name { get; set; }

        public virtual Attendances Attendance { get; set; }
    }
}