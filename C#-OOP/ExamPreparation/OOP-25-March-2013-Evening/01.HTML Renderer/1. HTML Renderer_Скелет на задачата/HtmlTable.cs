using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    public class HtmlTable : HtmlElement, ITable
    {
        private const string TABLE_NAME = "table";
        private const string TABLE_ROW_OPEN_TAG = "<tr>";
        private const string TABLE_ROW_CLOSE_TAG = "</tr>";
        private const string TABLE_CELL_OPEN_TAG = "<td>";
        private const string TABLE_CELL_CLOSE_TAG = "</td>";

        private int rows;
        private int cols;
        private IElement[,] cells;

        public HtmlTable(int rows, int cols)
            : base(TABLE_NAME)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cells = new IElement[rows, cols];
        }

        public int Rows
        {
            get { return this.rows; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Html table rows cannot be negative!");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get { return this.cols; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Html table rows cannot be negative!");
                }

                this.cols = value;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                this.ValidateIndecies(row, col);
                return this.cells[row, col];
            }
            set
            {
                this.ValidateIndecies(row, col);
                if (value == null)
                {
                    throw new ArgumentNullException("value", "HTML element in table cell cannot be null");
                }

                this.cells[row, col] = value;
            }
        }

        private void ValidateIndecies(int row, int col)
        {
            if (row < 0 || row >= this.Rows)
            {
                throw new IndexOutOfRangeException("Provided row is out of the boundries of the HTML table");
            }

            if (col < 0 || col >= this.Rows)
            {
                throw new IndexOutOfRangeException("Provided row is out of the boundries of the HTML table");
            }
        }

        public override void AddElement(IElement element)
        {
            throw new InvalidOperationException("HTML tables do not have child elements!");
        }

        public override IEnumerable<IElement> ChildElements
        {
            get
            {
                throw new InvalidOperationException("HTML tables do not have child elements");
            }
        }

        public override string TextContent
        {
            get
            {
                throw new InvalidOperationException("HTML tables do not have text content");
            }
            set
            {
                throw new InvalidOperationException("HTML tables do not have text content");
            }
        }

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", this.Name);

            for (int row = 0; row < this.Rows; row++)
            {
                output.Append(TABLE_ROW_OPEN_TAG);

                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append(TABLE_CELL_OPEN_TAG);
                    output.Append(this.cells[row, col].ToString());
                    output.Append(TABLE_CELL_CLOSE_TAG);
                }

                output.Append(TABLE_ROW_CLOSE_TAG);
            }

            output.AppendFormat("</{0}>", this.Name);
        }
    }
}
