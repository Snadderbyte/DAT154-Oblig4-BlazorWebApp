﻿using System;
using System.Collections.Generic;

namespace DAT154_Oblig4_.Shared;

public partial class Room
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public int? Beds { get; set; }

    public string? Size { get; set; }

    public string? Quality { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual ICollection<Task_db> Tasks { get; set; } = new List<Task_db>();
}
