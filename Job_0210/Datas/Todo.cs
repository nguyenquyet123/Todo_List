using System;
using System.Collections.Generic;

namespace Job_0210.Datas;

public partial class Todo
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Description { get; set; }
}
