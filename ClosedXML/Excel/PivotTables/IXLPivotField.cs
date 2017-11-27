using System;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
    public enum XLSortType
    {
        Manual = 0,
        Ascending = 1,
        Descending = 2
    }
    public enum XLSubtotalFunction
    {
        Automatic,
        None,
        Sum,
        Count,
        Average,
        Minimum,
        Maximum,
        Product,
        CountNumbers,
        StandardDeviation,
        PopulationStandardDeviation,
        Variance,
        PopulationVariance,
    }
    public enum XLPivotLayout { Outline, Tabular, Compact }
    public interface IXLPivotField
    {
        XLSortType SortType { get; set; }

        String SourceName { get; }
        String CustomName { get; set; }

        List<XLSubtotalFunction> Subtotals { get; }
        Boolean IncludeNewItemsInFilter { get; set; }

        XLPivotLayout Layout { get; set; }
        Boolean SubtotalsAtTop { get; set; }
        Boolean RepeatItemLabels { get; set; }
        Boolean InsertBlankLines  { get; set; }
        Boolean ShowBlankItems { get; set; }
        Boolean InsertPageBreaks { get; set; }
        Boolean Collapsed { get; set; }

        IXLPivotField SetCustomName(String value);

        IXLPivotField AddSubtotal(XLSubtotalFunction value);
        IXLPivotField SetIncludeNewItemsInFilter(); IXLPivotField SetIncludeNewItemsInFilter(Boolean value);

        IXLPivotField SetLayout(XLPivotLayout value);
        IXLPivotField SetSubtotalsAtTop(); IXLPivotField SetSubtotalsAtTop(Boolean value);
        IXLPivotField SetRepeatItemLabels(); IXLPivotField SetRepeatItemLabels(Boolean value);
        IXLPivotField SetInsertBlankLines(); IXLPivotField SetInsertBlankLines(Boolean value);
        IXLPivotField SetShowBlankItems(); IXLPivotField SetShowBlankItems(Boolean value);
        IXLPivotField SetInsertPageBreaks(); IXLPivotField SetInsertPageBreaks(Boolean value);
        IXLPivotField SetCollapsed(); IXLPivotField SetCollapsed(Boolean value);

        IList<Object> SelectedValues { get; }
        IXLPivotField AddSelectedValue(Object value);
    }
}
