using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Return_Line_Split_DataType : INotifyPropertyChanged
	{
		private decimal quantity_for_Distribution_LineField;

		private bool quantity_for_Distribution_LineFieldSpecified;

		private decimal currency_Amount_for_Distribution_LineField;

		private string memoField;

		private Business_Document_Line_SplitObjectType line_Split_Allocated_From_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Quantity_for_Distribution_Line
		{
			get
			{
				return this.quantity_for_Distribution_LineField;
			}
			set
			{
				this.quantity_for_Distribution_LineField = value;
				this.RaisePropertyChanged("Quantity_for_Distribution_Line");
			}
		}

		[XmlIgnore]
		public bool Quantity_for_Distribution_LineSpecified
		{
			get
			{
				return this.quantity_for_Distribution_LineFieldSpecified;
			}
			set
			{
				this.quantity_for_Distribution_LineFieldSpecified = value;
				this.RaisePropertyChanged("Quantity_for_Distribution_LineSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Currency_Amount_for_Distribution_Line
		{
			get
			{
				return this.currency_Amount_for_Distribution_LineField;
			}
			set
			{
				this.currency_Amount_for_Distribution_LineField = value;
				this.RaisePropertyChanged("Currency_Amount_for_Distribution_Line");
			}
		}

		[XmlElement(Order = 2)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement(Order = 3)]
		public Business_Document_Line_SplitObjectType Line_Split_Allocated_From_Reference
		{
			get
			{
				return this.line_Split_Allocated_From_ReferenceField;
			}
			set
			{
				this.line_Split_Allocated_From_ReferenceField = value;
				this.RaisePropertyChanged("Line_Split_Allocated_From_Reference");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
