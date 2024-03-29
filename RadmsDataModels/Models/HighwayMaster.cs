﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("HighwayMaster")]
    public partial class HighwayMaster
    {
        public HighwayMaster()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("HID")]
        [StringLength(6)]
        [Unicode(false)]
        public string Hid { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string Hname { get; set; } = null!;
        [Column("HTypeID")]
        [ForeignKey("HtypeId")]
        public int? HtypeId { get; set; }
        [Column("HOwnerID")]
        [ForeignKey("HownerId")]
        [StringLength(3)]
        [Unicode(false)]
        public string? HownerId { get; set; }
        public int? Hlength { get; set; }
        public int? StartChange { get; set; }
        public int? EndChanage { get; set; }

       
        [InverseProperty("HighwayMasters")]
        public virtual HighwayOwnerMaster? Howner { get; set; }
       
        [InverseProperty("HighwayMasters")]
        public virtual HighwayTypeLookup? Htype { get; set; }
        [InverseProperty("HidNavigation")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
