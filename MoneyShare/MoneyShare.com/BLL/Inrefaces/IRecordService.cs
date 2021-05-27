using MoneyShare.Core.BLL.DTO;
using System.Collections.Generic;

namespace MoneyShare.Core.BLL.Inrefaces
{
    public interface IRecordService
    {
        public void CreateRecord(RecordDTO recod);
        public IEnumerable<RecordDTO> GetRecords();
        public RecordDTO GetRecord(int id);
        void Dispose();
    }
}
