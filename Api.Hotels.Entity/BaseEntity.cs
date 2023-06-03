using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Hotels.Entity
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
