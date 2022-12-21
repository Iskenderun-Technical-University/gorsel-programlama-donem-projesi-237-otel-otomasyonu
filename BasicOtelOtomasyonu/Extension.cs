using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicOtelOtomasyonu
{
    public static class Extension
    {
        public static void ExPopup(this GridView grid, PopupMenu popup, bool RowControl = true)
        {
            grid.PopupMenuShowing += (s, e) =>
            {
                var view = s as GridView;
                DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (RowControl)
                {
                    if (hitInfo.InRowCell && hitInfo.RowHandle > -1)
                    {
                        view.FocusedRowHandle = hitInfo.RowHandle;
                        view.FocusedColumn = hitInfo.Column;
                        popup.ShowPopup(Control.MousePosition);
                    }
                }
                else
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    view.FocusedColumn = hitInfo.Column;
                    popup.ShowPopup(Control.MousePosition);
                }
            };
        }
        public static int ToInt(this object key)
        {
            int value = 0;
            if (key != null)
                int.TryParse(key.ToString(), out value);
            return value;
        }


        public static DateTime? ToDateTime(this object key)
        {
            DateTime? deger = null;
            if (key != null)
            {
                try
                {
                    var date = new DateTime();
                    if (DateTime.TryParse(key.ToString(), out date))
                        return date;
                    else
                        return null;
                }
                catch
                {
                }
            }
            return deger;
        }


        public static void ExAddNewColumn<T, U>(this GridView grid, Expression<Func<T, U>> expression, string caption, bool visible = true, int width = 100, bool edit = true)
        {
            var name = GetMemberName(expression);
            if (name != null)
            {
                if (!grid.Columns.Contains(grid.Columns.ColumnByFieldName(name)))
                {
                    var column = new DevExpress.XtraGrid.Columns.GridColumn()
                    {
                        Caption = "",
                        FieldName = name,
                        Visible = visible,
                        Name = "col" + name,
                        Width = width,
                        SortMode = DevExpress.XtraGrid.ColumnSortMode.Default,
                        FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText,
                    };
                    if (width != 100) { column.MinWidth = 20; column.BestFit(); }
                    column.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
                    if (!edit)
                    {
                        column.OptionsColumn.AllowEdit = edit;
                        column.OptionsColumn.ReadOnly = !edit;

                    }
                    grid.Columns.Add(column);
                }
            }

        }

        public static string GetMemberName<T, U>(Expression<Func<T, U>> expression)
        {
            if (expression != null)
            {
                var member = expression.Body as MemberExpression;
                if (member != null)
                    return member.Member.Name;
            }

            throw new ArgumentException("Expression is not a member access", "expression");
        }
    }



}
