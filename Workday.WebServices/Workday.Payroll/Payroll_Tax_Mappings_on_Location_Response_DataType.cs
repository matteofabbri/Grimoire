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
	public class Payroll_Tax_Mappings_on_Location_Response_DataType : INotifyPropertyChanged
	{
		private Payroll_Tax_Location_MappingType[] payroll_Tax_Location_MappingField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Tax_Location_Mapping", Order = 0)]
		public Payroll_Tax_Location_MappingType[] Payroll_Tax_Location_Mapping
		{
			get
			{
				return this.payroll_Tax_Location_MappingField;
			}
			set
			{
				this.payroll_Tax_Location_MappingField = value;
				this.RaisePropertyChanged("Payroll_Tax_Location_Mapping");
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
