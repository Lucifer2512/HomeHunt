﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public partial class Application
{
    public Guid Id { get; set; }

    public string FullName { get; set; }

    public string Dob { get; set; }

    public string Gender { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public Guid RoomId { get; set; }

    public Guid UserId { get; set; }

    public bool Status { get; set; }

    public virtual User User { get; set; }
}