using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ROE_HistoryType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payroll_ROE_Data_ReferenceField;

		private ROE_History_DataType[] rOE_History_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Payroll_ROE_Data_Reference
		{
			get
			{
				return this.payroll_ROE_Data_ReferenceField;
			}
			set
			{
				this.payroll_ROE_Data_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_ROE_Data_Reference");
			}
		}

		[XmlElement("ROE_History_Data", Order = 1)]
		public ROE_History_DataType[] ROE_History_Data
		{
			get
			{
				return this.rOE_History_DataField;
			}
			set
			{
				this.rOE_History_DataField = value;
				this.RaisePropertyChanged("ROE_History_Data");
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
