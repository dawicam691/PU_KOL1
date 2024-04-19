using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IGrupyBLL
    {
        public List<GrupaResponseDTO> get();
        public GrupaResponseDTO getById(int id);
        public void add(GrupaRequestDTO grupaRequestDTO);
        public void update(GrupaRequestDTO grupaRequestDTO);
        public void delete(int id);
    }
}
