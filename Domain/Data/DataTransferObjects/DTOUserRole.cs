using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Data.DataTransferObjects
{
    public class DTOUserRole
    {
        private int roleId = 2;
        public string UserId { get; set; }
        public int RoleId { get => roleId; set => RoleId = value; }
    }
}
