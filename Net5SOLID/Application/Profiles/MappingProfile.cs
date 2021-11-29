using Application.DTOs;
using Application.DTOs.LeaveAllocation;
using Application.DTOs.LeaveRequest;
using Application.DTOs.LeaveType;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<LeaveAllocation, CreateLeaveAllocationDto>().ReverseMap();
			CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();

			CreateMap<LeaveRequest, CreateLeaveRequestDto>().ReverseMap();
			CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
			CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();

			CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
		}
	}
}
