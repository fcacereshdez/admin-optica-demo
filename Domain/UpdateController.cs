using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UpdateController
    {
        UpdateData updateData = new UpdateData();

        public void SearchRecentUpdate()
        {
            updateData.SearchRecentUpdate();
        }

        public void CloseUpdate()
        {
            updateData.CloseUpdate(Common.Models.Update.id_version);
        }
    }
}
