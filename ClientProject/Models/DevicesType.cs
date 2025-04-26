using System;
using System.Collections.Generic;

namespace ClientProject.Models;

public partial class DevicesType
{
    public int DevicesTypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Device> Devices { get; set; } = new List<Device>();
}
