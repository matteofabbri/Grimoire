using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_SSP_HistoryType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payroll_SSP_History_ReferenceField;

		private Payroll_SSP_History_DataType[] payroll_SSP_History_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Payroll_SSP_History_Reference
		{
			get
			{
				return this.payroll_SSP_History_ReferenceField;
			}
			set
			{
				this.payroll_SSP_History_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_SSP_History_Reference");
			}
		}

		[XmlElement("Payroll_SSP_History_Data", Order = 1)]
		public Payroll_SSP_History_DataType[] Payroll_SSP_History_Data
		{
			get
			{
				return this.payroll_SSP_History_DataField;
			}
			set
			{
				this.payroll_SSP_History_DataField = value;
				this.RaisePropertyChanged("Payroll_SSP_History_Data");
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
