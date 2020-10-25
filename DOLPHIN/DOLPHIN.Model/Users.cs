﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOLPHIN.Model
{
    public class Users : BaseEntity
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [Key]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets UserName.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets FullName.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets Joindate.
        /// </summary>
        public DateTime JoinDate { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets RoleUsers.
        /// </summary>
        public virtual ICollection<RoleUser> RoleUsers { get; set; }
    }
}
