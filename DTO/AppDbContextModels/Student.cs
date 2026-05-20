using System;
using System.Collections.Generic;

namespace DTO.AppDbContextModels;

public partial class Student
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }
}
