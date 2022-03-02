using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OpsPipelineAPI.Entities.Entity;
using OpsPipelineAPI.Manager.Command;

namespace OpsPipelineAPI.Manager.Handlers.Sales
{
    public class CreateSaleCommandHandler : IRequestHandler<CreateSaleCommand, ProcessingStatusEntity>
    {
        public Task<ProcessingStatusEntity> Handle(CreateSaleCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
