using Application.DTOs.Commun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.LeaveType
{
	public class LeaveTypeDto : BaseDto
	{
		public string Name { get; set; }
		public int DefaultDays { get; set; }
	}
}
