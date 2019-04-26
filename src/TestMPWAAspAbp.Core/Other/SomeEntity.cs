using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestMPWAAspAbp.Other
{
    public class SomeEntity : Entity<string>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override string Id { get; set; }
    }
}
