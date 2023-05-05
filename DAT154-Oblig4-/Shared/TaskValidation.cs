using DAT154_Oblig4_.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAT154_Oblig4_.Shared;

public partial class TaskValidation
{
    public int Id { get; set; }

    [Required]
    public DateTime? Date { get; set; }
    [Required]
    public string? Status { get; set; }
    [Required]
    public string? Type { get; set; }

    public string? Note { get; set; }
    [Required]
    public int? RoomId { get; set; } 

    public int? StaffId { get; set; }

    public Room? Room = null;
    public User? User = null;
}
