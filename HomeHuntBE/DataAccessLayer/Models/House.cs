﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public partial class House
{
    public Guid Id { get; set; }

    public string Address { get; set; }

    public string Ward { get; set; }

    public string District { get; set; }

    public string City { get; set; }

    public bool Status { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}