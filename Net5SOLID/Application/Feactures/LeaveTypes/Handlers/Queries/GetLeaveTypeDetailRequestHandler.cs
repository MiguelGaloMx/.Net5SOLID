using Application.DTOs;
using Application.DTOs.LeaveType;
using Application.Feactures.LeaveTypes.Requests.Queries;
using Application.Persistance.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Feactures.LeaveTypes.Handlers.Queries
{
	public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
	{
		private readonly ILeaveTypeRepository _leaveTypeRepository;
		private readonly IMapper _mapper;

		public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository
			, IMapper mapper)
		{
			_leaveTypeRepository = leaveTypeRepository;
			_mapper = mapper;
		}

		public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
		{
			var leaveType = await _leaveTypeRepository.Get(request.Id);
			return _mapper.Map<LeaveTypeDto>(leaveType);
		}
	}
}
