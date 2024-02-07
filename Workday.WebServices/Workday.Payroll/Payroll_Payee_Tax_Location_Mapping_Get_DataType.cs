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
	public class Payroll_Payee_Tax_Location_Mapping_Get_DataType : INotifyPropertyChanged
	{
		private Payroll_Payee_Tax_Location_MappingObjectType payroll_Payee_Tax_Location_Mapping_ReferenceField;

		private Payroll_Payee_Tax_Location_Mapping_DataType payroll_Payee_Tax_Location_Mapping_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Payee_Tax_Location_MappingObjectType Payroll_Payee_Tax_Location_Mapping_Reference
		{
			get
			{
				return this.payroll_Payee_Tax_Location_Mapping_ReferenceField;
			}
			set
			{
				this.payroll_Payee_Tax_Location_Mapping_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Payee_Tax_Location_Mapping_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Payroll_Payee_Tax_Location_Mapping_DataType Payroll_Payee_Tax_Location_Mapping_Data
		{
			get
			{
				return this.payroll_Payee_Tax_Location_Mapping_DataField;
			}
			set
			{
				this.payroll_Payee_Tax_Location_Mapping_DataField = value;
				this.RaisePropertyChanged("Payroll_Payee_Tax_Location_Mapping_Data");
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
