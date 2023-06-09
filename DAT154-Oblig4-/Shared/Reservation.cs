﻿using System;
using System.Collections.Generic;

namespace DAT154_Oblig4_.Shared;

public partial class Reservation
{
    public int Id { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? RoomId { get; set; }

    public int? CustomerId { get; set; }

    public virtual User? Customer { get; set; }

    public virtual Room? Room { get; set; }
}
