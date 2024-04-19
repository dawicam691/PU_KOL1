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
        public List<HistoriaResponseDTO> getStronicowanie(int strona, int liczbaNaStrone);
        public HistoriaResponseDTO getById(int id);
        public void add(HistoriaRequestDTO historiaRequestDTO);
        
    }
}
