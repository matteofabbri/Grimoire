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
	public class Purchase_Order_Lines_For_Amortization_Schedule_DataType : INotifyPropertyChanged
	{
		private decimal purchase_Order_Line_NumberField;

		private bool purchase_Order_Line_NumberFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Purchase_Order_Line_Number
		{
			get
			{
				return this.purchase_Order_Line_NumberField;
			}
			set
			{
				this.purchase_Order_Line_NumberField = value;
				this.RaisePropertyChanged("Purchase_Order_Line_Number");
			}
		}

		[XmlIgnore]
		public bool Purchase_Order_Line_NumberSpecified
		{
			get
			{
				return this.purchase_Order_Line_NumberFieldSpecified;
			}
			set
			{
				this.purchase_Order_Line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Purchase_Order_Line_NumberSpecified");
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
