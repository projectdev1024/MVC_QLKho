using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKho.Code
{
    public abstract class abForm
    {
        public DevExpress.XtraGrid.Views.Grid.GridView mGridView { get; set; }
        public abstract bool Add();

        public abstract bool Delete(object p);

        public abstract bool Update(object p);

        public abstract void Init(DevExpress.XtraGrid.Views.Grid.GridView grv);

        public virtual DevExpress.XtraGrid.Columns.GridColumn CreateGridColumn(string FieldName, string Caption)
        {
            var colNam = new DevExpress.XtraGrid.Columns.GridColumn();
            colNam.Caption = Caption;
            colNam.FieldName = FieldName;
            colNam.Visible = true;
            return colNam;
        }

        public abstract void Reload();
        public abstract string GetText();

        public abstract void Save();
    }
}
