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
	public class Multiple_Worksite_Report_State_DataType : INotifyPropertyChanged
	{
		private Payroll_Tax_AuthorityObjectType state_Tax_Authority_ReferenceField;

		private string state_UI_Account_NumberField;

		private Worksite_DataType[] worksite_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Tax_AuthorityObjectType State_Tax_Authority_Reference
		{
			get
			{
				return this.state_Tax_Authority_ReferenceField;
			}
			set
			{
				this.state_Tax_Authority_ReferenceField = value;
				this.RaisePropertyChanged("State_Tax_Authority_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string State_UI_Account_Number
		{
			get
			{
				return this.state_UI_Account_NumberField;
			}
			set
			{
				this.state_UI_Account_NumberField = value;
				this.RaisePropertyChanged("State_UI_Account_Number");
			}
		}

		[XmlElement("Worksite_Data", Order = 2)]
		public Worksite_DataType[] Worksite_Data
		{
			get
			{
				return this.worksite_DataField;
			}
			set
			{
				this.worksite_DataField = value;
				this.RaisePropertyChanged("Worksite_Data");
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
