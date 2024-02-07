using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Result_Country_DataType : INotifyPropertyChanged
	{
		private CountryObjectType[] country_ReferenceField;

		private Payroll_Result_UK_DataType[] payroll_Result_UK_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Country_Reference", Order = 0)]
		public CountryObjectType[] Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement("Payroll_Result_UK_Data", Order = 1)]
		public Payroll_Result_UK_DataType[] Payroll_Result_UK_Data
		{
			get
			{
				return this.payroll_Result_UK_DataField;
			}
			set
			{
				this.payroll_Result_UK_DataField = value;
				this.RaisePropertyChanged("Payroll_Result_UK_Data");
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
