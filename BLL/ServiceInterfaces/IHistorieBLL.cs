using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IHistorieBLL
    {
        public List<HistoriaResponseDTO> get();
        public HistoriaResponseDTO getById(int id);
        public void add(HistoriaRequestDTO historiaRequestDTO);
        public void update(HistoriaRequestDTO hstoriaRequestDTO);
        public void delete(int id);
    }
}
