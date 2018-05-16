using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKho
{
    public static class Extention
    {
        public static void CreateLookUp(this LookUpEdit lookup, object DataSource, string ValueMember, string DisplayMember, string NullText, params LookUpColumnInfo[] _LookUpColumnInfo)
        {
            if (_LookUpColumnInfo.Length > 0)
            {
                lookup.Properties.Columns.AddRange(_LookUpColumnInfo);
            }
            else
            {
                lookup.Properties.Columns.AddRange(new LookUpColumnInfo[] { 
                new  LookUpColumnInfo(ValueMember,ValueMember),
                new  LookUpColumnInfo(DisplayMember,DisplayMember)
                });
            }
            lookup.Properties.NullText = string.IsNullOrWhiteSpace(NullText) ? "Vui lòng chọn giá trị" : NullText;
            lookup.Properties.DataSource = DataSource;
            lookup.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            lookup.Properties.DisplayMember = DisplayMember;
            lookup.Properties.ValueMember = ValueMember;
        }

        public static bool ValidateControl(this Control control, object value, string regex, DXErrorProvider dxErrorProvider, string messageError = "Vui lòng nhập giá trị")
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()) || new Regex(regex).Match(value.ToString()).Success == false)
            {
                dxErrorProvider.SetError(control, messageError);
                return false;
            }
            return true;
        }

        public static void ReadonlyColumn(this GridColumn column, Color? color = null)
        {
            column.OptionsColumn.ReadOnly = true;
            column.AppearanceCell.BackColor = color ?? Color.FromArgb(239, 244, 249);
        }

        public static void CreateCombobox(this GridColumn column, ICollection Datasource)
        {
            RepositoryItemComboBox _riEditor = new RepositoryItemComboBox();
            _riEditor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            _riEditor.Items.AddRange(Datasource);
            column.View.GridControl.RepositoryItems.Add(_riEditor);
            column.ColumnEdit = _riEditor;
            column.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
        }
    }
}
