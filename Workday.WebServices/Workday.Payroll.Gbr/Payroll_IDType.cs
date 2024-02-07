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
	public class Payroll_IDType : INotifyPropertyChanged
	{
		private Payroll_IDObjectType payroll_ID_ReferenceField;

		private Payroll_ID_Data_DisplayType payroll_ID_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_IDObjectType Payroll_ID_Reference
		{
			get
			{
				return this.payroll_ID_ReferenceField;
			}
			set
			{
				this.payroll_ID_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_ID_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Payroll_ID_Data_DisplayType Payroll_ID_Data
		{
			get
			{
				return this.payroll_ID_DataField;
			}
			set
			{
				this.payroll_ID_DataField = value;
				this.RaisePropertyChanged("Payroll_ID_Data");
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
