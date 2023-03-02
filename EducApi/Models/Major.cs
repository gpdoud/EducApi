﻿using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EducApi.Models;

[Index("Code", IsUnique = true)]
public class Major {

    public int Id { get; set; }
    [StringLength(4)]
    public string Code { get; set; } = string.Empty;
    [StringLength(50)]
    public string Description { get; set; } = string.Empty;
    public int MinSat { get; set; }

    [JsonIgnore]
    public virtual ICollection<Student>? Students { get; set; }
}
