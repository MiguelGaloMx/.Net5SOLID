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
	public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
	{
		private readonly ILeaveTypeRepository _leaveTypeRepository;
		private readonly IMapper _mapper;
		public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository
			, IMapper mapper)
		{
			_leaveTypeRepository = leaveTypeRepository;
			_mapper = mapper;
		}
		public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
		{
			var leaveTypes = await _leaveTypeRepository.GetAll();
			return _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
		}
	}
}
