

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class ParametrosSistemaAppService : AppServiceBase<ParametrosSistema>, IParametrosSistemaAppService
    {
        private readonly IParametrosSistemaService _parametrosSistema;

        public ParametrosSistemaAppService(IParametrosSistemaService parametrosSistema)
            :base(parametrosSistema)
        {
            _parametrosSistema = parametrosSistema;
        }

    }
}
