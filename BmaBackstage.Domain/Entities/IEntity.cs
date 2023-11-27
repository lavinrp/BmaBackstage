﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    public interface IEntity
    {
        /// <summary>
        /// Unique identifier 
        /// </summary>
        Guid Id { get; }
    }
}
