using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Application_BatchType : INotifyPropertyChanged
	{
		private Application_BatchObjectType batch_ReferenceField;

		private Application_Batch_DataType batch_DataField;

		private Input_Line_Currency_Totals_DataType[] batch_Totals_DataField;

		private Batch_Pay_Component_Totals_DataType[] batch_Pay_Component_Totals_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Application_BatchObjectType Batch_Reference
		{
			get
			{
				return this.batch_ReferenceField;
			}
			set
			{
				this.batch_ReferenceField = value;
				this.RaisePropertyChanged("Batch_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Application_Batch_DataType Batch_Data
		{
			get
			{
				return this.batch_DataField;
			}
			set
			{
				this.batch_DataField = value;
				this.RaisePropertyChanged("Batch_Data");
			}
		}

		[XmlElement("Batch_Totals_Data", Order = 2)]
		public Input_Line_Currency_Totals_DataType[] Batch_Totals_Data
		{
			get
			{
				return this.batch_Totals_DataField;
			}
			set
			{
				this.batch_Totals_DataField = value;
				this.RaisePropertyChanged("Batch_Totals_Data");
			}
		}

		[XmlElement("Batch_Pay_Component_Totals_Data", Order = 3)]
		public Batch_Pay_Component_Totals_DataType[] Batch_Pay_Component_Totals_Data
		{
			get
			{
				return this.batch_Pay_Component_Totals_DataField;
			}
			set
			{
				this.batch_Pay_Component_Totals_DataField = value;
				this.RaisePropertyChanged("Batch_Pay_Component_Totals_Data");
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
