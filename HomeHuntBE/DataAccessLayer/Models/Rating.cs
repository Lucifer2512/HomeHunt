﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public partial class Rating : BaseEntity
{
    public Guid UserId { get; set; }

    public Guid RoomId { get; set; }

    public int Score { get; set; }

    public string Description { get; set; }

    public DateTime Date { get; set; }

    public virtual Room Room { get; set; }

    public virtual User User { get; set; }
}